---
external help file:
Module Name: Az.WebSite
online version: https://docs.microsoft.com/en-us/powershell/module/az.website/restore-azwebappfrombackupblobslot
schema: 2.0.0
---

# Restore-AzWebAppFromBackupBlobSlot

## SYNOPSIS
Restores an app from a backup blob in Azure Storage.

## SYNTAX

### Restore (Default)
```
Restore-AzWebAppFromBackupBlobSlot -Name <String> -ResourceGroupName <String> -Slot <String>
 -SubscriptionId <String> [-PassThru] [-Request <IRestoreRequest>] [-DefaultProfile <PSObject>] [-AsJob]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### RestoreExpanded
```
Restore-AzWebAppFromBackupBlobSlot -Name <String> -ResourceGroupName <String> -Slot <String>
 -SubscriptionId <String> -Overwrite -StorageAccountUrl <String> [-PassThru] [-AdjustConnectionString]
 [-AppServicePlan <String>] [-BlobName <String>] [-Database <IDatabaseBackupSetting[]>]
 [-HostingEnvironment <String>] [-IgnoreConflictingHostName] [-IgnoreDatabase] [-Kind <String>]
 [-OperationType <BackupRestoreOperationType>] [-SiteName <String>] [-DefaultProfile <PSObject>] [-AsJob]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### RestoreViaIdentityExpanded
```
Restore-AzWebAppFromBackupBlobSlot -InputObject <IWebSiteIdentity> -Overwrite -StorageAccountUrl <String>
 [-PassThru] [-AdjustConnectionString] [-AppServicePlan <String>] [-BlobName <String>]
 [-Database <IDatabaseBackupSetting[]>] [-HostingEnvironment <String>] [-IgnoreConflictingHostName]
 [-IgnoreDatabase] [-Kind <String>] [-OperationType <BackupRestoreOperationType>] [-SiteName <String>]
 [-DefaultProfile <PSObject>] [-AsJob] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### RestoreViaIdentity
```
Restore-AzWebAppFromBackupBlobSlot -InputObject <IWebSiteIdentity> [-PassThru] [-Request <IRestoreRequest>]
 [-DefaultProfile <PSObject>] [-AsJob] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Restores an app from a backup blob in Azure Storage.

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

### -AdjustConnectionString
<code>true</code> if SiteConfig.ConnectionStrings should be set in new app; otherwise, <code>false</code>.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: RestoreExpanded, RestoreViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -AppServicePlan
Specify app service plan that will own restored site.

```yaml
Type: System.String
Parameter Sets: RestoreExpanded, RestoreViaIdentityExpanded
Aliases:

Required: False
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

### -BlobName
Name of a blob which contains the backup.

```yaml
Type: System.String
Parameter Sets: RestoreExpanded, RestoreViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Database
Collection of databases which should be restored.
This list has to match the list of databases included in the backup.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.WebSite.Models.Api20160801.IDatabaseBackupSetting[]
Parameter Sets: RestoreExpanded, RestoreViaIdentityExpanded
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

### -HostingEnvironment
App Service Environment name, if needed (only when restoring an app to an App Service Environment).

```yaml
Type: System.String
Parameter Sets: RestoreExpanded, RestoreViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -IgnoreConflictingHostName
Changes a logic when restoring an app with custom domains.
<code>true</code> to remove custom domains automatically.
If <code>false</code>, custom domains are added to the app's object when it is being restored, but that might fail due to conflicts during the operation.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: RestoreExpanded, RestoreViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -IgnoreDatabase
Ignore the databases and only restore the site content

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: RestoreExpanded, RestoreViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -InputObject
Identity Parameter

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.WebSite.Models.IWebSiteIdentity
Parameter Sets: RestoreViaIdentityExpanded, RestoreViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Kind
Kind of resource.

```yaml
Type: System.String
Parameter Sets: RestoreExpanded, RestoreViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Name
Name of the app.

```yaml
Type: System.String
Parameter Sets: Restore, RestoreExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -OperationType
Operation type.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.WebSite.Support.BackupRestoreOperationType
Parameter Sets: RestoreExpanded, RestoreViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Overwrite
<code>true</code> if the restore operation can overwrite target app; otherwise, <code>false</code>.
<code>true</code> is needed if trying to restore over an existing app.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: RestoreExpanded, RestoreViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: False
Accept pipeline input: False
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

### -Request
Description of a restore request.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.WebSite.Models.Api20180201.IRestoreRequest
Parameter Sets: Restore, RestoreViaIdentity
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -ResourceGroupName
Name of the resource group to which the resource belongs.

```yaml
Type: System.String
Parameter Sets: Restore, RestoreExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SiteName
Name of an app.

```yaml
Type: System.String
Parameter Sets: RestoreExpanded, RestoreViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Slot
Name of the deployment slot.
If a slot is not specified, the API will restore a backup of the production slot.

```yaml
Type: System.String
Parameter Sets: Restore, RestoreExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -StorageAccountUrl
SAS URL to the container.

```yaml
Type: System.String
Parameter Sets: RestoreExpanded, RestoreViaIdentityExpanded
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
Parameter Sets: Restore, RestoreExpanded
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

### Microsoft.Azure.PowerShell.Cmdlets.WebSite.Models.IWebSiteIdentity

### Microsoft.Azure.PowerShell.Cmdlets.WebSite.Models.Api20180201.IRestoreRequest

## OUTPUTS

### System.Boolean

## ALIASES

## RELATED LINKS

