using Blazor_Server_Template.Components;
using Blazor_Server_Template.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();              // Register controllers for API endpoints
builder.Services.AddSwaggerDocumentation();     // Add Swagger services
builder.Services.AddCustomHealthChecks();       // Add health checks (required for OpenShift readiness and liveness probes)

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

app.UseSwagger(); // Enable Swagger
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Blazor_Server_Template - API");
});

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

// Map health checks
app.MapHealthChecks("/health");

app.MapControllers(); // Map the controller endpoints

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();


namespace Blazor_Server_Template
{
    /// <summary>
    /// Represents the program entry point for the application.
/// Contains the application bootstrap logic.
/// </summary>
    public partial class Program { }
}
