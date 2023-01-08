using Nest;
using testServerless.Models;

namespace testServerless.ElasticSearchExtensions
{
    public static class ElasticSearchExtensions
    {
        public static void AddElasticsearch(
            this IServiceCollection services, IConfiguration configuration)
        {
            //var url = configuration["ELKConfiguration:url"];
            var defaultIndex = configuration["ELKConfiguration:index"];

            //var settings = new ConnectionSettings(new Uri(url)).BasicAuthentication(userName, pass)
            //    .PrettyJson()
            //    .DefaultIndex(defaultIndex);

            Uri url1 = new Uri("https://search-emcar-enzptm6q2e3a26m4d424oq47la.eu-central-1.es.amazonaws.com");
            ConnectionSettings settings = new ConnectionSettings(url1);
            settings.DefaultIndex(defaultIndex);

            AddDefaultMappings(settings);

            var client = new ElasticClient(settings);
            services.AddSingleton<IElasticClient>(client);

            CreateIndex(client, defaultIndex);
        }

        private static void AddDefaultMappings(ConnectionSettings settings)
        {
            settings
                .DefaultMappingFor<Auto>(m => m
                    .Ignore(p => p.VipX)
                );
        }

        private static void CreateIndex(IElasticClient client, string indexName)
        {
            var createIndexResponse = client.Indices.Create(indexName,
                index => index.Map<Auto>(x => x.AutoMap())
            );
        }
    }
}
