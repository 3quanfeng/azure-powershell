---
external help file:
Module Name: Az.Network
online version: https://docs.microsoft.com/en-us/powershell/module/az.network/new-aznetworksecurityrule
schema: 2.0.0
---

# New-AzNetworkSecurityRule

## SYNOPSIS
Creates or updates a security rule in the specified network security group.

## SYNTAX

### Create (Default)
```
New-AzNetworkSecurityRule -NetworkSecurityGroupName <String> -ResourceGroupName <String>
 -SubscriptionId <String> [-Name <String>] [-SecurityRuleParameter <ISecurityRule>]
 [-DefaultProfile <PSObject>] [-AsJob] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-AzNetworkSecurityRule -InputObject <INetworkIdentity> -Access <SecurityRuleAccess>
 -Direction <SecurityRuleDirection> -Protocol <SecurityRuleProtocol> [-Name <String>] [-Description <String>]
 [-DestinationAddressPrefix <String>] [-DestinationApplicationSecurityGroup <IApplicationSecurityGroup[]>]
 [-DestinationPortRange <String>] [-Etag <String>] [-Id <String>] [-Priority <Int32>]
 [-PropertiesDestinationAddressPrefixes <String[]>] [-PropertiesDestinationPortRanges <String[]>]
 [-PropertiesSourceAddressPrefixes <String[]>] [-PropertiesSourcePortRanges <String[]>]
 [-ProvisioningState <String>] [-SourceAddressPrefix <String>]
 [-SourceApplicationSecurityGroup <IApplicationSecurityGroup[]>] [-SourcePortRange <String>]
 [-DefaultProfile <PSObject>] [-AsJob] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateExpanded
```
New-AzNetworkSecurityRule -NetworkSecurityGroupName <String> -ResourceGroupName <String>
 -SubscriptionId <String> -SecurityRuleName <String> -Access <SecurityRuleAccess>
 -Direction <SecurityRuleDirection> -Protocol <SecurityRuleProtocol> [-Name <String>] [-Description <String>]
 [-DestinationAddressPrefix <String>] [-DestinationApplicationSecurityGroup <IApplicationSecurityGroup[]>]
 [-DestinationPortRange <String>] [-Etag <String>] [-Id <String>] [-Priority <Int32>]
 [-PropertiesDestinationAddressPrefixes <String[]>] [-PropertiesDestinationPortRanges <String[]>]
 [-PropertiesSourceAddressPrefixes <String[]>] [-PropertiesSourcePortRanges <String[]>]
 [-ProvisioningState <String>] [-SourceAddressPrefix <String>]
 [-SourceApplicationSecurityGroup <IApplicationSecurityGroup[]>] [-SourcePortRange <String>]
 [-DefaultProfile <PSObject>] [-AsJob] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-AzNetworkSecurityRule -InputObject <INetworkIdentity> [-SecurityRuleParameter <ISecurityRule>]
 [-DefaultProfile <PSObject>] [-AsJob] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Creates or updates a security rule in the specified network security group.

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

### -Access
The network traffic is allowed or denied.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Support.SecurityRuleAccess
Parameter Sets: CreateViaIdentityExpanded, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
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

### -Description
A description for this rule.
Restricted to 140 chars.

```yaml
Type: System.String
Parameter Sets: CreateViaIdentityExpanded, CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DestinationAddressPrefix
The destination address prefix.
CIDR or destination IP range.
Asterisk '*' can also be used to match all source IPs.
Default tags such as 'VirtualNetwork', 'AzureLoadBalancer' and 'Internet' can also be used.

```yaml
Type: System.String
Parameter Sets: CreateViaIdentityExpanded, CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DestinationApplicationSecurityGroup
The application security group specified as destination.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20171001.IApplicationSecurityGroup[]
Parameter Sets: CreateViaIdentityExpanded, CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DestinationPortRange
The destination port or range.
Integer or range between 0 and 65535.
Asterisk '*' can also be used to match all ports.

```yaml
Type: System.String
Parameter Sets: CreateViaIdentityExpanded, CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Direction
The direction of the rule.
The direction specifies if rule will be evaluated on incoming or outgoing traffic.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Support.SecurityRuleDirection
Parameter Sets: CreateViaIdentityExpanded, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Etag
A unique read-only string that changes whenever the resource is updated.

```yaml
Type: System.String
Parameter Sets: CreateViaIdentityExpanded, CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Id
Resource ID.

```yaml
Type: System.String
Parameter Sets: CreateViaIdentityExpanded, CreateExpanded
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

### -Name
The name of the security rule.

```yaml
Type: System.String
Parameter Sets: Create, CreateViaIdentityExpanded, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -NetworkSecurityGroupName
The name of the network security group.

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

### -Priority
The priority of the rule.
The value can be between 100 and 4096.
The priority number must be unique for each rule in the collection.
The lower the priority number, the higher the priority of the rule.

```yaml
Type: System.Int32
Parameter Sets: CreateViaIdentityExpanded, CreateExpanded
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PropertiesDestinationAddressPrefixes
The destination address prefixes.
CIDR or destination IP ranges.

```yaml
Type: System.String[]
Parameter Sets: CreateViaIdentityExpanded, CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PropertiesDestinationPortRanges
The destination port ranges.

```yaml
Type: System.String[]
Parameter Sets: CreateViaIdentityExpanded, CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PropertiesSourceAddressPrefixes
The CIDR or source IP ranges.

```yaml
Type: System.String[]
Parameter Sets: CreateViaIdentityExpanded, CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PropertiesSourcePortRanges
The source port ranges.

```yaml
Type: System.String[]
Parameter Sets: CreateViaIdentityExpanded, CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Protocol
Network protocol this rule applies to.
Possible values are 'Tcp', 'Udp', 'Icmp', 'Esp', and '*'.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Support.SecurityRuleProtocol
Parameter Sets: CreateViaIdentityExpanded, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ProvisioningState
The provisioning state of the public IP resource.
Possible values are: 'Updating', 'Deleting', and 'Failed'.

```yaml
Type: System.String
Parameter Sets: CreateViaIdentityExpanded, CreateExpanded
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
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SecurityRuleName
The name of the security rule.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SecurityRuleParameter
Network security rule.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20190201.ISecurityRule
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -SourceAddressPrefix
The CIDR or source IP range.
Asterisk '*' can also be used to match all source IPs.
Default tags such as 'VirtualNetwork', 'AzureLoadBalancer' and 'Internet' can also be used.
If this is an ingress rule, specifies where network traffic originates from.

```yaml
Type: System.String
Parameter Sets: CreateViaIdentityExpanded, CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SourceApplicationSecurityGroup
The application security group specified as source.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20171001.IApplicationSecurityGroup[]
Parameter Sets: CreateViaIdentityExpanded, CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SourcePortRange
The source port or range.
Integer or range between 0 and 65535.
Asterisk '*' can also be used to match all ports.

```yaml
Type: System.String
Parameter Sets: CreateViaIdentityExpanded, CreateExpanded
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

### Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20190201.ISecurityRule

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20190201.ISecurityRule

## ALIASES

## RELATED LINKS

