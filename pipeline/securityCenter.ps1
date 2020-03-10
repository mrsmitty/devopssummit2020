$token = $(az account get-access-token --query accessToken -o tsv)

# $scope = "subscriptions/4c5938fd-1603-4ec2-b3cf-df8175d76d66"
# $url =  "https://management.azure.com/$scope/providers/Microsoft.Security/assessments?api-version=2020-01-01"


$assessmentType = "dbd0cb49-b563-45e7-9724-889e799fa648"
$resourceId = "/subscriptions/4c5938fd-1603-4ec2-b3cf-df8175d76d66/resourceGroups/DEVOPS-SYD-ARG-SUMMIT2020/providers/Microsoft.ContainerRegistry/registries/devopssydacrsummit2020"
$url =  "https://management.azure.com$resourceId/providers/Microsoft.Security/assessments/$($assessmentType)?api-version=2020-01-01"
$header = @{
"Authorization"= "Bearer $token"
}
Write-Host $url
Invoke-RestMethod $url -Headers $header | ConvertTo-Json