namespace MTGDataAccess.Scryfall.Models.APIModels
{
    public class CardIDParameters : ParametersCollection
    {
        protected override CardRequestTypeEnum _requestType => CardRequestTypeEnum.ScryfallID;

        public CardIDParameters(string? format = null, string? face = null, string? version = null, bool? pretty = null)
        {
            if (!string.IsNullOrWhiteSpace(format))
            {
                _parameters.Add(new ScryfallParameter<string>("format", format));
            }
            if (!string.IsNullOrWhiteSpace(face))
            {
                _parameters.Add(new ScryfallParameter<string>("face", face));
            }
            if (!string.IsNullOrWhiteSpace(version))
            {
                _parameters.Add(new ScryfallParameter<string>("version", version));
            }
            if (pretty.HasValue)
            {
                if (_parameters.Where(x =>
                    x.GetType() == typeof(ScryfallParameter<string>) 
                    && ((ScryfallParameter<string>)x).Name == "format"
                    && ((ScryfallParameter<string>)x).Value != "json").Any())
                {
                    throw new ArgumentException($"{nameof(pretty)} parameter can only be used with the json format.");
                }
                _parameters.Add(new ScryfallParameter<bool>("pretty", pretty.Value));
            }
        }

        internal void AddParameter(object param)
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
