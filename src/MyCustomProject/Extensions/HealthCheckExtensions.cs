using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace MyCustomProject.Extensions
{
    /// <summary>
    /// Provides extension methods to add custom health checks to the application.
    /// </summary>
    public static class HealthCheckExtensions
    {
        /// <summary>
        /// Adds custom health checks to the application's service collection.
        /// </summary>
        /// <param name="services">The service collection to which health checks will be added.</param>
        /// <returns>The updated service collection.</returns>
        public static IServiceCollection AddCustomHealthChecks(this IServiceCollection services)
        {
            // Add the default health check (required for OpenShift readiness and liveness probes)
            services.AddHealthChecks()
                .AddCheck("BasicHealthCheck", () =>
                    HealthCheckResult.Healthy("Application is running successfully."));

            // Uncomment if the project needs additional health checks:

            // Example: SQL Server health check
            // .AddSqlServer(
            //     connectionString: "YourSQLServerConnectionString",
            //     name: "SQLServerCheck",
            //     failureStatus: HealthStatus.Degraded,
            //     tags: new[] { "database" }
            // );

            // Example: PostgreSQL health check
            // .AddNpgSql(
            //     connectionString: "YourPostgresConnectionString",
            //     name: "PostgreSQLCheck",
            //     failureStatus: HealthStatus.Degraded,
            //     tags: new[] { "database" }
            // );

            // Example: Remote API health check
            // .AddUrlGroup(
            //     new Uri("https://api.example.com/health"),
            //     name: "RemoteApiCheck",
            //     failureStatus: HealthStatus.Unhealthy,
            //     tags: new[] { "external" }
            // );

            return services;
        }
    }
}
