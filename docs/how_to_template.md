# Creating and Managing the Swiss .NET Template

This guide explains how to create a Blazor Server template, configure it for `dotnet new`, and package it as a NuGet package for distribution.

---

## **Steps to Create the Template**

### 1. Navigate to the `src` Directory
Ensure you are in the correct folder where you want to create the template:
```bash
cd swiss-dotnet-template/src/
```

### 2. Scaffold a Blazor Server Project
Use the built-in blazor template to scaffold a Blazor Server project:
```bash
dotnet new blazor -o blazor-server-template
```

### 3. Clean Unnecessary Files
Remove the obj directory as it is not needed in the template:
```bash
rm -r blazor-server-template/obj
```

### 4. Add Template Configuration
Create a .template.config folder in the root of the new project:
```bash
mkdir blazor-server-template/.template.config
```

Create the template.json file:
```bash
touch blazor-server-template/.template.config/template.json
```

### 5. Configure template.json
Add the following content to the template.json file:
```json
{
  "$schema": "http://json.schemastore.org/template",
  "author": "Sven Lauber, BIT, PS-IRS-APA",
  "classifications": ["Swiss", "WebAPI", "Blazor", "UI"],
  "identity": "SwissDotNetTemplate.Template",
  "name": "Swiss DotNet Template",
  "shortName": "swissdotnet",
  "sourceName": "swiss-dotnet-template",
  "tags": {
    "language": "C#",
    "type": "project"
  },
  "sources": [
    {
      "exclude": [
        "**/*.sln"
      ]
    }
  ]
}
```

6. Create a Solution File
Run the following command to create a new solution file:
```bash
cd blazor-server-template/
dotnet new sln -n blazor-server-template
```

This creates a solution file named swiss-dotnet-template.sln in the current directory.

7. Add the Project to the Solution
Add your project to the solution file:
```bash
dotnet sln add blazor-server-template.csproj
```

This ensures that the blazor-server-template.csproj is recognized by the solution.

## Testing and Using the Template
### 1. Install the Template Locally
Run the following command to install the template locally:
```bash
dotnet new install ./blazor-server-template
```

### 2. Create a New Project from the Template
Generate a new project using the installed template:
```bash
dotnet new swissdotnet -n MyCustomProject -o MyCustomProject
```

## Packaging the Template as a NuGet Package
To share the template, you can package it as a NuGet package:

Ensure your blazor-server-template project is ready for distribution.
Run the following command to create a NuGet package:
```bash
dotnet pack ./blazor-server-template
```

This will create a .nupkg file in the bin/Debug folder. You can distribute this package or publish it to a NuGet feed for others to use.