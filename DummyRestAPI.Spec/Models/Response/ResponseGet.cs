using Newtonsoft.Json;
using System.Collections.Generic;

namespace RestAPI.Spec.Models
{
    public class ResponseGet
    {
        [JsonProperty("status")]
        public string Status;

        [JsonProperty("data")]
        public List<Employee> Employees;
    }
}
