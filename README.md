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
├── README.md                    # High-level overview of the project and instructions
├── LICENSE                      # Licensing information (if applicable)
├── docs/                        # Documentation folder
│   ├── requirements.md          # Project requirements documentation
│   ├── stakeholder-input.md     # Stakeholder feedback and specific requirements
│   └── usage.md                 # Instructions for installing and using the template
├── src/                         # Template source code
│   ├── template/                # Base template files
│   │   ├── Pages/               # Example Razor pages (if Blazor)
│   │   ├── Services/            # Example service classes
│   │   ├── Models/              # Example models
│   │   ├── wwwroot/             # Static assets (CSS, JS, fonts)
│   │   │   ├── css/             # Includes Oblique CSS
│   │   │   ├── fonts/           # Swiss Confederation fonts
│   │   ├── Program.cs           # Entry point
│   │   └── template.json        # Metadata for dotnet template
├── tests/                       # Template testing folder
│   └── TemplateTest.csproj      # Unit tests for template verification
├── .gitignore                   # Git ignore file
```

## Getting Started

Follow these steps to install and use the Swiss .NET Project Template.

### Prerequisites
- .NET SDK 8.0 or later
- Git for version control

### Installation
1. Clone the repository:
```bash
git clone ssh://git@bitbucket.bit.admin.ch/ps-irs-apa/swiss-dotnet-template.git
cd swiss-dotnet-template
```

2. Install the template locally
```bash
dotnet new --install ./src/template
```

## Usage
Generate a new project using the template:
```bash
dotnet new swiss-dotnet -n MyProjectName
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