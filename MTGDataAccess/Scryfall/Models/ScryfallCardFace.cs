namespace MTGDataAccess.Scryfall.Models
{
    public class ScryfallCardFace
    {
        public string? Artist { get; set; }
        public Guid? Artist_ID { get; set; }
        public decimal? CMC { get; set; }
        public ScryfallColors? Color_Indicator { get; set; }
        public ScryfallColors? Colors { get; set; }
        public string? Defense { get; set; }
        public string? Flavor_Text { get; set; }
        public Guid? Illustration_ID { get; set; }
        public ScryfallImageURIs? Image_URIs { get; set; }
        public string? Layout { get; set; }
        public string? Loyalty { get; set; }
        public string? ManaCost { get; set; }
        public string? Name { get; set; }
        public string? @Object { get; set; }
        public Guid? Oracle_ID { get; set; }
        public string? Oracle_Text { get; set; }
        public string? Power { get; set; }
        public string? Printed_Name { get; set; }
        public string? Printed_Text { get; set; }
        public string? Printed_Type_Line { get; set; }
        public string? Toughness { get; set; }
        public string? Type_Line { get; set; }
        public string? Watermark { get; set; }

        private ScryfallCardFace()
        {
            
        }
    }
}
