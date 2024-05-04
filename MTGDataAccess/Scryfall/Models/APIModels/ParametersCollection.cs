namespace MTGDataAccess.Scryfall.Models.APIModels
{
    public abstract class ParametersCollection
    {
        protected List<object> _parameters { get; } = new List<object>();
        protected abstract CardRequestTypeEnum _requestType { get; }
        public CardRequestTypeEnum RequestType { get { return _requestType; } }
        public IEnumerable<object> Parameters
        {
            get
            {
                return _parameters;
            }
        }

    }
}
