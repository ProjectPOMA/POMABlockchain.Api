using Newtonsoft.Json;

namespace POMABlockchain.Api.Model
{
    public class Claim
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("txid")]
        public string Txid { get; set; }

        [JsonProperty("n")]
        public long N { get; set; }

        [JsonProperty("asset")]
        public string Asset { get; set; }

        [JsonProperty("address_hash")]
        public string AddressHash { get; set; }
    }
}
