using AspNetCoreRateLimit;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace Pro.RateLimiting.Extensions
{
    public static class StartupConfigurations
    {
        public static void ConfigureRateLimitingOptions(this IServiceCollection services)
        {
            var rateLimitRules = new List<RateLimitRule>{
                new RateLimitRule
                {
                    Endpoint = "*",
                    Limit = 3,
                    Period = "3m"
                }};

            services.Configure<IpRateLimitOptions>(opt => opt.GeneralRules = rateLimitRules);

            services.AddSingleton<IRateLimitCounterStore, MemoryCacheRateLimitCounterStore>();
            services.AddSingleton<IIpPolicyStore, MemoryCacheIpPolicyStore>();
            services.AddSingleton<IRateLimitConfiguration, RateLimitConfiguration>();
            services.AddSingleton<IProcessingStrategy, AsyncKeyLockProcessingStrategy>();
        }
    }
}