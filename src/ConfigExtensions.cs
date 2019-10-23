using Microsoft.Extensions.Configuration;
using System;

namespace finitelogic.Common.Configuration
{
    public static class ConfigExtensions
    {
        public static string Get(this IConfiguration configuration, string parameterName)
        {
            string configItem = configuration[parameterName];
            if (configItem == null)
            {
                throw new ArgumentNullException($"{parameterName} configuration value missing");
            }

            return configItem;
        }
    }
}
