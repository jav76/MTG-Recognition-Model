namespace MTGDataAccess.Scryfall.Models
{
    public class ScryfallCardCore
    {
        public int? Arena_ID { get; set; }
        public Guid ID { get; set; }
        public string Lang { get; set; }
        public int? MTGO_ID { get; set; }
        public int? MTGO_Foil_ID { get; set; }
        public int[] Multiverse_IDs { get; set; }
        public int? TCGPlayer_ID { get; set; }
        public int? TCGPlayer_Etched_ID { get; set; }
        public string @Object { get; set; }
        public string Layout { get; set; }
        public Guid? Oracle_ID { get; set; }
        public Uri Prints_Search_URI { get; set; }
        public Uri Rulings_URI { get; set; }
        public Uri Scryfall_URI { get; set; }
        public Uri URI { get; set; }

        public ScryfallGameplay? GameplayFields { get; set; }

        public ScryfallPrint? PrintFields { get; set; }

        public ScryfallCardFace? CardFaceFields { get; set; }

        private ScryfallCardCore()
        {

        }



    }
}
