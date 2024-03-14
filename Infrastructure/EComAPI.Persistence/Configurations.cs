using Microsoft.Extensions.Configuration;

namespace EComAPI.Persistence;

public static class Configurations
{

    public static string ConnectionString
    {
        get
        {
            ConfigurationManager configManager = new();
            
            try
            {

                configManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/EComAPI.API"));

                configManager.AddJsonFile("appsettings.Development.json");
            }
            catch
            {

                configManager.AddJsonFile("appsettings.json");

            }


            return configManager.GetConnectionString("Postgre");
        }

    }
}
