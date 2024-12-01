using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Reflection;

namespace blazor_server_template.Extensions
{
    /// <summary>
    /// Provides extension methods to add Swagger documentation to the service collection.
    /// </summary>
    public static class SwaggerExtensions
    {
        /// <summary>
        /// Configures Swagger documentation for the application.
        /// </summary>
        /// <param name="services">The service collection to add Swagger to.</param>
        public static void AddSwaggerDocumentation(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    // Example Title: Change this for your project
                    Title = "swiss-blazor-server-template - API",
                    // Example Version: Change according to your versioning strategy
                    Version = "1.0.0",
                    // Example Description: Provide a detailed description
                    Description = "A template project for building APIs with comprehensive Swagger documentation.",
                    // Example Contact Information: Adapt for your support team or project
                    Contact = new OpenApiContact
                    {
                        Name = "API Support",
                        Url = new Uri("https://github.com/example"),
                        Email = "support@example.com"
                    },
                    // Example License: Provide licensing details or set it to null if not applicable
                    License = new OpenApiLicense
                    {
                        Name = "MIT License",
                        Url = new Uri("https://opensource.org/licenses/MIT")
                    }
                });

                // Ensure the XML document for Swagger is generated
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);

                // Adding the external documentation
                c.DocumentFilter<ExternalDocsFilter>();
            });
        }

        /// <summary>
        /// A custom filter for adding external documentation links to the Swagger UI.
        /// </summary>
        private class ExternalDocsFilter : IDocumentFilter
        {
            /// <summary>
            /// Adds external documentation to the Swagger document.
            /// </summary>
            /// <param name="swaggerDoc">The Swagger document to modify.</param>
            /// <param name="context">The document filter context.</param>
            public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
            {
                swaggerDoc.ExternalDocs = new OpenApiExternalDocs
                {
                    // Example External Docs: Update these to link to your documentation
                    Description = "Find detailed API documentation here",
                    Url = new Uri("https://example.com/docs")
                };
            }
        }
    }
}
