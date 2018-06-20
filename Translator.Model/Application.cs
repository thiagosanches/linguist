using Newtonsoft.Json;

namespace Translator.Model 
{
    public class Application
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        [JsonProperty(PropertyName = "setup")]
        public string Setup { get; set; }

        [JsonProperty(PropertyName = "isCustom")]
        public bool IsCustom { get; set; }
    }
}