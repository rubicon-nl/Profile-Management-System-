using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Profile.Service.Gateway
{
    internal class HideOcelotControllersFilter : IDocumentFilter
    {
        private static readonly string[] ignoredPaths = {
            "/configuration",
            "/outputcache/{region}"
        };


        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            foreach (var ignorePath in ignoredPaths)
            {
                swaggerDoc.Paths.Remove(ignorePath);
            }
        }
    }
}
