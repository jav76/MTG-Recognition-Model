using MTGDataAccess.Scryfall.Models;
using MTGDataAccess.Scryfall.Models.APIModels;
using RestSharp;
using Parameter = RestSharp.Parameter;

namespace MTGDataAccess.Scryfall
{
    internal class ScryfallRequest : RestRequest
    {
        private CardRequestTypeEnum _requestType { get; }

        public ScryfallRequest(CardRequestTypeEnum requestType) : base()
        {
            _requestType = requestType;
            Resource = GetResourceFromRequestType(_requestType) ?? string.Empty;
        }
        public ScryfallRequest(CardRequestTypeEnum requestType, string? resource) : base(resource)
        {
            _requestType = requestType;
        }

        public ScryfallRequest(CardRequestTypeEnum requestType, string? resource, Method method) : base(resource, method)
        {
            _requestType = requestType;
        }

        private string? GetResourceFromRequestType(CardRequestTypeEnum requestType)
        {
            switch (requestType)
            {
                case CardRequestTypeEnum.Search:
                    return "/cards/search";
                case CardRequestTypeEnum.Named:
                    return "/cards/named";
                case CardRequestTypeEnum.Autocomplete:
                    return "/cards/autocomplete";
                case CardRequestTypeEnum.Random:
                    return "/cards/random";
                case CardRequestTypeEnum.Collection:
                    return "/cards/collection";
                case CardRequestTypeEnum.SetCodeCollectorNumber:
                    return "/cards/{set}/{collector_number}";
                case CardRequestTypeEnum.MultiverseID:
                    return "/cards/multiverse/{id}";
                case CardRequestTypeEnum.MTGOID:
                    return "/cards/mtgo/{id}";
                case CardRequestTypeEnum.ArenaID:
                    return "/cards/arena/{id}";
                case CardRequestTypeEnum.TCGPlayerID:
                    return "/cards/tcgplayer/{id}";
                case CardRequestTypeEnum.CardMarketID:
                    return "/cards/cardmarket/{id}";
                case CardRequestTypeEnum.ScryfallID:
                    return "/cards/{id}";
            }   

            return string.Empty;
        }

        public new RestRequest AddParameter(Parameter parameter)
        {
            base.AddParameter(parameter);
            InjectResourceParameters();
            return this;
        }

        public RestRequest AddParameters(CardIDParameters parameter)
        {
            foreach (object param in parameter.Parameters)
            {
                if (param.GetType() == typeof(ScryfallParameter<string>))
                {
                    ScryfallParameter<string> typedParam = (ScryfallParameter<string>)param;
                    AddParameter(ScryfallParameter<string>.BuildParameter(typedParam));
                }
                else if (param.GetType() == typeof(ScryfallParameter<bool>))
                {
                    ScryfallParameter<bool> typedParam = (ScryfallParameter<bool>)param;
                    AddParameter(ScryfallParameter<bool>.BuildParameter(typedParam));
                }
                else
                {
                    throw new ArgumentException($"Invalid parameter type: {param.GetType()}");
                }
            }
            InjectResourceParameters();
            return this;
        }   

        private void InjectResourceParameters()
        {
            string paramsString = string.Empty;
            foreach (Parameter param in Parameters)
            {
                if (string.IsNullOrWhiteSpace(param.Name) || param.Value == null)
                {
                    throw new InvalidOperationException("Parameter name and value must be set.");
                }
                // Replace path parameters in the resource string
                if (Resource.Contains(param.Name))
                {
                    string resourceParameter = "{" + param.Name + "}";
                    Resource = Resource.Replace(resourceParameter, param.Value.ToString());
                }
                // At this point, we assume these are query string parameters
                else
                {
                    if (string.IsNullOrWhiteSpace(paramsString))
                    {
                        paramsString += "?";
                    }
                    else
                    {
                        paramsString += "&";
                    }
                    paramsString += param.Name + "=" + param.Value;
                }
            }
            Resource += paramsString;
        }

    }


}
