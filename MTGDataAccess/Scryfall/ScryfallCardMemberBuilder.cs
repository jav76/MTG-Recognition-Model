using MTGDataAccess.Scryfall.Models;
using Newtonsoft.Json;

namespace MTGDataAccess.Scryfall
{
    internal static class ScryfallCardMemberBuilder<ScryfallCardMember>
    {
        public static ScryfallCardMember? BuildMember(string? JSON)
        {
            return JsonConvert.DeserializeObject<ScryfallCardMember>(JSON ?? string.Empty) ?? default(ScryfallCardMember);
        }

        public static IEnumerable<ScryfallCardMember>? BuildArrayMember(string? JSON)
        {
            return JsonConvert.DeserializeObject<IEnumerable<ScryfallCardMember>>(JSON ?? string.Empty);
        }
    }
}
