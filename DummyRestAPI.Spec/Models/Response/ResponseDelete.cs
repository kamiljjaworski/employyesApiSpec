using Newtonsoft.Json;

namespace RestAPI.Spec.Models
{
    public class ResponseDelete
    {
        [JsonProperty("status")]
        public string Status;

        [JsonProperty("data")]
        public int Data;
    }
}