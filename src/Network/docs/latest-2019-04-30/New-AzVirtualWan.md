---
external help file:
Module Name: Az.Network
online version: https://docs.microsoft.com/en-us/powershell/module/az.network/new-azvirtualwan
schema: 2.0.0
---

# New-AzVirtualWan

## SYNOPSIS
Creates a VirtualWAN resource if it doesn't exist else updates the existing VirtualWAN.

## SYNTAX

### Create (Default)
```
New-AzVirtualWan -Name <String> -ResourceGroupName <String> -SubscriptionId <String>
 [-VirtualWan <IVirtualWan>] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateExpanded
```
New-AzVirtualWan -Name <String> -ResourceGroupName <String> -SubscriptionId <String>
 [-AllowBranchToBranchTraffic] [-AllowVnetToVnetTraffic] [-DisableVpnEncryption] [-Id <String>]
 [-Location <String>] [-P2SVpnServerConfiguration <IP2SVpnServerConfiguration[]>]
 [-SecurityProviderName <String>] [-Tag <Hashtable>] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-AzVirtualWan -InputObject <INetworkIdentity> [-AllowBranchToBranchTraffic] [-AllowVnetToVnetTraffic]
 [-DisableVpnEncryption] [-Id <String>] [-Location <String>]
 [-P2SVpnServerConfiguration <IP2SVpnServerConfiguration[]>] [-SecurityProviderName <String>]
 [-Tag <Hashtable>] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-AzVirtualWan -InputObject <INetworkIdentity> [-VirtualWan <IVirtualWan>] [-DefaultProfile <PSObject>]
 [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Creates a VirtualWAN resource if it doesn't exist else updates the existing VirtualWAN.

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -AllowBranchToBranchTraffic
True if branch to branch traffic is allowed.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -AllowVnetToVnetTraffic
True if Vnet to Vnet traffic is allowed.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -AsJob
Run the command as a job

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DisableVpnEncryption
Vpn encryption to be disabled or not.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Id
Resource ID.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -InputObject
Identity Parameter

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Models.INetworkIdentity
Parameter Sets: CreateViaIdentityExpanded, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Location
Resource location.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Name
The name of the VirtualWAN being created or updated.

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases: VirtualWanName

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -NoWait
Run the command asynchronously

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -P2SVpnServerConfiguration
List of all P2SVpnServerConfigurations associated with the virtual wan.
To construct, see NOTES section for P2SVPNSERVERCONFIGURATION properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20190201.IP2SVpnServerConfiguration[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ResourceGroupName
The resource group name of the VirtualWan.

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SecurityProviderName
The Security Provider name.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SubscriptionId
The subscription credentials which uniquely identify the Microsoft Azure subscription.
The subscription ID forms part of the URI for every service call.

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Tag
Resource tags.

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -VirtualWan
VirtualWAN Resource.
To construct, see NOTES section for VIRTUALWAN properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20190201.IVirtualWan
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Network.Models.INetworkIdentity

### Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20190201.IVirtualWan

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20190201.IVirtualWan

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### P2SVPNSERVERCONFIGURATION <IP2SVpnServerConfiguration[]>: List of all P2SVpnServerConfigurations associated with the virtual wan.
  - `[Id <String>]`: Resource ID.
  - `[Name <String>]`: The name of the resource that is unique within a resource group. This name can be used to access the resource.
  - `[P2SVpnServerConfigRadiusClientRootCertificate <IP2SVpnServerConfigRadiusClientRootCertificate[]>]`: Radius client root certificate of P2SVpnServerConfiguration.
    - `[Id <String>]`: Resource ID.
    - `[Etag <String>]`: A unique read-only string that changes whenever the resource is updated.
    - `[Name <String>]`: The name of the resource that is unique within a resource group. This name can be used to access the resource.
    - `[Thumbprint <String>]`: The Radius client root certificate thumbprint.
  - `[P2SVpnServerConfigRadiusServerRootCertificate <IP2SVpnServerConfigRadiusServerRootCertificate[]>]`: Radius Server root certificate of P2SVpnServerConfiguration.
    - `PublicCertData <String>`: The certificate public data.
    - `[Id <String>]`: Resource ID.
    - `[Etag <String>]`: A unique read-only string that changes whenever the resource is updated.
    - `[Name <String>]`: The name of the resource that is unique within a resource group. This name can be used to access the resource.
  - `[P2SVpnServerConfigVpnClientRevokedCertificate <IP2SVpnServerConfigVpnClientRevokedCertificate[]>]`: VPN client revoked certificate of P2SVpnServerConfiguration.
    - `[Id <String>]`: Resource ID.
    - `[Etag <String>]`: A unique read-only string that changes whenever the resource is updated.
    - `[Name <String>]`: The name of the resource that is unique within a resource group. This name can be used to access the resource.
    - `[Thumbprint <String>]`: The revoked VPN client certificate thumbprint.
  - `[P2SVpnServerConfigVpnClientRootCertificate <IP2SVpnServerConfigVpnClientRootCertificate[]>]`: VPN client root certificate of P2SVpnServerConfiguration.
    - `PublicCertData <String>`: The certificate public data.
    - `[Id <String>]`: Resource ID.
    - `[Etag <String>]`: A unique read-only string that changes whenever the resource is updated.
    - `[Name <String>]`: The name of the resource that is unique within a resource group. This name can be used to access the resource.
  - `[PropertiesEtag <String>]`: A unique read-only string that changes whenever the resource is updated.
  - `[PropertiesName <String>]`: The name of the P2SVpnServerConfiguration that is unique within a VirtualWan in a resource group. This name can be used to access the resource along with Paren VirtualWan resource name.
  - `[RadiusServerAddress <String>]`: The radius server address property of the P2SVpnServerConfiguration resource for point to site client connection.
  - `[RadiusServerSecret <String>]`: The radius secret property of the P2SVpnServerConfiguration resource for point to site client connection.
  - `[VpnClientIpsecPolicy <IIpsecPolicy[]>]`: VpnClientIpsecPolicies for P2SVpnServerConfiguration.
    - `DhGroup <DhGroup>`: The DH Group used in IKE Phase 1 for initial SA.
    - `IkeEncryption <IkeEncryption>`: The IKE encryption algorithm (IKE phase 2).
    - `IkeIntegrity <IkeIntegrity>`: The IKE integrity algorithm (IKE phase 2).
    - `IpsecEncryption <IpsecEncryption>`: The IPSec encryption algorithm (IKE phase 1).
    - `IpsecIntegrity <IpsecIntegrity>`: The IPSec integrity algorithm (IKE phase 1).
    - `PfsGroup <PfsGroup>`: The Pfs Group used in IKE Phase 2 for new child SA.
    - `SaDataSizeKilobyte <Int32>`: The IPSec Security Association (also called Quick Mode or Phase 2 SA) payload size in KB for a site to site VPN tunnel.
    - `SaLifeTimeSecond <Int32>`: The IPSec Security Association (also called Quick Mode or Phase 2 SA) lifetime in seconds for a site to site VPN tunnel.
  - `[VpnProtocol <VpnGatewayTunnelingProtocol[]>]`: VPN protocols for the P2SVpnServerConfiguration.

#### VIRTUALWAN <IVirtualWan>: VirtualWAN Resource.
  - `[Id <String>]`: Resource ID.
  - `[Location <String>]`: Resource location.
  - `[Tag <IResourceTags>]`: Resource tags.
    - `[(Any) <String>]`: This indicates any property can be added to this object.
  - `[AllowBranchToBranchTraffic <Boolean?>]`: True if branch to branch traffic is allowed.
  - `[AllowVnetToVnetTraffic <Boolean?>]`: True if Vnet to Vnet traffic is allowed.
  - `[DisableVpnEncryption <Boolean?>]`: Vpn encryption to be disabled or not.
  - `[P2SVpnServerConfiguration <IP2SVpnServerConfiguration[]>]`: List of all P2SVpnServerConfigurations associated with the virtual wan.
    - `[Id <String>]`: Resource ID.
    - `[Name <String>]`: The name of the resource that is unique within a resource group. This name can be used to access the resource.
    - `[P2SVpnServerConfigRadiusClientRootCertificate <IP2SVpnServerConfigRadiusClientRootCertificate[]>]`: Radius client root certificate of P2SVpnServerConfiguration.
      - `[Id <String>]`: Resource ID.
      - `[Etag <String>]`: A unique read-only string that changes whenever the resource is updated.
      - `[Name <String>]`: The name of the resource that is unique within a resource group. This name can be used to access the resource.
      - `[Thumbprint <String>]`: The Radius client root certificate thumbprint.
    - `[P2SVpnServerConfigRadiusServerRootCertificate <IP2SVpnServerConfigRadiusServerRootCertificate[]>]`: Radius Server root certificate of P2SVpnServerConfiguration.
      - `PublicCertData <String>`: The certificate public data.
      - `[Id <String>]`: Resource ID.
      - `[Etag <String>]`: A unique read-only string that changes whenever the resource is updated.
      - `[Name <String>]`: The name of the resource that is unique within a resource group. This name can be used to access the resource.
    - `[P2SVpnServerConfigVpnClientRevokedCertificate <IP2SVpnServerConfigVpnClientRevokedCertificate[]>]`: VPN client revoked certificate of P2SVpnServerConfiguration.
      - `[Id <String>]`: Resource ID.
      - `[Etag <String>]`: A unique read-only string that changes whenever the resource is updated.
      - `[Name <String>]`: The name of the resource that is unique within a resource group. This name can be used to access the resource.
      - `[Thumbprint <String>]`: The revoked VPN client certificate thumbprint.
    - `[P2SVpnServerConfigVpnClientRootCertificate <IP2SVpnServerConfigVpnClientRootCertificate[]>]`: VPN client root certificate of P2SVpnServerConfiguration.
      - `PublicCertData <String>`: The certificate public data.
      - `[Id <String>]`: Resource ID.
      - `[Etag <String>]`: A unique read-only string that changes whenever the resource is updated.
      - `[Name <String>]`: The name of the resource that is unique within a resource group. This name can be used to access the resource.
    - `[PropertiesEtag <String>]`: A unique read-only string that changes whenever the resource is updated.
    - `[PropertiesName <String>]`: The name of the P2SVpnServerConfiguration that is unique within a VirtualWan in a resource group. This name can be used to access the resource along with Paren VirtualWan resource name.
    - `[RadiusServerAddress <String>]`: The radius server address property of the P2SVpnServerConfiguration resource for point to site client connection.
    - `[RadiusServerSecret <String>]`: The radius secret property of the P2SVpnServerConfiguration resource for point to site client connection.
    - `[VpnClientIpsecPolicy <IIpsecPolicy[]>]`: VpnClientIpsecPolicies for P2SVpnServerConfiguration.
      - `DhGroup <DhGroup>`: The DH Group used in IKE Phase 1 for initial SA.
      - `IkeEncryption <IkeEncryption>`: The IKE encryption algorithm (IKE phase 2).
      - `IkeIntegrity <IkeIntegrity>`: The IKE integrity algorithm (IKE phase 2).
      - `IpsecEncryption <IpsecEncryption>`: The IPSec encryption algorithm (IKE phase 1).
      - `IpsecIntegrity <IpsecIntegrity>`: The IPSec integrity algorithm (IKE phase 1).
      - `PfsGroup <PfsGroup>`: The Pfs Group used in IKE Phase 2 for new child SA.
      - `SaDataSizeKilobyte <Int32>`: The IPSec Security Association (also called Quick Mode or Phase 2 SA) payload size in KB for a site to site VPN tunnel.
      - `SaLifeTimeSecond <Int32>`: The IPSec Security Association (also called Quick Mode or Phase 2 SA) lifetime in seconds for a site to site VPN tunnel.
    - `[VpnProtocol <VpnGatewayTunnelingProtocol[]>]`: VPN protocols for the P2SVpnServerConfiguration.
  - `[SecurityProviderName <String>]`: The Security Provider name.

## RELATED LINKS

