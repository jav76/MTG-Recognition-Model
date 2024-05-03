
using RestSharp;

namespace MTGDataAccess.Scryfall.Models
{
    internal class ScryfallParameter<TScryfallParameterValue>
    {
        public string? Name { get; }
        public TScryfallParameterValue Value { get; }

        public ScryfallParameter(string name, TScryfallParameterValue value)
        {
            Name = name;
            Value = value;
        }

        public static Parameter BuildParameter(ScryfallParameter<TScryfallParameterValue> parameter)
        {
            if (string.IsNullOrWhiteSpace(parameter.Name) || parameter.Value == null)
            {
                throw new InvalidOperationException("Parameter name and value must be set.");
            }

            string parameterName = parameter.Name;
            TScryfallParameterValue parameterValue = parameter.Value;

            Parameter restParameter = Parameter.CreateParameter(parameterName, parameterValue, ParameterType.HttpHeader);
            return restParameter;
        }


    }
}
