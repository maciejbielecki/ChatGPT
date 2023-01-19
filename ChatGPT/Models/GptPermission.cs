﻿using System.Text.Json.Serialization;

namespace ChatGPT.Models
{
    public class GptPermission
    {
        public string Id { get; set; }
        public string Object { get; set; }
        public int Created { get; set; }

        [JsonPropertyName("allow_create_engine")]
        public bool AllowCreateEngine { get; set; }

        [JsonPropertyName("allow_sampling")]
        public bool AllowSampling { get; set; }

        [JsonPropertyName("allow_logprobs")]
        public bool AllowLogprobs { get; set; }

        [JsonPropertyName("allow_search_indices")]
        public bool AllowSearchIndices { get; set; }

        [JsonPropertyName("allow_view")]
        public bool AllowView { get; set; }

        [JsonPropertyName("allow_fine_tuning")]
        public bool AllowFineTuning { get; set; }
        public string Organization { get; set; }
        public object Group { get; set; }
        [JsonPropertyName("is_blocking")]
        public bool IsBlocking { get; set; }
    }
}
