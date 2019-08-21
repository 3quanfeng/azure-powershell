---
external help file:
Module Name: Az.Resources
online version: https://docs.microsoft.com/en-us/powershell/module/az.resources/get-azroleassignment
schema: 2.0.0
---

# Get-AzRoleAssignment

## SYNOPSIS
Gets a role assignment by ID.

## SYNTAX

### Get1 (Default)
```
Get-AzRoleAssignment -Id <String> [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### Get2
```
Get-AzRoleAssignment -Name <String> -Scope <String> [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### Get3
```
Get-AzRoleAssignment -RoleId <String> [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### GetViaIdentity1
```
Get-AzRoleAssignment -InputObject <IResourcesIdentity> [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### GetViaIdentity2
```
Get-AzRoleAssignment -InputObject <IResourcesIdentity> [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### GetViaIdentity3
```
Get-AzRoleAssignment -InputObject <IResourcesIdentity> [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### List4
```
Get-AzRoleAssignment -ParentResourceId <String> -ResourceGroupName <String> -ResourceName <String>
 -ResourceProviderNamespace <String> -ResourceType <String> -SubscriptionId <String[]> [-Filter <String>]
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### List5
```
Get-AzRoleAssignment -ResourceGroupName <String> -SubscriptionId <String[]> [-Filter <String>]
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### List6
```
Get-AzRoleAssignment -SubscriptionId <String[]> [-Filter <String>] [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

### List7
```
Get-AzRoleAssignment -Scope <String> [-Filter <String>] [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### ListByComponentsExpandPrincipalGroups
```
Get-AzRoleAssignment -ParentResourceId <String> -ResourceGroupName <String> -ResourceName <String>
 -ResourceProviderNamespace <String> -ResourceType <String> -SubscriptionId <String[]>
 -ExpandPrincipalGroups <String> [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### ListByComponentsFilterBySignInName
```
Get-AzRoleAssignment -ParentResourceId <String> -ResourceGroupName <String> -ResourceName <String>
 -ResourceProviderNamespace <String> -ResourceType <String> -SubscriptionId <String[]> -SignInName <String>
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### ListByComponentsFilterBySPN
```
Get-AzRoleAssignment -ParentResourceId <String> -ResourceGroupName <String> -ResourceName <String>
 -ResourceProviderNamespace <String> -ResourceType <String> -SubscriptionId <String[]>
 -ServicePrincipalName <String> [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### ListByResourceGroupExpandPrincipalGroups
```
Get-AzRoleAssignment -ResourceGroupName <String> -SubscriptionId <String[]> -ExpandPrincipalGroups <String>
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### ListByResourceGroupFilterBySignInName
```
Get-AzRoleAssignment -ResourceGroupName <String> -SubscriptionId <String[]> -SignInName <String>
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### ListByResourceGroupFilterBySPN
```
Get-AzRoleAssignment -ResourceGroupName <String> -SubscriptionId <String[]> -ServicePrincipalName <String>
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### ListByScopeExpandPrincipalGroups
```
Get-AzRoleAssignment -Scope <String> -ExpandPrincipalGroups <String> [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

### ListByScopeFilterBySignInName
```
Get-AzRoleAssignment -Scope <String> -SignInName <String> [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### ListByScopeFilterBySPN
```
Get-AzRoleAssignment -Scope <String> -ServicePrincipalName <String> [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

### ListBySubscriptionExpandPrincipalGroups
```
Get-AzRoleAssignment -SubscriptionId <String[]> -ExpandPrincipalGroups <String> [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

### ListBySubscriptionFilterBySignInName
```
Get-AzRoleAssignment -SubscriptionId <String[]> -SignInName <String> [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

### ListBySubscriptionFilterBySPN
```
Get-AzRoleAssignment -SubscriptionId <String[]> -ServicePrincipalName <String> [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

## DESCRIPTION
Gets a role assignment by ID.

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

### -ExpandPrincipalGroups
Signals that the role assignments returned should be directly assigned to the principal as well as assignments to the principals groups (transitive).

```yaml
Type: System.String
Parameter Sets: ListByComponentsExpandPrincipalGroups, ListByResourceGroupExpandPrincipalGroups, ListByScopeExpandPrincipalGroups, ListBySubscriptionExpandPrincipalGroups
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Filter
The filter to apply on the operation.
Use $filter=atScope() to return all role assignments at or above the scope.
Use $filter=principalId eq {id} to return all role assignments at, above or below the scope for the specified principal.

```yaml
Type: System.String
Parameter Sets: List4, List5, List6, List7
Aliases: ODataQuery

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Id
The ID of the role assignment to get.

```yaml
Type: System.String
Parameter Sets: Get1
Aliases: RoleAssignmentId

Required: True
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
Parameter Sets: GetViaIdentity1, GetViaIdentity2, GetViaIdentity3
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Name
The name of the role assignment to get.

```yaml
Type: System.String
Parameter Sets: Get2
Aliases: RoleAssignmentName

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ParentResourceId
The parent resource identity.

```yaml
Type: System.String
Parameter Sets: List4, ListByComponentsExpandPrincipalGroups, ListByComponentsFilterBySignInName, ListByComponentsFilterBySPN
Aliases: ParentResourcePath

Required: True
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
Parameter Sets: List4, List5, ListByComponentsExpandPrincipalGroups, ListByComponentsFilterBySignInName, ListByComponentsFilterBySPN, ListByResourceGroupExpandPrincipalGroups, ListByResourceGroupFilterBySignInName, ListByResourceGroupFilterBySPN
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ResourceName
The name of the resource to get role assignments for.

```yaml
Type: System.String
Parameter Sets: List4, ListByComponentsExpandPrincipalGroups, ListByComponentsFilterBySignInName, ListByComponentsFilterBySPN
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ResourceProviderNamespace
The namespace of the resource provider.

```yaml
Type: System.String
Parameter Sets: List4, ListByComponentsExpandPrincipalGroups, ListByComponentsFilterBySignInName, ListByComponentsFilterBySPN
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ResourceType
The resource type of the resource.

```yaml
Type: System.String
Parameter Sets: List4, ListByComponentsExpandPrincipalGroups, ListByComponentsFilterBySignInName, ListByComponentsFilterBySPN
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -RoleId
The ID of the role assignment to get.

```yaml
Type: System.String
Parameter Sets: Get3
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Scope
The scope of the role assignment.

```yaml
Type: System.String
Parameter Sets: Get2, List7, ListByScopeExpandPrincipalGroups, ListByScopeFilterBySignInName, ListByScopeFilterBySPN
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ServicePrincipalName
The service principal name (SPN) of the application.

```yaml
Type: System.String
Parameter Sets: ListByComponentsFilterBySPN, ListByResourceGroupFilterBySPN, ListByScopeFilterBySPN, ListBySubscriptionFilterBySPN
Aliases: SPN

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SignInName
The sign in name of the user.

```yaml
Type: System.String
Parameter Sets: ListByComponentsFilterBySignInName, ListByResourceGroupFilterBySignInName, ListByScopeFilterBySignInName, ListBySubscriptionFilterBySignInName
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
Type: System.String[]
Parameter Sets: List4, List5, List6, ListByComponentsExpandPrincipalGroups, ListByComponentsFilterBySignInName, ListByComponentsFilterBySPN, ListByResourceGroupExpandPrincipalGroups, ListByResourceGroupFilterBySignInName, ListByResourceGroupFilterBySPN, ListBySubscriptionExpandPrincipalGroups, ListBySubscriptionFilterBySignInName, ListBySubscriptionFilterBySPN
Aliases:

Required: True
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

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Resources.Models.Api20171001Preview.IRoleAssignment

### Microsoft.Azure.PowerShell.Cmdlets.Resources.Models.Api20180901Preview.IRoleAssignment

## ALIASES

## NOTES

## RELATED LINKS

