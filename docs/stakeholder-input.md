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