﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System;
using System.Collections.Concurrent;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;

using Azure.Core;
using Azure.Identity;

using Hyak.Common;
using Microsoft.Azure.Commands.Common.Authentication;
using Microsoft.Azure.Commands.Common.Authentication.Abstractions;

namespace Microsoft.Azure.PowerShell.Authenticators
{
    /// <summary>
    /// Authenticator for user interactive authentication
    /// </summary>
    public class InteractiveUserAuthenticator : DelegatingAuthenticator
    {
        // possible ports for adfs: [8405, 8408)
        // worked with stack team to pre-configure this in their deployment
        private const int AdfsPortStart = 8405;
        private const int AdfsPortEnd = 8408;
        // possible ports for aad: [8400, 9000)
        private const int AadPortStart = 8400;
        private const int AadPortEnd = 9000;

        private bool EnablePersistenceCache { get; set; }

        private ConcurrentDictionary<string, InteractiveBrowserCredential> UserCredentialMap = new ConcurrentDictionary<string, InteractiveBrowserCredential>(StringComparer.OrdinalIgnoreCase);

        public InteractiveUserAuthenticator(bool enablePersistentCache = true)
        {
            EnablePersistenceCache = enablePersistentCache;
        }

        public override Task<IAccessToken> Authenticate(AuthenticationParameters parameters, CancellationToken cancellationToken)
        {
            var interactiveParameters = parameters as InteractiveParameters;
            var onPremise = interactiveParameters.Environment.OnPremise;
            var tenantId = onPremise ? AdfsTenant : interactiveParameters.TenantId;
            var authenticationClientFactory = interactiveParameters.AuthenticationClientFactory;
            var resource = interactiveParameters.Environment.GetEndpoint(interactiveParameters.ResourceId) ?? interactiveParameters.ResourceId;
            var scopes = AuthenticationHelpers.GetScope(onPremise, resource);
            var clientId = AuthenticationHelpers.PowerShellClientId;

            var requestContext = new TokenRequestContext(scopes);

            InteractiveBrowserCredential browserCredential = null;
            if (!string.IsNullOrEmpty(interactiveParameters.UserId))
            {
                if (!UserCredentialMap.TryGetValue(interactiveParameters.UserId, out browserCredential))
                {
                    var options = new InteractiveBrowserCredentialOptions()
                    {
                        ClientId = clientId,
                        TenantId = tenantId,
                        EnablePersistentCache = EnablePersistenceCache,
                        AllowUnencryptedCache = true,
                        AuthenticationRecord = new AuthenticationRecord(
                            interactiveParameters.UserId,
                            authority: null,
                            homeAccountId: interactiveParameters.HomeAccountId,
                            tenantId: parameters.TenantId,
                            clientId: clientId)
                    };
                    browserCredential = new InteractiveBrowserCredential(options);
                    UserCredentialMap[interactiveParameters.UserId] = browserCredential;
                }
                var tokenTask = browserCredential.GetTokenAsync(requestContext, cancellationToken);
                return MsalAccessToken.GetAccessTokenAsync(tokenTask, parameters.TenantId, interactiveParameters.UserId);
            }
            else//first time login
            {
                var options = new InteractiveBrowserCredentialOptions()
                {
                    ClientId = clientId,
                    TenantId = tenantId,
                    EnablePersistentCache = EnablePersistenceCache,
                    AllowUnencryptedCache = true,
                };
                browserCredential = new InteractiveBrowserCredential(options);
                var authTask = browserCredential.AuthenticateAsync(cancellationToken);
                return MsalAccessToken.GetAccessTokenAsync(
                    authTask,
                    () => browserCredential.GetTokenAsync(requestContext, cancellationToken),
                    (AuthenticationRecord record) => { UserCredentialMap[record.Username] = browserCredential; });
            }
        }

        //private string GetReplyUrl(bool onPremise, InteractiveParameters interactiveParameters)
        //{
        //    return string.Format("http://localhost:{0}", GetReplyUrlPort(onPremise, interactiveParameters));
        //}

        //private int GetReplyUrlPort(bool onPremise, InteractiveParameters interactiveParameters)
        //{
        //    int portStart = onPremise ? AdfsPortStart : AadPortStart;
        //    int portEnd = onPremise ? AdfsPortEnd : AadPortEnd;

        //    int port = portStart;
        //    TcpListener listener = null;

        //    do
        //    {
        //        try
        //        {
        //            listener = new TcpListener(IPAddress.Loopback, port);
        //            listener.Start();
        //            listener.Stop();
        //            return port;
        //        }
        //        catch (Exception ex)
        //        {
        //            interactiveParameters.PromptAction(string.Format("Port {0} is taken with exception '{1}'; trying to connect to the next port.", port, ex.Message));
        //            listener?.Stop();
        //        }
        //    }
        //    while (++port < portEnd);

        //    throw new Exception("Cannot find an open port.");
        //}

        public override bool CanAuthenticate(AuthenticationParameters parameters)
        {
            return (parameters as InteractiveParameters) != null;
        }
    }
}
