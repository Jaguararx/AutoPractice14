using System.Collections.Generic;
using Newtonsoft.Json;

namespace AutoPractice14.Services.Models
{
    public class Response
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public List<EmployeeEntity> Data { get; set; }
    }
}
