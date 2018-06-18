using Newtonsoft.Json;

namespace Translator.Model 
{
    public class Package
    {
        [JsonProperty(PropertyName = "package")]
        public string Name { get; set; }
        
        [JsonProperty(PropertyName = "command")]
        public string Command { get; set; }
    }
}