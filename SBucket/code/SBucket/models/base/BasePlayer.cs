
using System.Collections.Generic;
using System.Text.Json;
using System;
using System.Text.Json.Serialization;

// Autogenerated 2021-06-06T09:44:39+10:00
namespace SBucket
{
    public class BasePlayer<T1>
    {



        [JsonInclude, JsonPropertyName("metadata")]
        public T1 Metadata { get; set; }



        [JsonInclude, JsonPropertyName("organisationId")]
        public string OrganisationId { get; set; }



        [JsonInclude, JsonPropertyName("name")]
        public string Name { get; set; }



        [JsonInclude, JsonPropertyName("playerId")]
        public string PlayerId { get; set; }



        [JsonInclude, JsonPropertyName("id")]
        public string Id { get; set; }



        [JsonInclude, JsonPropertyName("active")]
        public bool Active { get; set; }



        [JsonInclude, JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; }



        [JsonInclude, JsonPropertyName("updatedAt")]
        public DateTime UpdatedAt { get; set; }


        public string Serialise()
        {
            var options = new JsonSerializerOptions { WriteIndented = true, IncludeFields = true };
            string jsonString = JsonSerializer.Serialize(this, options);
            return jsonString;
        }

        public BasePlayer<T1> Deserialise(string json)
        {

            var deserialised = CreateFromJson(json);


            Metadata = deserialised.Metadata;
            OrganisationId = deserialised.OrganisationId;
            Name = deserialised.Name;
            PlayerId = deserialised.PlayerId;
            Id = deserialised.Id;
            Active = deserialised.Active;
            CreatedAt = deserialised.CreatedAt;
            UpdatedAt = deserialised.UpdatedAt;
            return this;
        }


        public static BasePlayer<T1> CreateFromJson(string json)
        {
            return JsonSerializer.Deserialize<BasePlayer<T1>>(json);
        }

        public BasePlayer()
        {

        }

        public BasePlayer(string json)
        {
            Deserialise(json);
        }
    }
}

