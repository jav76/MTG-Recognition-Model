namespace MTGDataAccess.Scryfall.Models
{
    public class ScryfallColors
    {
        public readonly Dictionary<char, string> ColorMappings = new Dictionary<char, string>
        {
            { 'W', "White" },
            { 'U', "Blue" },
            { 'B', "Black" },
            { 'R', "Red" },
            { 'G', "Green" }
        };

        public char[] Colors { get; set; }

        private ScryfallColors()
        {
            
        }
    }
}
