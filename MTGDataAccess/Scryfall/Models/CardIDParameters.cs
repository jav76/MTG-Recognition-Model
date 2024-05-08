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

    }
}
