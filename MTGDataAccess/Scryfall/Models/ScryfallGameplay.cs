namespace MTGDataAccess.Scryfall.Models
{
    public class ScryfallGameplay
    {
        public ScryfallRelatedCard[]? All_Parts { get; set; }
        public ScryfallCardFace[]? Card_Faces { get; set; }
        public decimal? CMC { get; set; }
        public ScryfallColors? Color_Identity { get; set; }
        public ScryfallColors? Color_Indicator { get; set; }
        public ScryfallColors? Colors { get; set; }
        public string? Defense { get; set; }
        public int? EDHREC_Rank { get; set; }
        public string? Hand_Modifier { get; set; }
        public string? Loyalty { get; set; }
        public string? Mana_Cost { get; set; }
        public string? Name { get; set; }
        public string? Oracle_Text { get; set; }
        public int? Penny_Rank { get; set; }
        public string? Power { get; set; }
        public ScryfallColors? Produced_Mana { get; set; }
        public bool? Reserved { get; set; }
        public string? Toughness { get; set; }
        public string? Type_Line { get; set; }
     

        private ScryfallGameplay()
        {
            
        }

    }
}
