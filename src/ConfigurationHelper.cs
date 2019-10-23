using Microsoft.Extensions.Configuration;

namespace finitelogic.Common.Configuration
{
    public static class ConfigurationHelper
    {
        public static IConfiguration GetIConfigurationRoot(string basePath, string environment)
        {
            return new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json", optional: true)
                .AddJsonFile($"appsettings.{environment}.json", optional: true)
                //.AddUserSecrets("e3dfcccf-0cb3-423a-b302-e3e92e95c128")
                .AddEnvironmentVariables()
                .Build();
        }


    }
}
