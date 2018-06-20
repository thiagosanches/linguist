using System.Collections.Generic;
using Newtonsoft.Json;

namespace Translator.Model 
{
    public class Recipe
    {
        [JsonProperty(PropertyName = "OS")]
        public string OperatingSystem { get; set; }

        [JsonProperty(PropertyName = "applications")]
        public List<Application> Applications { get; set; }

        [JsonProperty(PropertyName = "gitRepositories")]
        public string[] GitRepositories { get; set; }
    }
}