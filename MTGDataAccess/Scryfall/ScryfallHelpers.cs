namespace MTGDataAccess.Scryfall
{
    internal static class ScryfallHelpers
    {

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
