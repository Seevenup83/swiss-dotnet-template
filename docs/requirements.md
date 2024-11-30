# Project Requirements: Swiss .NET Project Template

This document outlines the requirements for developing a .NET project template aligned with the Swiss Confederation design standards.

## **Step 1: Requirements Gathering**
### **1.1 Understand Project Goals**
- **Purpose:**
  - Ensure consistent project structures.
  - Integrate Swiss design standards.
  - Reduce project setup time for developers.

- **Scope:**  
  - The template will support:
    - Web APIs
    - Blazor applications
    - Microservices

### **1.2 Collect Inputs from Stakeholders**
- **Stakeholders to Consult:**
  - **Developers:** Identify pain points and desired features.  
  - **Project Leads:** Ensure the template aligns with organizational goals and standards.  
  - **UI/UX Designers:** Define branding and design requirements (e.g., Oblique CSS).  
  - **Security/DevOps Teams:** Address security and deployment needs (e.g., health checks, OpenShift compatibility).  

### **1.3 Review Existing Standards**
- Identify relevant organizational tools and standards:
  - Existing templates or tools (e.g., Oblique, MudBlazor).  
  - Coding standards and best practices.  
  - Security and accessibility guidelines.

  ## **Step 1.4 Specific Requirements and Standards**
Detailed requirements and stakeholder input are documented in [stakeholder-input.md](stakeholder-input.md).


## **Step 2: Define Specific Requirements**
### **2.1 Technical Requirements**
- **Project Structure:**  
  - Predefined folder hierarchy (e.g., `Pages`, `Services`, `Models`, `wwwroot`).  

- **Dependencies:**  
  - Include MudBlazor for component-based development.  
  - Integrate Oblique CSS and fonts for branding consistency. [Document for developers](https://swiss.github.io/designsystem/?path=/docs/get-started--docs)

- **Preconfigured Settings:**  
  - Setup for logging, dependency injection (DI), and configuration.  

- **Health Checks:**  
  - A reusable `/health` endpoint for readiness/liveness probes.  

- **Customization Options:**  
  - Allow for namespace, project name, and component configuration through parameters.

### **2.2 Documentation and Training**
- Include a guide for installation, usage, and customization of the template.  
- Provide examples of best practices for extending and maintaining projects.  

## **Expected Outcome**
At the end of the requirements gathering phase:
1. A detailed requirements document covering all technical, design, and operational needs.  
2. Agreement among stakeholders on the scope and features of the template.  
3. A clear and actionable path forward for template implementation.