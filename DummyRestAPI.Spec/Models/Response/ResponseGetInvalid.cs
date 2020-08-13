using Newtonsoft.Json;

namespace RestAPI.Spec.Models
{
    public class ResponseGetInvalid
    {
        [JsonProperty("status")]
        public string Status;

        [JsonProperty("data")]
        public string Data;
    }
}