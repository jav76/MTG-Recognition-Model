﻿using MTGDataAccess.Scryfall.Models;
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
        /// I am considering wrapping the ScryfallCard around an MTGCard object that's more
        /// abstracted and structured, but as of right now I don't think that's necessary.
        /// </summary>
        /// <returns>The built ScryfallCard object</returns>
        internal ScryfallCard? BuildCard()
        {
            ScryfallCard? newCard = JsonConvert.DeserializeObject<ScryfallCard>(_cardResponseContent ?? string.Empty);
            
            return newCard;
        }
    }
}
