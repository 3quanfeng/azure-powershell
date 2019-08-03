---
external help file:
Module Name: Az.Network
online version: https://docs.microsoft.com/en-us/powershell/module/az.network/new-azvnetgatewayvpnclientpackage
schema: 2.0.0
---

# New-AzVnetGatewayVpnClientPackage

## SYNOPSIS
Generates VPN client package for P2S client of the virtual network gateway in the specified resource group.

## SYNTAX

### GeneratevpnclientpackageExpanded (Default)
```
New-AzVnetGatewayVpnClientPackage -ResourceGroupName <String> -SubscriptionId <String>
 -VnetGatewayName <String> [-AuthenticationMethod <AuthenticationMethod>] [-ClientRootCertificate <String[]>]
 [-ProcessorArchitecture <ProcessorArchitecture>] [-RadiusServerAuthenticationCertificate <String>]
 [-DefaultProfile <PSObject>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Generatevpnclientpackage
```
New-AzVnetGatewayVpnClientPackage -ResourceGroupName <String> -SubscriptionId <String>
 -VnetGatewayName <String> -VpnClientPackage <IVpnClientParameters> [-DefaultProfile <PSObject>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### GeneratevpnclientpackageViaIdentityExpanded
```
New-AzVnetGatewayVpnClientPackage -InputObject <INetworkIdentity>
 [-AuthenticationMethod <AuthenticationMethod>] [-ClientRootCertificate <String[]>]
 [-ProcessorArchitecture <ProcessorArchitecture>] [-RadiusServerAuthenticationCertificate <String>]
 [-DefaultProfile <PSObject>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### GeneratevpnclientpackageViaIdentity
```
New-AzVnetGatewayVpnClientPackage -InputObject <INetworkIdentity> -VpnClientPackage <IVpnClientParameters>
 [-DefaultProfile <PSObject>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Generates VPN client package for P2S client of the virtual network gateway in the specified resource group.

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

### -AuthenticationMethod
VPN client authentication method.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Support.AuthenticationMethod
Parameter Sets: GeneratevpnclientpackageExpanded, GeneratevpnclientpackageViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ClientRootCertificate
A list of client root certificates public certificate data encoded as Base-64 strings.
Optional parameter for external radius based authentication with EAPTLS.

```yaml
Type: System.String[]
Parameter Sets: GeneratevpnclientpackageExpanded, GeneratevpnclientpackageViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
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

### -InputObject
Identity Parameter

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Models.INetworkIdentity
Parameter Sets: GeneratevpnclientpackageViaIdentityExpanded, GeneratevpnclientpackageViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -PassThru
Returns true when the command succeeds

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

### -ProcessorArchitecture
VPN client Processor Architecture.
Possible values are: 'AMD64' and 'X86'.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Support.ProcessorArchitecture
Parameter Sets: GeneratevpnclientpackageExpanded, GeneratevpnclientpackageViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -RadiusServerAuthenticationCertificate
The public certificate data for the radius server authentication certificate as a Base-64 encoded string.
Required only if external radius authentication has been configured with EAPTLS authentication.

```yaml
Type: System.String
Parameter Sets: GeneratevpnclientpackageExpanded, GeneratevpnclientpackageViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ResourceGroupName
The name of the resource group.

```yaml
Type: System.String
Parameter Sets: GeneratevpnclientpackageExpanded, Generatevpnclientpackage
Aliases:

Required: True
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
Parameter Sets: GeneratevpnclientpackageExpanded, Generatevpnclientpackage
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -VnetGatewayName
The name of the virtual network gateway.

```yaml
Type: System.String
Parameter Sets: GeneratevpnclientpackageExpanded, Generatevpnclientpackage
Aliases: VirtualNetworkGatewayName

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -VpnClientPackage
Vpn Client Parameters for package generation
To construct, see NOTES section for VPNCLIENTPACKAGE properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20171001.IVpnClientParameters
Parameter Sets: Generatevpnclientpackage, GeneratevpnclientpackageViaIdentity
Aliases:

Required: True
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

### Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20171001.IVpnClientParameters

## OUTPUTS

### System.String

## ALIASES

### Get-AzVpnClientPackage

### New-AzVirtualNetworkGatewayVpnClientPackage

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### VPNCLIENTPACKAGE <IVpnClientParameters>: Vpn Client Parameters for package generation
  - `[AuthenticationMethod <AuthenticationMethod?>]`: VPN client authentication method.
  - `[ClientRootCertificate <String[]>]`: A list of client root certificates public certificate data encoded as Base-64 strings. Optional parameter for external radius based authentication with EAPTLS.
  - `[ProcessorArchitecture <ProcessorArchitecture?>]`: VPN client Processor Architecture. Possible values are: 'AMD64' and 'X86'.
  - `[RadiusServerAuthCertificate <String>]`: The public certificate data for the radius server authentication certificate as a Base-64 encoded string. Required only if external radius authentication has been configured with EAPTLS authentication.

## RELATED LINKS

