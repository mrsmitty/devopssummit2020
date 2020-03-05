$rgName = "DEVOPS-SYD-ARG-SUMMIT2020"
$location = "australiaeast"

az group create -n $rgName -l $location
az group deployment create -g $rgName --template-file .\template.json