using blazor_server_template.Components;
using blazor_server_template.Extensions;

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
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "swiss-blazor-server-template - API");
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
