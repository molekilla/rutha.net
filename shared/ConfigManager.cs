using System;
using Microsoft.Framework.ConfigurationModel;

namespace Rutha.Shared {
  
  public class ConfigManager { 

    public static IConfiguration Create(string path) {
      // var file = fileConfig ?? "config.json";
      var configuration = new Configuration()
          .AddEnvironmentVariables();
      
      var env = configuration.Get("rutha_env");
      return new Configuration().AddJsonFile(path + "/" + env + ".json").AddEnvironmentVariables();
    }

  } 

}