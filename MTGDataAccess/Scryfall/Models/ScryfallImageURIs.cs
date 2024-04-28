namespace MTGDataAccess.Scryfall.Models
{
    public class ScryfallImageURIs
    {
        public Uri? Small { get; set; }
        public Uri? Normal { get; set; }
        public Uri? Large { get; set; }
        public Uri? Art_Crop { get; set; }
        public Uri? Border_Crop { get; set; }
        public Uri? PNG { get; set; }

        private ScryfallImageURIs()
        {
            
        }
    }
}
