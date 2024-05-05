namespace MTGDataAccess.Scryfall.Models.APIModels
{
    public class CardIDParameters : ParametersCollection
    {
        protected override CardRequestTypeEnum _requestType => CardRequestTypeEnum.ScryfallID;

        public CardIDParameters(string? format = null, string? face = null, string? version = null, bool? pretty = null)
        {
            if (!string.IsNullOrWhiteSpace(format))
            {
                AddFormatParameter(format);
                if (!string.IsNullOrWhiteSpace(face))
                {
                    AddFaceParameter(face, format);
                }
                if (!string.IsNullOrWhiteSpace(version))
                {
                    AddVersionParameter(version, format);
                }
            }
 
            if (pretty.HasValue)
            {
                AddPrettyParameter(pretty.Value, format ?? "json");
            }
        }

        private void AddFormatParameter(string format)
        {
            if (!ScryfallHelpers.FormatParameters.Value.Where(x => string.Compare(x, format) == 0).Any())
            {
                throw new ArgumentException($"Invalid {nameof(ScryfallHelpers.FormatParameters.Key)} : {format}");
            }

            _parameters.Add(new ScryfallParameter<string>(ScryfallHelpers.FormatParameters.Key, format));
        }

        private void AddFaceParameter(string face, string format)
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

        private void AddVersionParameter(string version, string format)
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

        private void AddPrettyParameter(bool pretty, string format)
        {
            if (string.IsNullOrWhiteSpace(format) || format != "json")
            {
                throw new ArgumentException($"{nameof(ScryfallHelpers.PrettyParameters.Key)} parameter can only be used with the json {nameof(ScryfallHelpers.FormatParameters.Key)}.");
            }

            _parameters.Add(new ScryfallParameter<bool>(ScryfallHelpers.PrettyParameters.Key, pretty));
        }

    }
}
