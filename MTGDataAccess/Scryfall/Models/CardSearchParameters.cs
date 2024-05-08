using MTGDataAccess.Scryfall.Models.APIModels;

namespace MTGDataAccess.Scryfall.Models
{
    public class CardSearchParameters : ParametersCollection
    {
        protected override CardRequestTypeEnum _requestType => CardRequestTypeEnum.Search;

        public CardSearchParameters(string? unique = null, string? order = null, string? dir = null, bool? includeExtras = null,
            bool? includeMultilingual = null, bool? includeVariations = null, int? page = null, string? format = null, bool? pretty = null)
        {

            if (!string.IsNullOrWhiteSpace(unique))
            {
                AddUniqueParameter(unique);
            }

            if (!string.IsNullOrWhiteSpace(order))
            {
                AddOrderParameter(order);
            }

            if (!string.IsNullOrWhiteSpace(dir))
            {
                AddDirParameter(dir);
            }

            if (includeExtras.HasValue)
            {
                AddIncludeExtrasParameter(includeExtras.Value);
            }

            if (includeMultilingual.HasValue)
            {
                AddIncludeMultilingualParameter(includeMultilingual.Value);
            }

            if (includeVariations.HasValue)
            {
                AddIncludeVariationsParameter(includeVariations.Value);
            }

            if (page.HasValue)
            {
                AddPageParameter(page.Value);
            }
            
            if (!string.IsNullOrWhiteSpace(format))
            {
                AddFormatParameter(format);
            }

            if (pretty.HasValue)
            {
                AddPrettyParameter(pretty.Value, format ?? "json");
            }

        }
    }
}
