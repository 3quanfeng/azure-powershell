---
external help file:
Module Name: Az.Resources
online version: https://docs.microsoft.com/en-us/powershell/module/az.resources/test-azresourcemove
schema: 2.0.0
---

# Test-AzResourceMove

## SYNOPSIS
This operation checks whether the specified resources can be moved to the target.
The resources to move must be in the same source resource group.
The target resource group may be in a different subscription.
If validation succeeds, it returns HTTP response code 204 (no content).
If validation fails, it returns HTTP response code 409 (Conflict) with an error message.
Retrieve the URL in the Location header value to check the result of the long-running operation.

## SYNTAX

### ValidateExpanded (Default)
```
Test-AzResourceMove -SourceResourceGroupName <String> -SubscriptionId <String> [-PassThru]
 [-Resource <String[]>] [-TargetResourceGroup <String>] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ValidateByComponents
```
Test-AzResourceMove -SourceResourceGroupName <String> -SubscriptionId <String>
 -TargetResourceGroupName <String> [-PassThru] [-Resource <String[]>] [-TargetSubscriptionId <String>]
 [-DefaultProfile <PSObject>] [-AsJob] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Validate
```
Test-AzResourceMove -SourceResourceGroupName <String> -SubscriptionId <String> -Parameter <IResourcesMoveInfo>
 [-PassThru] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ValidateViaIdentityExpanded
```
Test-AzResourceMove -InputObject <IResourcesIdentity> [-PassThru] [-Resource <String[]>]
 [-TargetResourceGroup <String>] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### ValidateViaIdentity
```
Test-AzResourceMove -InputObject <IResourcesIdentity> -Parameter <IResourcesMoveInfo> [-PassThru]
 [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This operation checks whether the specified resources can be moved to the target.
The resources to move must be in the same source resource group.
The target resource group may be in a different subscription.
If validation succeeds, it returns HTTP response code 204 (no content).
If validation fails, it returns HTTP response code 409 (Conflict) with an error message.
Retrieve the URL in the Location header value to check the result of the long-running operation.

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
Type: Microsoft.Azure.PowerShell.Cmdlets.Resources.Models.IResourcesIdentity
Parameter Sets: ValidateViaIdentityExpanded, ValidateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -NoWait
Run the command asynchronously

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: ValidateExpanded, Validate, ValidateViaIdentityExpanded, ValidateViaIdentity
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Parameter
Parameters of move resources.
To construct, see NOTES section for PARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Resources.Models.Api20180501.IResourcesMoveInfo
Parameter Sets: Validate, ValidateViaIdentity
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

### -Resource
The IDs of the resources.

```yaml
Type: System.String[]
Parameter Sets: ValidateExpanded, ValidateByComponents, ValidateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SourceResourceGroupName
The name of the resource group containing the resources to validate for move.

```yaml
Type: System.String
Parameter Sets: ValidateExpanded, ValidateByComponents, Validate
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SubscriptionId
The ID of the target subscription.

```yaml
Type: System.String
Parameter Sets: ValidateExpanded, ValidateByComponents, Validate
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TargetResourceGroup
The target resource group.

```yaml
Type: System.String
Parameter Sets: ValidateExpanded, ValidateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TargetResourceGroupName
The target resource group name.

```yaml
Type: System.String
Parameter Sets: ValidateByComponents
Aliases: DestinationResourceGroupName

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TargetSubscriptionId
The target subscription id.
If not value is provided, the subscription id of the current context will be used.

```yaml
Type: System.String
Parameter Sets: ValidateByComponents
Aliases: DestinationSubscriptionId

Required: False
Position: Named
Default value: None
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

### Microsoft.Azure.PowerShell.Cmdlets.Resources.Models.IResourcesIdentity

### Microsoft.Azure.PowerShell.Cmdlets.Resources.Models.Api20180501.IResourcesMoveInfo

## OUTPUTS

### System.Boolean

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### PARAMETER <IResourcesMoveInfo>: Parameters of move resources.
  - `[Resource <String[]>]`: The IDs of the resources.
  - `[TargetResourceGroup <String>]`: The target resource group.

## RELATED LINKS

