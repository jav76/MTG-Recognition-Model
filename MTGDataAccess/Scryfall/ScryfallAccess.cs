using MTGDataAccess.Scryfall.Models;
using MTGDataAccess.Scryfall.Models.APIModels;
using RestSharp;
using System.Net;

namespace MTGDataAccess.Scryfall
{
    /// <summary>
    /// This project should be used for all raw data access. This should include API calls, file storage, database access, etc.
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

            ScryfallParameter<Guid> IDParameter = new ScryfallParameter<Guid>("id", id);
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

            ScryfallParameter<Guid> IDParameter = new ScryfallParameter<Guid>("id", Guid.Parse(id));
            request.AddParameter(ScryfallParameter<Guid>.BuildParameter(IDParameter));
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

        public async Task<RestResponse> GetCardResponseBySearch()
        {
            throw new NotImplementedException();
        }

    }
}
