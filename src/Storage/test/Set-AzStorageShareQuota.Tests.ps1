$TestRecordingFile = Join-Path 'C:\zd\azure-powershell\src\Storage\test' 'Set-AzStorageShareQuota.Recording.json'
. (Join-Path $PSScriptRoot '..\generated\runtime' 'HttpPipelineMocking.ps1')

Describe 'Set-AzStorageShareQuota' {
    It 'ShareName' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Share' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
