if(($null -eq $TestName) -or ($TestName -contains 'Remove-AzPolicyDefinition'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Remove-AzPolicyDefinition.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Remove-AzPolicyDefinition' {
    It 'Name' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'ManagementGroupName' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'SubscriptionId' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Id' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'InputObject' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
