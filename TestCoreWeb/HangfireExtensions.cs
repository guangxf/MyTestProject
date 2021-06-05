using Hangfire;
using Hangfire.RecurringJobExtensions;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestCoreWeb
{
    public static class HangfireExtensions
    {
        public static IApplicationBuilder UseRecurringJob(this IApplicationBuilder app, string jsonFile)
        {
            if (string.IsNullOrEmpty(jsonFile)) throw new ArgumentNullException(nameof(jsonFile));
            GlobalConfiguration.Configuration.UseRecurringJob(jsonFile);
            return app;
        }
    }
}
