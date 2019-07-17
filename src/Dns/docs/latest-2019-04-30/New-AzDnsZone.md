---
external help file:
Module Name: Az.Dns
online version: https://docs.microsoft.com/en-us/powershell/module/az.dns/new-azdnszone
schema: 2.0.0
---

# New-AzDnsZone

## SYNOPSIS
Creates or updates a DNS zone.
Does not modify DNS records within the zone.

## SYNTAX

### Create1 (Default)
```
New-AzDnsZone -Name <String> -ResourceGroupName <String> -SubscriptionId <String> [-IfMatch <String>]
 [-IfNoneMatch <String>] [-Parameter <IZone>] [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateExpanded1
```
New-AzDnsZone -Name <String> -ResourceGroupName <String> -SubscriptionId <String> -Location <String>
 [-IfMatch <String>] [-IfNoneMatch <String>] [-Etag <String>] [-RegistrationVirtualNetwork <ISubResource[]>]
 [-ResolutionVirtualNetwork <ISubResource[]>] [-Tag <Hashtable>] [-ZoneType <ZoneType>]
 [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded1
```
New-AzDnsZone -InputObject <IDnsIdentity> -Location <String> [-IfMatch <String>] [-IfNoneMatch <String>]
 [-Etag <String>] [-RegistrationVirtualNetwork <ISubResource[]>] [-ResolutionVirtualNetwork <ISubResource[]>]
 [-Tag <Hashtable>] [-ZoneType <ZoneType>] [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateViaIdentity1
```
New-AzDnsZone -InputObject <IDnsIdentity> [-IfMatch <String>] [-IfNoneMatch <String>] [-Parameter <IZone>]
 [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Creates or updates a DNS zone.
Does not modify DNS records within the zone.

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

### -Etag
The etag of the zone.

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

### -IfMatch
The etag of the DNS zone.
Omit this value to always overwrite the current zone.
Specify the last-seen etag value to prevent accidentally overwriting any concurrent changes.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -IfNoneMatch
Set to '*' to allow a new DNS zone to be created, but to prevent updating an existing zone.
Other values will be ignored.

```yaml
Type: System.String
Parameter Sets: (All)
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
Type: Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.IDnsIdentity
Parameter Sets: CreateViaIdentityExpanded1, CreateViaIdentity1
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
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Name
The name of the DNS zone (without a terminating dot).

```yaml
Type: System.String
Parameter Sets: Create1, CreateExpanded1
Aliases: ZoneName

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Parameter
Describes a DNS zone.
To construct, see NOTES section for PARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20180501.IZone
Parameter Sets: Create1, CreateViaIdentity1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -RegistrationVirtualNetwork
A list of references to virtual networks that register hostnames in this DNS zone.
This is a only when ZoneType is Private.
To construct, see NOTES section for REGISTRATIONVIRTUALNETWORK properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20180301Preview.ISubResource[]
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ResolutionVirtualNetwork
A list of references to virtual networks that resolve records in this DNS zone.
This is a only when ZoneType is Private.
To construct, see NOTES section for RESOLUTIONVIRTUALNETWORK properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20180301Preview.ISubResource[]
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

### -SubscriptionId
Specifies the Azure subscription ID, which uniquely identifies the Microsoft Azure subscription.

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
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ZoneType
The type of this DNS zone (Public or Private).

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Dns.Support.ZoneType
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

### Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.IDnsIdentity

### Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20180501.IZone

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20180501.IZone

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### PARAMETER <IZone>: Describes a DNS zone.
  - `Location <String>`: Resource location.
  - `[Tag <IResourceTags>]`: Resource tags.
    - `[(Any) <String>]`: This indicates any property can be added to this object.
  - `[Etag <String>]`: The etag of the zone.
  - `[RegistrationVirtualNetwork <ISubResource[]>]`: A list of references to virtual networks that register hostnames in this DNS zone. This is a only when ZoneType is Private.
    - `[Id <String>]`: Resource Id.
  - `[ResolutionVirtualNetwork <ISubResource[]>]`: A list of references to virtual networks that resolve records in this DNS zone. This is a only when ZoneType is Private.
  - `[ZoneType <ZoneType?>]`: The type of this DNS zone (Public or Private).

#### REGISTRATIONVIRTUALNETWORK <ISubResource[]>: A list of references to virtual networks that register hostnames in this DNS zone. This is a only when ZoneType is Private.
  - `[Id <String>]`: Resource Id.

#### RESOLUTIONVIRTUALNETWORK <ISubResource[]>: A list of references to virtual networks that resolve records in this DNS zone. This is a only when ZoneType is Private.
  - `[Id <String>]`: Resource Id.

## RELATED LINKS

