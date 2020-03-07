param(
    [string] $rgName = "DEVOPS-SYD-ARG-SUMMIT2020",
    [string] $templatePath = ".\template.json"
)
$location = "australiaeast"

az group create -n $rgName -l $location
az group deployment create -g $rgName --template-file $templatePath