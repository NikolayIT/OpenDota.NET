﻿namespace OpenDotaDotNet.Endpoints
{
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    using OpenDotaDotNet.Models.Distributions;

    public class MmrDistributionEndpoint : IMmrDistributionEndpoint
    {
        private const string MmrDistribution = "distributions";

        private readonly Requester requester;

        public MmrDistributionEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <summary>
        /// Gets distributions of MMR data by bracket and country.
        /// </summary>
        /// <returns>Distributions of MMR data by bracket and country.</returns>
        public async Task<MmrDistribution> GetMmrDistributionAsync()
        {
            var response = await this.requester.GetRequestResponseMessageAsync(MmrDistribution);

            response.EnsureSuccessStatusCode();

            var mmrDistribution = JsonConvert.DeserializeObject<MmrDistribution>(await response.Content.ReadAsStringAsync());

            return mmrDistribution;
        }
    }
}
