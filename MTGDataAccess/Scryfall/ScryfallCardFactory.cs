using MTGDataAccess.Scryfall.Models;
using Newtonsoft.Json;

namespace MTGDataAccess.Scryfall
{
    internal class ScryfallCardFactory
    {
        private string _cardResponseContent { get; }

        public ScryfallCardFactory(string cardResponseContent)
        {
            _cardResponseContent = cardResponseContent;
        }

        public ScryfallCard? BuildCard()
        {
            ScryfallCard? newCard = JsonConvert.DeserializeObject<ScryfallCard>(_cardResponseContent);
            if (newCard == null)
            {
                return null;
            }

            newCard.Card = BuildCardCore();
            newCard.Gameplay = BuildGameplay();
            newCard.Print = BuildPrint();
            newCard.CardFace = BuildCardFace();
            return newCard;
        }

        private ScryfallCardCore? BuildCardCore()
        {
            ScryfallCardCore? cardCore = JsonConvert.DeserializeObject<ScryfallCardCore>(_cardResponseContent);
            return cardCore;
        }

        private ScryfallGameplay? BuildGameplay()
        {
            ScryfallGameplay? gameplay = JsonConvert.DeserializeObject<ScryfallGameplay>(_cardResponseContent);
            return gameplay;
        }

        private ScryfallPrint? BuildPrint()
        {
            ScryfallPrint? print = JsonConvert.DeserializeObject<ScryfallPrint>(_cardResponseContent);
            return print;
        }

        private ScryfallCardFace? BuildCardFace()
        {
            ScryfallCardFace? cardFace = JsonConvert.DeserializeObject<ScryfallCardFace>(_cardResponseContent);
            return cardFace;
        }
    }
}
