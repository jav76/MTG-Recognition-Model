using RestSharp;
using System.Net;

namespace MTGDataAccess.Scryfall
{
    internal class ScryfallClient : RestClient
    {
        private RateMonitor _rateMonitor { get; }

        #region Init

        public ScryfallClient(RestClientOptions options)
            : base(options?.BaseUrl ?? throw new InvalidOperationException("No base API URL supplied"))
        {
            _rateMonitor = new RateMonitor();
            BuildDefaultHeaders();

        }

        public ScryfallClient() : base()
        {
            _rateMonitor = new RateMonitor();
            BuildDefaultHeaders();
        }

        #endregion

        #region Public Functions
        public new async Task<RestResponse> ExecuteAsync(RestRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (!_rateMonitor.CanRequest)
            {
                return new RestResponse
                {
                    StatusCode = HttpStatusCode.TooManyRequests,
                    ResponseStatus = ResponseStatus.Error,
                    ErrorMessage = "Rate limit exceeded. Please wait before making another request."
                };
            }
            else
            {
                _rateMonitor.AddRequest(request);
                return await base.ExecuteAsync(request, cancellationToken);
            }
        }

        public new async Task<Stream?> DownloadStreamAsync(RestRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (!_rateMonitor.CanRequest)
            {
                return null;
            }
            else
            {
                _rateMonitor.AddRequest(request);
                return await base.DownloadStreamAsync(request, cancellationToken);
            }
        }

        #endregion

        #region Private Methods

        private void BuildDefaultHeaders()
        {
            this.AddDefaultHeader("Content-Type", "application/json");
            this.AddDefaultHeader("Accept", "application/json");
        }

        #endregion

    }
}
