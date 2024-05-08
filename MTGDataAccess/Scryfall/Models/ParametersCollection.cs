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

        protected void AddFormatParameter(string format)
        {
            if (!ScryfallHelpers.FormatParameters.Value.Where(x => string.Compare(x, format) == 0).Any())
            {
                throw new ArgumentException($"Invalid {nameof(ScryfallHelpers.FormatParameters.Key)} : {format}");
            }

            _parameters.Add(new ScryfallParameter<string>(ScryfallHelpers.FormatParameters.Key, format));
        }

        protected void AddFaceParameter(string face, string format)
        {
            if (format != "image")
            {
                throw new ArgumentException($"{nameof(ScryfallHelpers.FaceParameters.Key)} parameter can only be used with the image {nameof(ScryfallHelpers.FormatParameters.Key)}.");
            }

            if (ScryfallHelpers.FaceParameters.Value.Where(x => string.Compare(x, face) == 0).Any())
            {
                throw new ArgumentException($"Invalid {nameof(ScryfallHelpers.FaceParameters.Key)} : {face}");
            }

            _parameters.Add(new ScryfallParameter<string>(ScryfallHelpers.FaceParameters.Key, face));
        }

        protected void AddVersionParameter(string version, string format)
        {
            if (format != "image")
            {
                throw new ArgumentException($"{nameof(ScryfallHelpers.VersionParameters.Key)} parameter can only be used with the image {nameof(ScryfallHelpers.FormatParameters.Key)}.");
            }

            if (ScryfallHelpers.VersionParameters.Value.Where(x => string.Compare(x, version) == 0).Any())
            {
                throw new ArgumentException($"Invalid {nameof(ScryfallHelpers.VersionParameters.Key)} : {version}");
            }

            _parameters.Add(new ScryfallParameter<string>(ScryfallHelpers.VersionParameters.Key, version));
        }

        protected void AddPrettyParameter(bool pretty, string format)
        {
            if (string.IsNullOrWhiteSpace(format) || format != "json")
            {
                throw new ArgumentException($"{nameof(ScryfallHelpers.PrettyParameters.Key)} parameter can only be used with the json {nameof(ScryfallHelpers.FormatParameters.Key)}.");
            }

            _parameters.Add(new ScryfallParameter<bool>(ScryfallHelpers.PrettyParameters.Key, pretty));
        }

        protected void AddUniqueParameter(string unique)
        {
            if (ScryfallHelpers.UniqueParameters.Value.Where(x => string.Compare(x, unique) == 0).Any())
            {
                throw new ArgumentException($"Invalid {nameof(ScryfallHelpers.UniqueParameters.Key)} : {unique}");
            }

            _parameters.Add(new ScryfallParameter<string>(ScryfallHelpers.UniqueParameters.Key, unique));
        }   

        protected void AddOrderParameter(string order)
        {
            if (ScryfallHelpers.OrderParameters.Value.Where(x => string.Compare(x, order) == 0).Any())
            {
                throw new ArgumentException($"Invalid {nameof(ScryfallHelpers.OrderParameters.Key)} : {order}");
            }

            _parameters.Add(new ScryfallParameter<string>(ScryfallHelpers.OrderParameters.Key, order));
        }

        protected void AddDirParameter(string dir)
        {
            if (ScryfallHelpers.DirParameters.Value.Where(x => string.Compare(x, dir) == 0).Any())
            {
                throw new ArgumentException($"Invalid {nameof(ScryfallHelpers.DirParameters.Key)} : {dir}");
            }

            _parameters.Add(new ScryfallParameter<string>(ScryfallHelpers.DirParameters.Key, dir));
        }

        protected void AddIncludeExtrasParameter(bool includeExtras)
        {
            _parameters.Add(new ScryfallParameter<bool>(ScryfallHelpers.IncludeExtrasParameters.Key, includeExtras));
        }

        protected void AddIncludeMultilingualParameter(bool includeMultilingual)
        {
            _parameters.Add(new ScryfallParameter<bool>(ScryfallHelpers.IncludeMultilingualParameters.Key, includeMultilingual));
        }

        protected void AddIncludeVariationsParameter(bool includeVariations)
        {
            _parameters.Add(new ScryfallParameter<bool>(ScryfallHelpers.IncludeVariationsParameters.Key, includeVariations));
        }

        protected void AddPageParameter(int page)
        {
            _parameters.Add(new ScryfallParameter<int>(ScryfallHelpers.PageParameters.Key, page));
        }
    }
}
