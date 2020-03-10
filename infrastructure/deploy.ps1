param(
    [string] $rgName = "DEVOPS-SYD-ARG-SUMMIT2020",
    [string] $templatePath = ".\template.json"
)
$location = "australiaeast"

Write-Host "Path: $templatePath"
Write-Host "Resource Group: $rgName"

Write-Host "Creating Resource Group" -Foreground Magenta
az group create -n $rgName -l $location

Write-Host "Deploying Resource Group" -Foreground Magenta
az group deployment create -g $rgName --template-file $templatePath