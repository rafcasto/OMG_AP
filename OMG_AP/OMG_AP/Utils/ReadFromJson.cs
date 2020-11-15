using OMG_AP.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

using System.Linq;
using Newtonsoft.Json;
using System.IO;

namespace OMG_AP.Utils
{
    public static class ReadFromJson
    {
        private static string ENVIRONMENT_PATH = @"Data\Environements.json";
        public static string SETTINGS_PATH = @"Data\Settings.json";
        public static string USERS_DEV = @"Data\Dev\Users.json";
        public static string USERS_PROD = @"Data\Prod\Users.json";

        public static EnvironmentModel GetEnvironment()
        {
            var environementModelList = ReadJsonFiles<List<EnvironmentModel>>(ENVIRONMENT_PATH);
            var settingEnv = ReadJsonFiles<Settings>(SETTINGS_PATH);
            return environementModelList.FirstOrDefault(environment => string.Equals(settingEnv.Environment, environment.Environment));
        }

        public static List<User> ReadUsers() 
        {
            var settingEnv = ReadJsonFiles<Settings>(SETTINGS_PATH);
            if (string.Equals(Constants.DEV_ENV, settingEnv.Environment)) 
            {
                return ReadJsonFiles<List<User>>(USERS_DEV);
            }

            return ReadJsonFiles<List<User>>(USERS_PROD);
        }

        public static T ReadJsonFiles<T>(string filePath)
        {
            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
