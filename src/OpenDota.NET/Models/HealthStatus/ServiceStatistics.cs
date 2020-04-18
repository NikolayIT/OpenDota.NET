﻿namespace OpenDotaDotNet.Models.HealthStatus
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class ServiceStatistics
    {
        [JsonPropertyName("user_players")]
        public int UserPlayers { get; set; }

        [JsonPropertyName("tracked_players")]
        public int TrackedPlayers { get; set; }

        [JsonPropertyName("matches_last_day")]
        public int MatchesLastDay { get; set; }

        [JsonPropertyName("matches_last_hour")]
        public int MatchesLastHour { get; set; }

        [JsonPropertyName("retriever_matches_last_day")]
        public int RetrieverMatchesLastDay { get; set; }

        [JsonPropertyName("backup_retriever_last_day")]
        public int BackupRetrieverLastDay { get; set; }

        [JsonPropertyName("parsed_matches_last_day")]
        public int ParsedMatchesLastDay { get; set; }

        [JsonPropertyName("requests_last_day")]
        public int RequestsLastDay { get; set; }

        [JsonPropertyName("fullhistory_last_day")]
        public int FullHistoryLastDay { get; set; }

        [JsonPropertyName("webhooks_last_day")]
        public int WebHooksLastDay { get; set; }

        [JsonPropertyName("feed_last_day")]
        public int FeedLastDay { get; set; }

        [JsonPropertyName("api_hits_last_day")]
        public int ApiHitsLastDay { get; set; }

        [JsonPropertyName("api_hits_ui_last_day")]
        public int ApiHitsUiLastDay { get; set; }

        [JsonPropertyName("fhQueue")]
        public int FhQueue { get; set; }

        [JsonPropertyName("gcQueue")]
        public int GcQueue { get; set; }

        [JsonPropertyName("mmrQueue")]
        public int MmrQueue { get; set; }

        [JsonPropertyName("countsQueue")]
        public int CountsQueue { get; set; }

        [JsonPropertyName("scenariosQueue")]
        public int ScenariosQueue { get; set; }

        [JsonPropertyName("benchmarksQueue")]
        public int BenchmarksQueue { get; set; }

        [JsonPropertyName("retriever")]
        public IEnumerable<ApiPath> Retriever { get; set; }

        /// <summary>
        /// Gets or sets all available API paths.
        /// </summary>
        [JsonPropertyName("api_paths")]
        public IEnumerable<ApiPath> ApiPaths { get; set; }

        /// <summary>
        /// Gets or sets the last added matches.
        /// </summary>
        [JsonPropertyName("last_added")]
        public IEnumerable<Last> LastAddedMatches { get; set; }

        /// <summary>
        /// Gets or sets the last parsed matches.
        /// </summary>
        [JsonPropertyName("last_parsed")]
        public IEnumerable<Last> LastParsed { get; set; }

        /// <summary>
        /// Gets or sets the load times.
        /// </summary>
        [JsonPropertyName("load_times")]
        public IDictionary<string, long> LoadTimes { get; set; }

        /// <summary>
        /// Gets or sets the health.
        /// </summary>
        [JsonPropertyName("health")]
        public ServiceHealth Health { get; set; }
    }
}
