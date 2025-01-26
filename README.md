# A Night at the Museum

A Night at the Museum is a console application developed in C# with .NET 8.0. The program allows users to navigate through a museum, exploring its rooms and interacting with the displayed artwork based on a predefined map. The application is designed for easy updates, enabling new rooms or artwork to be added or moved effortlessly.

## Requirements

Before running the project, ensure the following are installed on your system:

- .NET 8.0 SDK or later
- A code editor such as Visual Studio (recommended) or Visual Studio Code

## Packages

The project uses the following NuGet packages, which are automatically restored during the build process:

- `coverlet.collector` (6.0.0)
- `Microsoft.NET.Test.Sdk` (17.8.0)
- `xunit` (2.5.3)
- `xunit.runner.visualstudio` (2.5.3)

You do not need to install these packages manually. They will be restored by running `dotnet restore`.

## Setup Instructions

### Clone this repository

```bash
git clone https://github.com/your-github-username/ennattpamuseet.git
cd ennattpamuseet
```

### Restore required packages
```
dotnet restore
```
### Run the application
```
dotnet run --project ennattpamuseet
```
When the program starts, an introduction will guide you on how to navigate through the museum.
## Testing

To run the unit tests, use the following command:
```
dotnet test
```
## Features

- Navigate between different rooms in the museum following a logical map.
- View artwork in each room, including their title, description, and creator.
- Flexible structure to easily add new rooms or relocate artwork.
