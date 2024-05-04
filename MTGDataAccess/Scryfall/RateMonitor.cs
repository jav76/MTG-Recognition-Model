using RestSharp;

namespace MTGDataAccess.Scryfall
{
    /// <summary>
    /// Intended to monitor the rate of API calls to Scryfall. The Scryfall API documentation recommends 50-100ms delay between calls.
    /// This class will monitor the rate of calls and enforce the delay.
    /// </summary>
    internal class RateMonitor
    {

        private const int REQUEST_DELAY_MS = 50;
        private List<KeyValuePair<RestRequest, DateTime>> _requests { get; } // TODO: How do we clean these up? How long do we keep track of request? Autoremove after a certain time?

        internal bool CanRequest
        {
            get
            {
                if (_requests.Count == 0)
                {
                    return true;
                }

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


    }
}
