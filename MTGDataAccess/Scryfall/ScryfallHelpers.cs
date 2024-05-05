namespace MTGDataAccess.Scryfall
{
    internal static class ScryfallHelpers
    {

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
