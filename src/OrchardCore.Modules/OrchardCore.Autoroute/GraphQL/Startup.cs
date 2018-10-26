using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Apis;
using OrchardCore.Autoroute.Model;
using OrchardCore.ContentManagement;
using OrchardCore.Modules;

namespace OrchardCore.Autoroute.GraphQL
{
    [RequireFeatures("OrchardCore.Apis.GraphQL")]
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddInputObjectGraphType<AutoroutePart, AutorouteInputObjectType>();
            services.AddObjectGraphType<AutoroutePart, AutorouteQueryObjectType>();
            services.AddGraphQLFilterType<ContentItem, AutorouteGraphQLFilter>();
        }
    }
}
