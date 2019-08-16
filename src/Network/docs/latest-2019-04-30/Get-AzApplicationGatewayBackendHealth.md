---
external help file:
Module Name: Az.Network
online version: https://docs.microsoft.com/en-us/powershell/module/az.network/get-azapplicationgatewaybackendhealth
schema: 2.0.0
---

# Get-AzApplicationGatewayBackendHealth

## SYNOPSIS
Gets the backend health of the specified application gateway in a resource group.

## SYNTAX

### Backend (Default)
```
Get-AzApplicationGatewayBackendHealth -Name <String> -ResourceGroupName <String> -SubscriptionId <String[]>
 [-Expand <String>] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### DemandExpanded
```
Get-AzApplicationGatewayBackendHealth -Name <String> -ResourceGroupName <String> -SubscriptionId <String[]>
 -AsOnDemand [-Expand <String>] [-BackendHttpSettingName <String>] [-BackendPoolName <String>]
 [-Host <String>] [-MatchBody <String>] [-MatchStatusCode <String[]>] [-Path <String>]
 [-PickHostNameFromBackendHttpSetting] [-Protocol <ApplicationGatewayProtocol>] [-Timeout <Int32>]
 [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### DemandViaIdentityExpanded
```
Get-AzApplicationGatewayBackendHealth -InputObject <INetworkIdentity> -AsOnDemand [-Expand <String>]
 [-BackendHttpSettingName <String>] [-BackendPoolName <String>] [-Host <String>] [-MatchBody <String>]
 [-MatchStatusCode <String[]>] [-Path <String>] [-PickHostNameFromBackendHttpSetting]
 [-Protocol <ApplicationGatewayProtocol>] [-Timeout <Int32>] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### BackendViaIdentity
```
Get-AzApplicationGatewayBackendHealth -InputObject <INetworkIdentity> [-Expand <String>]
 [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Gets the backend health of the specified application gateway in a resource group.

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

### -AsOnDemand
Gets the backend health via an on demand probe.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: DemandExpanded, DemandViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -BackendHttpSettingName
Name of backend http setting of application gateway to be used for test probe

```yaml
Type: System.String
Parameter Sets: DemandExpanded, DemandViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -BackendPoolName
Name of backend pool of application gateway to which probe request will be sent.

```yaml
Type: System.String
Parameter Sets: DemandExpanded, DemandViaIdentityExpanded
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

### -Expand
Expands BackendAddressPool and BackendHttpSettings referenced in backend health.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: ExpandResource

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Host
Host name to send the probe to.

```yaml
Type: System.String
Parameter Sets: DemandExpanded, DemandViaIdentityExpanded
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
Parameter Sets: DemandViaIdentityExpanded, BackendViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -MatchBody
Body that must be contained in the health response.
Default value is empty.

```yaml
Type: System.String
Parameter Sets: DemandExpanded, DemandViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -MatchStatusCode
Allowed ranges of healthy status codes.
Default range of healthy status codes is 200-399.

```yaml
Type: System.String[]
Parameter Sets: DemandExpanded, DemandViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Name
The name of the application gateway.

```yaml
Type: System.String
Parameter Sets: Backend, DemandExpanded
Aliases: ApplicationGatewayName

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

### -Path
Relative path of probe.
Valid path starts from '/'.
Probe is sent to \<Protocol\>://\<host\>:\<port\>\<path\>

```yaml
Type: System.String
Parameter Sets: DemandExpanded, DemandViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PickHostNameFromBackendHttpSetting
Whether the host header should be picked from the backend http settings.
Default value is false.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: DemandExpanded, DemandViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Protocol
The protocol used for the probe.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Support.ApplicationGatewayProtocol
Parameter Sets: DemandExpanded, DemandViaIdentityExpanded
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
Parameter Sets: Backend, DemandExpanded
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
Type: System.String[]
Parameter Sets: Backend, DemandExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Timeout
The probe timeout in seconds.
Probe marked as failed if valid response is not received with this timeout period.
Acceptable values are from 1 second to 86400 seconds.

```yaml
Type: System.Int32
Parameter Sets: DemandExpanded, DemandViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
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

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20190201.IApplicationGatewayBackendHealthPool

## ALIASES

## NOTES

## RELATED LINKS

