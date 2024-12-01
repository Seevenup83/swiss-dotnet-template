# Swiss .NET Project Template

A .NET project template designed to enforce consistent project structures, integrate Swiss Confederation design standards, and streamline development processes. This template supports Web APIs, Blazor applications, and microservices.

## Table of Contents
1. [About the Project](#about-the-project)
2. [Features](#features)
3. [Folder Structure](#folder-structure)
4. [Getting Started](#getting-started)
5. [Contributing](#contributing)
6. [Documentation](#documentation)
7. [Designe Integration](#swiss-confederation-design-system-integration)


## About the Project
This template ensures consistent project structures while adhering to the Swiss Confederation design standards. It integrates key technologies like Oblique CSS and MudBlazor and includes preconfigured health checks and logging for OpenShift readiness.

The template reduces setup time, promotes best practices, and aligns with organizational branding and security standards.


## Features
- **Swiss Confederation Design Standards**: Includes Oblique CSS and fonts for branding consistency.
- **Component-Based UI**: Integrated with MudBlazor for modern UI development.
- **Health Checks**: Preconfigured `/health` endpoint for readiness/liveness probes.
- **Logging and Dependency Injection**: Prebuilt configurations for ease of use.
- **Customizable**: Easily adaptable with namespace and project-specific parameters.

## Folder Structure
The repository is organized as follows:
```
├── README.md                               # High-level overview of the project and instructions
├── docs/                                   # Documentation folder
│   ├── how_to_template.md                  # Instructions on creating and maintaining the template
│   ├── stakeholder-input.md                # Notes from discussions with stakeholders
│   ├── usage.md                            # How to use the template
│   ├── swiss-confederation-mudblazor.md    # Details on integrating Swiss Confederation design system
│   ├── requirements.md                     # Requirements for the project
├── src/                                    # Template source code
│   ├── swiss-blazor-server-template/       # Main template folder
│   │   ├── .template.config/               # Template metadata
│   │   │   └── template.json               # Metadata and settings for the .NET template
│   │   ├── Components/                     # Blazor components
│   │   │   ├── Layout/                     # Layout components (MainLayout, Header, Footer, etc.)
│   │   │   ├── Pages/                      # Application pages
│   │   │   │   ├── Examples/               # Example Razor pages (Weather, Counter, etc.)
│   │   ├── Extensions/                     # Extensions for reusable functionality
│   │   │   ├── HealthCheckExtensions.cs    # Health check logic for OpenShift readiness/liveness probes
│   │   │   ├── SwaggerExtensions.cs        # Swagger/OpenAPI documentation setup
│   │   ├── Controllers/                    # Example API controllers
│   │   │   ├── TodoController.cs           # Example controller for testing API functionality
│   │   ├── Services/                       # Example service classes
│   │   ├── Models/                         # Example models used by the application
│   │   ├── wwwroot/                        # Static assets
│   │   │   ├── swiss-confederation/        # Swiss Confederation styles and resources
│   │   │   │   ├── v1.0.26.css             # Swiss Confederation main CSS
│   │   │   │   ├── scripts/                # JavaScript functionality
│   │   │   │   ├── fonts/                  # Fonts used in the project
│   │   │   │   ├── icons/                  # SVG icons for visual consistency
│   │   │   │   ├── favicon.ico             # Project favicon
│   │   ├── Program.cs                      # Application entry point
│   │   ├── appsettings.json                # Default application settings
│   │   ├── appsettings.Development.json    # Development-specific settings
├── tests/                                  # Template testing folder
│   └── TemplateTest.csproj                 # Unit tests for verifying the template functionality
├── .gitignore                              # Files and directories to be ignored by Git
```

## Getting Started

Follow these steps to install and use the Swiss .NET Project Template.

### Prerequisites
- .NET SDK 8.0 or later ([Install .NET SDK on Ubuntu](https://learn.microsoft.com/en-us/dotnet/core/install/linux-ubuntu-install?tabs=dotnet8&pivots=os-linux-ubuntu-2410))
- Git for version control

### Installation
1. Clone the repository:
```bash
git clone ssh://git@bitbucket.bit.admin.ch/ps-irs-apa/swiss-dotnet-template.git
cd swiss-dotnet-template
```

2. Install the template locally
```bash
dotnet new --install ./src/swiss-blazor-server-template
```

## Usage
Generate a new project using the template:
```bash
dotnet new swissblazorserver -n MyProjectName
```

## Contributing
Contributions are welcome! To contribute:
1. Fork the repository.
2. Create a new branch: `git checkout -b feature/my-feature`.
3. Commit your changes: `git commit -m 'Add new feature'`.
4. Push to the branch: `git push origin feature/my-feature`.
5. Open a pull request.

Please ensure your changes align with the project standards and include documentation if necessary.

## Documentation
For a detailed guide on how to create a .NET template, refer to the [Template Creation Guide](docs/how_to_template.md).


## Swiss Confederation Design System Integration
This project integrates the Swiss Confederation Design System to ensure compliance with federal design standards. The integration includes custom CSS and fonts, which are seamlessly incorporated into the Blazor template.


For detailed steps and explanations about how the design system was integrated into this template, refer to the [Design System Integration Guide](docs/swiss-confederation-mudblazor.md).