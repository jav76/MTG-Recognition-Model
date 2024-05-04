namespace MTGDataAccess.Scryfall.Models
{
    public class ScryfallCard
    {

        #region " Card Core "

        public int? Arena_ID { get; set; }
        public Guid? ID { get; set; }
        public string? Lang { get; set; }
        public int? MTGO_ID { get; set; }
        public int? MTGO_Foil_ID { get; set; }
        public int[]? Multiverse_IDs { get; set; }
        public int? TCGPlayer_ID { get; set; }
        public int? TCGPlayer_Etched_ID { get; set; }
        public int? Cardmarket_ID { get; set; }
        public string? @Object { get; set; }
        public string? Layout { get; set; }
        public Guid? Oracle_ID { get; set; }
        public Uri? Prints_Search_URI { get; set; }
        public Uri? Rulings_URI { get; set; }
        public Uri? Scryfall_URI { get; set; }
        public Uri? URI { get; set; }

        #endregion

        #region " Gameplay "

        public List<ScryfallRelatedCard>? All_Parts { get; set; }
        public List<ScryfallCardFace>? Card_Faces { get; set; }
        public decimal? CMC { get; set; }
        public char[]? Color_Identity { get; set; }
        public char[]? Color_Indicator { get; set; }
        public char[]? Colors { get; set; }
        public string? Defense { get; set; }
        public int? EDHREC_Rank { get; set; }
        public string? Hand_Modifier { get; set; }
        public string[]? Keywords { get; set; }
        public ScryfallLegalities? Legalities { get; set; }
        public string? Life_Modifier { get; set; }
        public string? Loyalty { get; set; }
        public string? Mana_Cost { get; set; }
        public string? Name { get; set; }
        public string? Oracle_Text { get; set; }
        public int? Penny_Rank { get; set; }
        public string? Power { get; set; }
        public char[]? Produced_Mana { get; set; }
        public bool? Reserved { get; set; }
        public string? Toughness { get; set; }
        public string? Type_Line { get; set; }

        #endregion

        #region " Print "

        public string? Artist { get; set; }
        public string[]? Artist_IDs { get; set; }
        public bool? Booster { get; set; }
        public string? Border_Color { get; set; }
        public Guid? Card_Back_ID { get; set; }
        public string? Collector_Number { get; set; }
        public bool? Content_Warning { get; set; }
        public bool? Digital { get; set; }
        public string[]? Finishes { get; set; }
        public string? Flavor_Name { get; set; }
        public string? Flavor_Text { get; set; }
        public string[]? Frame_Effects { get; set; }
        public string? Frame { get; set; }
        public bool? Full_Art { get; set; }
        public string[]? Games { get; set; }
        public bool? HighRes_Image { get; set; }
        public Guid? Illustration_ID { get; set; }
        public string? Image_Status { get; set; }
        public ScryfallImageURIs? Image_URIs { get; set; }
        public bool? Oversized { get; set; }
        public ScryfallPrices? Prices { get; set; }
        public string? Printed_Name { get; set; }
        public string? Printed_Text { get; set; }
        public string? Printed_Type_Line { get; set; }
        public bool? Promo { get; set; }
        public string[]? Promo_Types { get; set; }
        public ScryfallPurchaseURIs? Purchase_URIs { get; set; }
        public string? Rarity { get; set; }
        public ScryfallRelatedURIs? Related_URIs { get; set; }
        public DateTime? Release_At { get; set; }
        public bool? Reprint { get; set; }
        public Uri? Scryfall_Set_URI { get; set; }
        public string? Set_Name { get; set; }
        public Uri? Set_Search_URI { get; set; }
        public string? Set_Type { get; set; }
        public Uri? Set_URI { get; set; }
        public string? Set { get; set; }
        public Guid? Set_ID { get; set; }
        public bool? Story_Spotlight { get; set; }
        public bool? Textless { get; set; }
        public bool? Variation { get; set; }
        public Guid? Variation_Of { get; set; }
        public string? Security_Stamp { get; set; }
        public string? Watermark { get; set; }

        #endregion

        public List<ScryfallCardFace>? CardFaces { get; set; }

        public ScryfallCard()
        {
            
        }
    }
}
