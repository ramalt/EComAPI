using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace EComAPI.Persistence;

public static class Configurations
{

    public static string ConnectionString
    {
        get
        {
            ConfigurationManager configManager = new();

            configManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/EcomAPI.API"));
            configManager.AddJsonFile("appsettings.Development.json");

            return configManager.GetConnectionString("Postgre");
        }

    }
}
