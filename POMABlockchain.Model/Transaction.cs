
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Globalization;

namespace POMABlockchain.Api.Model
{
    public partial class Transaction
    {
        [JsonProperty("vouts")]
        public Claim[] Vouts { get; set; }

        [JsonProperty("vin")]
        public Claim[] Vin { get; set; }

        [JsonProperty("version")]
        public long Version { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("txid")]
        public string Txid { get; set; }

        [JsonProperty("time")]
        public long Time { get; set; }

        [JsonProperty("sys_fee")]
        public long SysFee { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("scripts")]
        public object[] Scripts { get; set; }

        [JsonProperty("pubkey")]
        public object Pubkey { get; set; }

        [JsonProperty("nonce")]
        public object Nonce { get; set; }

        [JsonProperty("net_fee")]
        public long NetFee { get; set; }

        [JsonProperty("description")]
        public object Description { get; set; }

        [JsonProperty("contract")]
        public object Contract { get; set; }

        [JsonProperty("claims")]
        public Claim[] Claims { get; set; }

        [JsonProperty("block_height")]
        public long BlockHeight { get; set; }

        [JsonProperty("block_hash")]
        public string BlockHash { get; set; }

        [JsonProperty("attributes")]
        public object[] Attributes { get; set; }

        [JsonProperty("asset")]
        public object Asset { get; set; }
    }

    public partial class Transaction
    {
        public static Transaction FromJson(string json) => JsonConvert.DeserializeObject<Transaction>(json, ConverterTransaction.Settings);
    }

    public static class SerializTransaction    {
        public static string ToJson(this Transaction self) => JsonConvert.SerializeObject(self, ConverterTransaction.Settings);
    }

    internal static class ConverterTransaction    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
