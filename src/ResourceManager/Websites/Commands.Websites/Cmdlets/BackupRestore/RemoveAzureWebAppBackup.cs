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

using Microsoft.Azure.Management.WebSites.Models;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.WebApps.Cmdlets.WebApps
{
    /// <summary>
    /// Deletes an Azure Web App backup
    /// </summary>
    [Cmdlet("Remove", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "WebAppBackup"), OutputType(typeof(BackupItem))]
    public class RemoveAzureWebAppBackup : WebAppOptionalSlotBaseCmdlet
    {
        [Parameter(Position = 3, Mandatory = true, HelpMessage = "The id of the backup.", ValueFromPipelineByPropertyName = true)]
        [ValidateNotNullOrEmpty]
        public string BackupId { get; set; }

        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();
            var backup = WebsitesClient.DeleteBackup(ResourceGroupName, Name, Slot, BackupId);
            WriteObject(BackupRestoreUtils.BackupItemToAppBackup(backup, ResourceGroupName, Name, Slot));
        }
    }
}
