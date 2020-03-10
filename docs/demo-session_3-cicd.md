# Demo 3 - Build and Release Pipelines

## Azure Pipelines

- I have two pipelines
  - build of my application
  - deployment of infrastructure
- The definition of the pipeline lives in GitHub alongside
  - Application
  - Infrastructure
- Complete solution that is portable and can be easily replicated
  - Setup additional environment
  - Distribute the solution to external developers or for providing support

## Release Pipelines
- Release pipelines consumes artifacts and allows me to deploy to multiple environments or stages
- Development is set to deploy automatically when a release is ready
  - This helps the dev team perform integration test or immediately hand over to testers
- Check environment and see if change has come through

### Move to production
- I'm happy with changes but I have requirements to go to production
- Approvers
  - My content team must approve the changes
  - Pass Azure Policies
  - Call REST - Azure Security Center
- Evaluated security early
  - dev team notified and can remmediate
  - ensure production release is successful

## Libraries

- Show the Library for the Dev environment
- Discuss versatility of sharing Libraries between different pipelines

## Azure Pipelines Classic (Release Pipelines)

- Show Azure Release in the portal
- Discuss Artifacts and Release Triggers
- Discuss Stages and Tasks
- Demonstrate simplicity of creating a new Stage (development) via cloning and linking of Libraries
- Show Pre and Post approvals
  - Manual Gates
  - Azure Policy
  - Invoking REST API
- Discuss shift-left