using Microsoft.Extensions.Configuration;
using RestSharp;

namespace WebApplication.API
{

    public class CustomRestClient
    {
        public readonly Appconfiguration _appConfig = new();

        public CustomRestClient()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            config.Bind(_appConfig);
        }

        public RestClient CreateRestClient(Service service)
        {
            var baseUrl = service switch
            {
                Service.Bibles => _appConfig.BibleBaseUrl,
                Service.Tech => _appConfig.TechBaseUrl,
                _ => throw new AggregateException("Invalid service option provided!")
            };
            var options = new RestClientOptions(baseUrl);
            return new RestClient(options);
        }
    }
}