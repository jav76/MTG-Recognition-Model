namespace MTGDataAccess.Scryfall
{
    internal static class ScryfallHelpers
    {
        #region Parameters

        public static readonly KeyValuePair<string, IEnumerable<Guid>?> IDParameters = new KeyValuePair<string, IEnumerable<Guid>?>
            ("id", null);
        public static readonly KeyValuePair<string, IEnumerable<string>> FormatParameters = new KeyValuePair<string, IEnumerable<string>>
            ("format", new List<string> { "json", "text", "image" });
        public static readonly KeyValuePair<string, IEnumerable<string>> FaceParameters = new KeyValuePair<string, IEnumerable<string>>
            ("face", new List<string> { "front", "back" });
        public static readonly KeyValuePair<string, IEnumerable<string>> VersionParameters = new KeyValuePair<string, IEnumerable<string>>
            ("version", new List<string> { "small", "normal", "large", "png", "art_crop", "border_crop" });
        public static readonly KeyValuePair<string, IEnumerable<bool>?> PrettyParameters = new KeyValuePair<string, IEnumerable<bool>?>
            ("pretty", null);
        public static readonly KeyValuePair<string, IEnumerable<string>?> QueryParameters = new KeyValuePair<string, IEnumerable<string>?>
            ("q", null);
        public static readonly KeyValuePair<string, IEnumerable<string>> UniqueParameters = new KeyValuePair<string, IEnumerable<string>>
            ("unique", new List<string> { "cards", "art", "prints" });
        public static readonly KeyValuePair<string, IEnumerable<string>> OrderParameters = new KeyValuePair<string, IEnumerable<string>>
            ("order", new List<string>
                { 
                    "name",
                    "set",
                    "released",
                    "rarity",
                    "color",
                    "usd",
                    "tix",
                    "eur",
                    "cmc",
                    "power",
                    "toughness",
                    "edhrec",
                    "penny",
                    "artist",
                    "review"
                });
        public static readonly KeyValuePair<string, IEnumerable<string>> DirParameters = new KeyValuePair<string, IEnumerable<string>>
            ("dir", new List<string> { "auto", "asc", "desc" });
        public static readonly KeyValuePair<string, IEnumerable<bool>?> IncludeExtrasParameters = new KeyValuePair<string, IEnumerable<bool>?>
            ("include_extras", null);
        public static readonly KeyValuePair<string, IEnumerable<bool>?> IncludeMultilingualParameters = new KeyValuePair<string, IEnumerable<bool>?>
            ("include_multilingual", null);
        public static readonly KeyValuePair<string, IEnumerable<bool>?> IncludeVariationsParameters = new KeyValuePair<string, IEnumerable<bool>?>
            ("include_variations", null);
        public static readonly KeyValuePair<string, IEnumerable<int>?> PageParameters = new KeyValuePair<string, IEnumerable<int>?>
            ("page", null);

        #endregion

        public static readonly Dictionary<char, string> ColorMappings = new Dictionary<char, string>
        {
            { 'W', "White" },
            { 'U', "Blue" },
            { 'B', "Black" },
            { 'R', "Red" },
            { 'G', "Green" }
        };

        public static readonly List<string> ColorFields = new List<string>
        {
            "color_identity",
            "color_indicator",
            "colors",
            "produced_mana"
        };

        public enum ColorsEnum
        {
            White,
            Blue,
            Black,
            Red,
            Green
        }

    }
}
