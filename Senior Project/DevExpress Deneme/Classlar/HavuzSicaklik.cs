using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Otel_Uygulamasi.Classlar
{
    public partial class Sıcaklık
    {
        [JsonProperty("channel")]
        public Channel Channel { get; set; }

        [JsonProperty("feeds")]
        public List<Feed> Feeds { get; set; }
    }

    public partial class Channel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("field1")]
        public string Field1 { get; set; }

        [JsonProperty("created_at")]
        public System.DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public System.DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("last_entry_id")]
        public long LastEntryId { get; set; }
    }

    public partial class Feed
    {
        [JsonProperty("created_at")]
        public System.DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("entry_id")]
        public long EntryId { get; set; }

        [JsonProperty("field1")]
        public string Field1 { get; set; }
    }

    public partial class Sıcaklık
    {
        public static Sıcaklık FromJson(string json) => JsonConvert.DeserializeObject<Sıcaklık>(json, Otel_Uygulamasi.Classlar.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Sıcaklık self) => JsonConvert.SerializeObject(self, Otel_Uygulamasi.Classlar.Converter.Settings);
    }

    internal class Converter
    {
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
