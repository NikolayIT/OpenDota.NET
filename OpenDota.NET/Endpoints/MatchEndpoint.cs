﻿namespace OpenDotaDotNet.Endpoints
{
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    using OpenDotaDotNet.Models.Matches;

    public class MatchEndpoint : IMatchEndpoint
    {
        private const string MatchByIdUrl = "matches/{0}";

        private readonly Requester requester;

        public MatchEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        public async Task<Match> GetMatchByIdAsync(long matchId)
        {
            var response = await this.requester.GetRequestResponseMessageAsync(string.Format(MatchByIdUrl, matchId));

            response.EnsureSuccessStatusCode();

            var matchInfo = JsonConvert.DeserializeObject<Match>(await response.Content.ReadAsStringAsync());

            return matchInfo;
        }
    }
}
