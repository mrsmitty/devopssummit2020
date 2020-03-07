# Configuration of Azure Boards demo content

## Teams

- Navigate to the project settings cog
- Navigate to General\Teams
- Rename the default team to "Content Team"
- Create a new team called "Accounts Team"

## Paths and Iterations

### Paths
Within Settings:
- Navigate to Boards\Project configuration
- Navigate to Areas
- Create a new Area for the content team
- Navigate to Boards\Team configuration
- Enable Epics in "Backlog navigation levels"
- select Content Team (from the very top breadcrumb)
- Change Content Team to use Content Team Area
- Remove the DevOps Summit 2020 Area

### Iterations

- Navigate to Boards\Project configuration
- Create Sprints [1-5]
- Navigate to Boards\Team configuration
- Select Accounts Team
- Select Iterations
- Add all iterations
- Do the same for the Content Team

![img](./media/Iterations.png)

## Import
- Navigate to Boards\Queries
- Select Import from CSV
- Select the file backlog\Backlog Import.csv within the repo

## Extensions

- From the marketplace
  - [Delivery Plans](https://marketplace.visualstudio.com/items?itemName=ms-devlabs.workitem-feature-timeline-extension)
  - [Retrospectives](https://marketplace.visualstudio.com/items?itemName=ms-devlabs.team-retrospectives)