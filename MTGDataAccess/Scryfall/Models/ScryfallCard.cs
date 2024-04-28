namespace MTGDataAccess.Scryfall.Models
{
    public class ScryfallCard
    {
        public ScryfallCardCore? Card { get; set; }
        public ScryfallGameplay? Gameplay { get; set; }
        public ScryfallPrint? Print { get; set; }
        public ScryfallCardFace? CardFace { get; set; }

        private ScryfallCard()
        {
            
        }
    }
}
