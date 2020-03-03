﻿namespace OpenDotaDotNet.Models.Players
{
    using System.Text.Json.Serialization;

    public class Player
    {
        [JsonPropertyName("tracked_until")]
        public string TrackedUntil { get; set; }

        [JsonPropertyName("solo_competitive_rank")]
        public string SoloCompetitiveRank { get; set; }

        [JsonPropertyName("competitive_rank")]
        public string CompetitiveRank { get; set; }

        [JsonPropertyName("rank_tier")]
        public int? RankTier { get; set; }

        [JsonPropertyName("leaderboard_rank")]
        public int? LeaderboardRank { get; set; }

        [JsonPropertyName("mmr_estimate")]
        public MmrEstimate MmrEstimate { get; set; }

        [JsonPropertyName("profile")]
        public Profile Profile { get; set; }
    }
}
