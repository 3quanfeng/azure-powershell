---
external help file:
Module Name: Az.Network
online version: https://docs.microsoft.com/en-us/powershell/module/az.network/get-aznetworkinterfaceipconfiguration
schema: 2.0.0
---

# Get-AzNetworkInterfaceIPConfiguration

## SYNOPSIS
Gets the specified network interface ip configuration.

## SYNTAX

### List (Default)
```
Get-AzNetworkInterfaceIPConfiguration -NetworkInterfaceName <String> -ResourceGroupName <String>
 -SubscriptionId <String[]> [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### GetVmss
```
Get-AzNetworkInterfaceIPConfiguration -IPConfigurationName <String> -NetworkInterfaceName <String>
 -ResourceGroupName <String> -SubscriptionId <String[]> -VMIndex <String> -VmssName <String>
 [-ExpandResource <String>] [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### Get
```
Get-AzNetworkInterfaceIPConfiguration -IPConfigurationName <String> -NetworkInterfaceName <String>
 -ResourceGroupName <String> -SubscriptionId <String[]> [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### ListVmss
```
Get-AzNetworkInterfaceIPConfiguration -NetworkInterfaceName <String> -ResourceGroupName <String>
 -SubscriptionId <String[]> -VMIndex <String> -VmssName <String> [-ExpandResource <String>]
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### GetViaIdentity
```
Get-AzNetworkInterfaceIPConfiguration -InputObject <INetworkIdentity> [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

## DESCRIPTION
Gets the specified network interface ip configuration.

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

### -ExpandResource
Expands referenced resources.

```yaml
Type: System.String
Parameter Sets: GetVmss, ListVmss
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
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -IPConfigurationName
The name of the ip configuration name.

```yaml
Type: System.String
Parameter Sets: GetVmss, Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -NetworkInterfaceName
The name of the network interface.

```yaml
Type: System.String
Parameter Sets: List, GetVmss, Get, ListVmss
Aliases:

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
Parameter Sets: List, GetVmss, Get, ListVmss
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
Parameter Sets: List, GetVmss, Get, ListVmss
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -VMIndex
The virtual machine index.

```yaml
Type: System.String
Parameter Sets: GetVmss, ListVmss
Aliases: VirtualMachineIndex

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -VmssName
The name of the virtual machine scale set.

```yaml
Type: System.String
Parameter Sets: GetVmss, ListVmss
Aliases: VirtualMachineScaleSetName

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

### Microsoft.Azure.PowerShell.Cmdlets.Network.Models.INetworkIdentity

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20190201.INetworkInterfaceIPConfiguration

## ALIASES

### Get-AzNetworkInterfaceVirtualMachineScaleSetIPConfiguration

## RELATED LINKS

