---
external help file:
Module Name: Az.Network
online version: https://docs.microsoft.com/en-us/powershell/module/az.network/new-azloadbalancer
schema: 2.0.0
---

# New-AzLoadBalancer

## SYNOPSIS
Creates or updates a load balancer.

## SYNTAX

### Create1 (Default)
```
New-AzLoadBalancer -Name <String> -ResourceGroupName <String> -SubscriptionId <String>
 [-Parameter <ILoadBalancer>] [-DefaultProfile <PSObject>] [-AsJob] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateExpanded1
```
New-AzLoadBalancer -Name <String> -ResourceGroupName <String> -SubscriptionId <String>
 [-BackendAddressPool <IBackendAddressPool[]>] [-Etag <String>]
 [-FrontendIPConfiguration <IFrontendIPConfiguration[]>] [-Id <String>] [-InboundNatPool <IInboundNatPool[]>]
 [-InboundNatRule <IInboundNatRule[]>] [-LoadBalancingRule <ILoadBalancingRule[]>] [-Location <String>]
 [-OutboundNatRule <IOutboundNatRule[]>] [-Probe <IProbe[]>] [-ProvisioningState <String>]
 [-ResourceGuid <String>] [-SkuName <LoadBalancerSkuName>] [-Tag <IResourceTags>] [-DefaultProfile <PSObject>]
 [-AsJob] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded1
```
New-AzLoadBalancer -InputObject <INetworkIdentity> [-BackendAddressPool <IBackendAddressPool[]>]
 [-Etag <String>] [-FrontendIPConfiguration <IFrontendIPConfiguration[]>] [-Id <String>]
 [-InboundNatPool <IInboundNatPool[]>] [-InboundNatRule <IInboundNatRule[]>]
 [-LoadBalancingRule <ILoadBalancingRule[]>] [-Location <String>] [-OutboundNatRule <IOutboundNatRule[]>]
 [-Probe <IProbe[]>] [-ProvisioningState <String>] [-ResourceGuid <String>] [-SkuName <LoadBalancerSkuName>]
 [-Tag <IResourceTags>] [-DefaultProfile <PSObject>] [-AsJob] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity1
```
New-AzLoadBalancer -InputObject <INetworkIdentity> [-Parameter <ILoadBalancer>] [-DefaultProfile <PSObject>]
 [-AsJob] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Creates or updates a load balancer.

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

### -BackendAddressPool
Collection of backend address pools used by a load balancer

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20171001.IBackendAddressPool[]
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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

### -Etag
A unique read-only string that changes whenever the resource is updated.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -FrontendIPConfiguration
Object representing the frontend IPs to be used for the load balancer

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20171001.IFrontendIPConfiguration[]
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -InboundNatPool
Defines an external port range for inbound NAT to a single backend port on NICs associated with a load balancer.
Inbound NAT rules are created automatically for each NIC associated with the Load Balancer using an external port from this range.
Defining an Inbound NAT pool on your Load Balancer is mutually exclusive with defining inbound Nat rules.
Inbound NAT pools are referenced from virtual machine scale sets.
NICs that are associated with individual virtual machines cannot reference an inbound NAT pool.
They have to reference individual inbound NAT rules.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20171001.IInboundNatPool[]
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -InboundNatRule
Collection of inbound NAT Rules used by a load balancer.
Defining inbound NAT rules on your load balancer is mutually exclusive with defining an inbound NAT pool.
Inbound NAT pools are referenced from virtual machine scale sets.
NICs that are associated with individual virtual machines cannot reference an Inbound NAT pool.
They have to reference individual inbound NAT rules.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20171001.IInboundNatRule[]
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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
Parameter Sets: CreateViaIdentityExpanded1, CreateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -LoadBalancingRule
Object collection representing the load balancing rules Gets the provisioning

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20171001.ILoadBalancingRule[]
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Location
Resource location.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Name
The name of the load balancer.

```yaml
Type: System.String
Parameter Sets: Create1, CreateExpanded1
Aliases: LoadBalancerName

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -OutboundNatRule
The outbound NAT rules.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20171001.IOutboundNatRule[]
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Parameter
LoadBalancer resource

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20171001.ILoadBalancer
Parameter Sets: Create1, CreateViaIdentity1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Probe
Collection of probe objects used in the load balancer

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20171001.IProbe[]
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ProvisioningState
Gets the provisioning state of the PublicIP resource.
Possible values are: 'Updating', 'Deleting', and 'Failed'.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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
Parameter Sets: Create1, CreateExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ResourceGuid
The resource GUID property of the load balancer resource.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SkuName
Name of a load balancer SKU.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Support.LoadBalancerSkuName
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases: Sku

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
Parameter Sets: Create1, CreateExpanded1
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
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20171001.IResourceTags
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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

### Microsoft.Azure.PowerShell.Cmdlets.Network.Models.INetworkIdentity

### Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20171001.ILoadBalancer

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20171001.ILoadBalancer

## ALIASES

## RELATED LINKS

