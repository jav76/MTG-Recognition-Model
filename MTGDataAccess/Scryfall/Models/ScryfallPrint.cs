namespace MTGDataAccess.Scryfall.Models
{
    public class ScryfallPrint
    {
        public string? Artist { get; set; }
        public string[] Artist_IDs { get; set; }
        public bool Booster { get; set; }
        public string Border_Color { get; set; }
        public Guid Card_Back_ID { get; set; }
        public string Collector_Number { get; set; }
        public bool? Content_Warning { get; set; }
        public bool Digital { get; set; }
        public string[] Finishes { get; set; }
        public string? Flavor_Name { get; set; }
        public string? Flavor_Text { get; set; }
        public string[] Frame_Effects { get; set; }
        public string Frame { get; set; }
        public bool Full_Art { get; set; }
        public string[] Games { get; set; }
        public bool HighRes_Image { get; set; }
        public Guid? Illustration_ID { get; set; }
        public string Image_Status { get; set; }
        public ScryfallImageURIs? Image_URIs { get; set; }
        public bool Oversized { get; set; }
        public ScryfallPrices? Prices { get; set; }
        public string? Printed_Name { get; set; }
        public string? Printed_Text { get; set; }
        public string? Printed_Type_Line { get; set; }
        public bool Promo { get; set; }
        public string[] Promo_Types { get; set; }
        public ScryfallImageURIs? Purchase_URIs { get; set; }
        public string Rarity { get; set; }
        public ScryfallRelatedURIs? Related_URIs { get; set; }
        public DateTime Release_At { get; set; }
        public bool Reprint { get; set; }
        public Uri? Scryfall_Set_URI { get; set; }
        public string Set_Name { get; set; }
        public Uri? Set_Search_URI { get; set; }
        public string Set_Type { get; set; }
        public Uri? Set_URI { get; set; }
        public string Set { get; set; }
        public Guid Set_ID { get; set; }
        public bool Story_Spotlight { get; set; }
        public bool Textless { get; set; }
        public bool Variation { get; set; }
        public Guid? Variation_Of { get; set; }
        public string? Security_Stamp { get; set; }
        public string? Watermark { get; set; }
        public ScryfallPreview? Preview { get; set; }

        private ScryfallPrint()
        {
            
        }
    }
}
