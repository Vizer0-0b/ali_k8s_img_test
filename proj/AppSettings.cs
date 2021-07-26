using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;


namespace ali_k8s_img_test
{
    public class AppSettings
    {
        private IConfigurationRoot Configuration;

        private AppSettings()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            Configuration = builder.Build();
        }

        private static readonly Lazy<AppSettings> InstanceLock = new Lazy<AppSettings>(() => new AppSettings()
        {

        });

        public static AppSettings Instance
        {
            get
            {
                return InstanceLock.Value;
            }
        }

        public string GetByKey(string key)
        {
            return Configuration.GetSection(key).Value;
        }

        public string GetConnectionString()
        {
            return Configuration.GetConnectionString("dbName");
        }
    }
}
