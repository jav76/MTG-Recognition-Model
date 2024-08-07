﻿using MTGDataAccess.Scryfall.Models;
using MTGDataAccess.Scryfall.Models.APIModels;
using RestSharp;
using System.Net;

namespace MTGDataAccess.Scryfall
{
    /// <summary>
    /// The base class for accessing the Scryfall API.
    /// </summary>
    public class ScryfallAccess
    {
        private const string BASE_URL = "https://api.scryfall.com";
        private ScryfallClient _client { get; }

        public ScryfallAccess()
        {
            RestClientOptions options = new RestClientOptions
            {
                BaseUrl = new Uri(BASE_URL)
            };

            _client = new ScryfallClient(options);

#if DEBUG

            CardIDParameters testParams = new CardIDParameters(pretty:true);
            RestResponse? requestContent = GetCardContentByID("56ebc372-aabd-4174-a943-c7bf59e5028d", testParams);
            if (requestContent?.ContentType == ContentType.Json)
            {
                MTGCardBuilder cardBuilder = new MTGCardBuilder(requestContent.Content ?? string.Empty);
                ScryfallCard? builtCard = cardBuilder.BuildCard();
            }

#endif

        }

        public async Task<RestResponse> GetCardResponseByID(Guid id, CardIDParameters? parameters = null)
        {
            ScryfallRequest request = new ScryfallRequest(CardRequestTypeEnum.ScryfallID);

            ScryfallParameter<Guid> IDParameter = new ScryfallParameter<Guid>(ScryfallHelpers.IDParameters.Key, id);
            request.AddParameter(ScryfallParameter<Guid>.BuildParameter(IDParameter));
            if (parameters != null)
            {
                request.AddParameters(parameters);
            }

            return await _client.ExecuteAsync(request);
        }

        public async Task<RestResponse> GetCardResponseByID(string id, CardIDParameters? parameters = null)
        {
            ScryfallRequest request = new ScryfallRequest(CardRequestTypeEnum.ScryfallID);

            ScryfallParameter<Guid> IDParameter = new ScryfallParameter<Guid>(ScryfallHelpers.IDParameters.Key, Guid.Parse(id));
            request.AddParameter(ScryfallParameter<Guid>.BuildParameter(IDParameter));
            if (parameters != null)
            {
                request.AddParameters(parameters);
            }

            return await _client.ExecuteAsync(request);
        }

        public async Task<RestResponse> GetCardResponseBySearch(string query, CardSearchParameters? parameters = null)
        {
            ScryfallRequest request = new ScryfallRequest(CardRequestTypeEnum.Search);

            ScryfallParameter<string> queryParameter = new ScryfallParameter<string>(ScryfallHelpers.QueryParameters.Key, query);
            request.AddParameter(ScryfallParameter<string>.BuildParameter(queryParameter));
            if (parameters != null)
            {
                request.AddParameters(parameters);
            }

            return await _client.ExecuteAsync(request);
        }

        public RestResponse? GetCardContentByID(Guid id, CardIDParameters? paramters = null)
        {
            Task<RestResponse> cardResponse = GetCardResponseByID(id, paramters);
            if (cardResponse.Result.StatusCode != HttpStatusCode.OK)
            {
                return null;
            }

            return cardResponse.Result;
        }

        public RestResponse? GetCardContentByID(string id, CardIDParameters? parameters = null)
        {
            Task<RestResponse> cardResponse = GetCardResponseByID(id, parameters);
            if (cardResponse.Result.StatusCode != HttpStatusCode.OK)
            {
                return null;
            }

            return cardResponse.Result;
        }

        public RestResponse? GetCardContentBySearch(string query, CardSearchParameters? parameters = null)
        {
            Task<RestResponse> cardResponse = GetCardResponseBySearch(query, parameters);
            if (cardResponse.Result.StatusCode != HttpStatusCode.OK)
            {
                return null;
            }

            return cardResponse.Result;
        }

    }
}
