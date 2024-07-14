using RestSharp;

namespace MTGDataAccess.Scryfall
{
    /// <summary>
    /// Intended to monitor the rate of API calls to Scryfall. The Scryfall API documentation recommends 50-100ms delay between calls.
    /// This class will monitor the rate of calls and enforce the delay.
    /// </summary>
    /// <remarks>The currently enforced request delay is <see cref="REQUEST_DELAY_MS"/></remarks>
    internal class RateMonitor
    {

        private const int REQUEST_DELAY_MS = 50;
        private List<KeyValuePair<RestRequest, DateTime>> _requests { get; }

        internal bool CanRequest
        {
            get
            {
                if (_requests.Count == 0)
                {
                    return true;
                }

                FlushRequests();
                var lastRequest = _requests.OrderBy(x => x.Value).Last();
                var timeSinceLastRequest = DateTime.Now - lastRequest.Value;
                return timeSinceLastRequest.TotalMilliseconds >= REQUEST_DELAY_MS;
            }
        }

        internal RateMonitor()
        {
            _requests = new List<KeyValuePair<RestRequest, DateTime>>();
        }

        internal void AddRequest(RestRequest request)
        {
            _requests.Add(new KeyValuePair<RestRequest, DateTime>(request, DateTime.Now));
        }

        private void FlushRequests()
        {
            _requests.Where(x => DateTime.Now - x.Value > TimeSpan.FromMilliseconds(REQUEST_DELAY_MS))
                .ToList()
                .ForEach(x => _requests.Remove(x));
        }
    }
}
