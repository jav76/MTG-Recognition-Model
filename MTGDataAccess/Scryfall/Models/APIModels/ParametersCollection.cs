using MTGDataAccess.Scryfall.Interfaces;

namespace MTGDataAccess.Scryfall.Models.APIModels
{
    public abstract class ParametersCollection : IParametersCollection
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

        public void AddParameter(object param)
        {
            if (param == null)
            {
                throw new ArgumentNullException("Parameter cannot be null.");
            }
            else if (!(param.GetType() == typeof(ScryfallParameter<>)))
            {
                throw new ArgumentException();
            }
            _parameters.Add(param);
        }
    }
}
