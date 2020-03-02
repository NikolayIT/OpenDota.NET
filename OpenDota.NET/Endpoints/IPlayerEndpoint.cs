﻿namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.Players;

    public interface IPlayerEndpoint
    {
        Task<Player> GetPlayerByIdAsync(long playerId);

        Task<PlayerWinLoss> GetPlayerWinLossByIdAsync(long playerId, PlayerEndpointParameters parameters = null);

        Task<List<PlayerRecentMatch>> GetPlayerRecentMatchesAsync(long playerId);

        Task<List<PlayerMatch>> GetPlayerMatchesAsync(long playerId, PlayerEndpointParameters parameters = null);

        Task<List<PlayerHero>> GetPlayerHeroesAsync(long playerId, PlayerEndpointParameters parameters = null);

        Task<List<PlayerPeer>> GetPlayerPeersAsync(long playerId, PlayerEndpointParameters parameters = null);

        Task<List<PlayerPro>> GetPlayerProsAsync(long playerId, PlayerEndpointParameters parameters = null);

        Task<List<PlayerTotal>> GetPlayerTotalsAsync(long playerId, PlayerEndpointParameters parameters = null);

        Task<PlayerCount> GetPlayerCountsAsync(long playerId, PlayerEndpointParameters parameters = null);

        Task<List<PlayerHistogram>> GetPlayerHistogramsAsync(long playerId, string field, PlayerEndpointParameters parameters = null);

        Task<PlayerWardmap> GetPlayerWardMapAsync(long playerId, PlayerEndpointParameters parameters = null);

        Task<PlayerWordcloud> GetPlayerWordCloudAsync(long playerId, PlayerEndpointParameters parameters = null);

        Task<List<PlayerRating>> GetPlayerRatingsAsync(long playerId);

        Task<List<PlayerHeroRanking>> GetPlayerHeroRankingsAsync(long playerId);

        Task<bool> RefreshPlayerMatchHistoryAsync(long playerId);
    }
}
