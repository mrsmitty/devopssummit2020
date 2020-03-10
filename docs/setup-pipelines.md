# Instructions for Azure Pipeline Configuration

## Service Connections

Connection Name | Connection Type | Description
--- | --- | ---
sp-acr-summit2020 | Docker Registry | Connection to Azure Container Registry
sp-ado-summit2020 | Azure Resource Manager | Connection to Subscription/Resource group

## Library
**Name:** DevEnvironment
Name | Value
---|---
containerRegistry | devopssydacrsummit2020.azurecr.io
containerRepository | devopssummit2020
Subscription | sp-ado-summit2020
WebAppName | DEVOPS-SYD-WEB-SUMMIT2020

## Pipeline Badge

- Go to project settings
- Piplines \ Settings
- Turn off _"Disable anonymous access to badges"_