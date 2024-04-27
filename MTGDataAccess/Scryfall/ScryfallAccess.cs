using MTGDataAccess.Scryfall.Models;
using RestSharp;
using System.Diagnostics;

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

            RestResponse response = testAPI().Result;
            Debug.Write(response.Content);

#endif

        }

#if DEBUG

        private async Task<RestResponse> testAPI()
        {
            ScryfallParameter<Guid> IDParameter = new ScryfallParameter<Guid>("id", Guid.Parse("56ebc372-aabd-4174-a943-c7bf59e5028d"));

            ScryfallRequest request = new ScryfallRequest(CardRequestTypeEnum.ScryfallID);
            request.AddParameter(ScryfallParameter<Guid>.BuildParameter(IDParameter));
            return await _client.ExecuteAsync(request);
        }

#endif

    }
}
