using MTGDataAccess.Scryfall.Models;
using Newtonsoft.Json;

namespace MTGDataAccess.Scryfall
{
    internal class MTGCardBuilder
    {
        private string? _cardResponseContent { get; }

        internal MTGCardBuilder(string? cardResponseContent)
        {
            _cardResponseContent = cardResponseContent;
        }

        /// <summary>
        /// Builds a ScryfallCard object from the response content.
        /// </summary>
        /// <returns>A <see cref="ScryfallCard?"/> created from the <see cref="_cardResponseContent"/></returns>
        internal ScryfallCard? BuildCard()
        {
            ScryfallCard? newCard = JsonConvert.DeserializeObject<ScryfallCard>(_cardResponseContent ?? string.Empty);
            
            return newCard;
        }
    }
}
