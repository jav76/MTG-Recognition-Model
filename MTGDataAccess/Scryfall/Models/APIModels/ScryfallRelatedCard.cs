namespace MTGDataAccess.Scryfall.Models
{
    public class ScryfallRelatedCard
    {

        public Guid? ID { get; set; }
        public string? @Object { get; set; }
        public string? Component { get; set; }
        public string? Name { get; set; }
        public string? Type_Line { get; set; }
        public Uri? URI { get; set; }

    }
}
