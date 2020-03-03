﻿namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.ProPlayers;

    public class ProPlayerEndpoint : IProPlayerEndpoint
    {
        private readonly Requester requester;

        public ProPlayerEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <summary>
        /// Get list of pro players.
        /// </summary>
        /// <returns>List of pro players.</returns>
        public async Task<List<ProPlayer>> GetProPlayersAsync() =>
            await this.requester.GetResponseAsync<List<ProPlayer>>("proPlayers");
    }
}
