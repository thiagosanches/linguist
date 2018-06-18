using System.Collections.Generic;
using Newtonsoft.Json;

namespace Translator.Model 
{
    public class PackageDefinition
    {
        [JsonProperty(PropertyName = "OS")]
        public string OperatingSystem { get; set; }

        [JsonProperty(PropertyName = "packages")]
        public List<Package> Packages { get; set; }
    }
}