using Newtonsoft.Json;

namespace Translator.Model 
{
    public class PackageDefinition
    {
        [JsonProperty(PropertyName = "OS")]
        public string OperatingSystem { get; set; }

        [JsonProperty(PropertyName = "packages")]
        public string[] Packages { get; set; }
    }
}