---
external help file:
Module Name: Az.WebSite
online version: https://docs.microsoft.com/en-us/powershell/module/az.website/test-azwebsitemove
schema: 2.0.0
---

# Test-AzWebSiteMove

## SYNOPSIS
Validate whether a resource can be moved.

## SYNTAX

### Validate (Default)
```
Test-AzWebSiteMove -ResourceGroupName <String> -SubscriptionId <String>
 [-MoveResourceEnvelope <ICsmMoveResourceEnvelope>] [-PassThru] [-DefaultProfile <PSObject>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### ValidateExpanded
```
Test-AzWebSiteMove -ResourceGroupName <String> -SubscriptionId <String> [-PassThru] [-Resource <String[]>]
 [-TargetResourceGroup <String>] [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ValidateViaIdentityExpanded
```
Test-AzWebSiteMove -InputObject <IWebSiteIdentity> [-PassThru] [-Resource <String[]>]
 [-TargetResourceGroup <String>] [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ValidateViaIdentity
```
Test-AzWebSiteMove -InputObject <IWebSiteIdentity> [-MoveResourceEnvelope <ICsmMoveResourceEnvelope>]
 [-PassThru] [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Validate whether a resource can be moved.

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
Type: Microsoft.Azure.PowerShell.Cmdlets.WebSite.Models.IWebSiteIdentity
Parameter Sets: ValidateViaIdentityExpanded, ValidateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -MoveResourceEnvelope
Object with a list of the resources that need to be moved and the resource group they should be moved to.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.WebSite.Models.Api20180201.ICsmMoveResourceEnvelope
Parameter Sets: Validate, ValidateViaIdentity
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -PassThru
When specified, PassThru will force the cmdlet return a 'bool' given that there isn't a return type by default.

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
HELP MESSAGE MISSING

```yaml
Type: System.String[]
Parameter Sets: ValidateExpanded, ValidateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ResourceGroupName
Name of the resource group to which the resource belongs.

```yaml
Type: System.String
Parameter Sets: Validate, ValidateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SubscriptionId
Your Azure subscription ID.
This is a GUID-formatted string (e.g.
00000000-0000-0000-0000-000000000000).

```yaml
Type: System.String
Parameter Sets: Validate, ValidateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TargetResourceGroup
HELP MESSAGE MISSING

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

### Microsoft.Azure.PowerShell.Cmdlets.WebSite.Models.IWebSiteIdentity

### Microsoft.Azure.PowerShell.Cmdlets.WebSite.Models.Api20180201.ICsmMoveResourceEnvelope

## OUTPUTS

### System.Boolean

## ALIASES

## RELATED LINKS

