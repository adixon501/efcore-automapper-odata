using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EfCoreAutomapperOdata.Shared.Models
{
    public class ODataResponse<T>
    {
        [JsonProperty("@odata.count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public List<T> Values { get; set; }
    }
}
