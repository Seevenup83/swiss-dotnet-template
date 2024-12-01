# Stakeholder Input and Specific Requirements

## **Collected Requirements**
- Use Swiss Confederation Oblique CSS for visual consistency.
- Include MudBlazor for component-based UI.
- Predefined folder hierarchy: `Pages`, `Services`, `Models`, `wwwroot`.
- Reusable `/health` endpoint for readiness/liveness probes.
- Preconfigured settings for logging, DI, and OpenShift compatibility.

## **Stakeholder Feedback**
### Developers
- Requested better integration with MudBlazor components.

### Project Leads
- Highlighted the importance of reducing setup time.

### Security/DevOps Teams
- Required health checks and OpenShift readiness.
- Stressed the need to define proper handling of secrets with Vault, as the current workaround is temporary and unsatisfactory.


## Open Points for Discussion
### 1. UI Functionality Implementation
Option 1: Take over existing JavaScript-based UI functionality and adapt it for Blazor.
Option 2: Rewrite the UI functionality in C# for Blazor, ensuring a more seamless integration and better maintainability.

### 2. Handling Secrets
How to implement a secure, production-ready integration with Vault for secrets management.
Whether to make this a mandatory feature or provide a fallback configuration for simpler projects.

### 3. Swagger Integration
Define a standard approach for API documentation and testing, ensuring it meets both developer and stakeholder needs.

### 4. Reusable Components
Determine which components should be prebuilt and included in the template (e.g., tables, forms, modals).

### 5. Error Handling and Logging
Standardize error handling practices and ensure logging aligns with both development and production requirements.

### 6. Extensibility
Define a clear strategy for enabling developers to extend or customize the template without breaking its core functionality.

### 7. Main Layout Design
Discuss and finalize the structure and content of the main layout.