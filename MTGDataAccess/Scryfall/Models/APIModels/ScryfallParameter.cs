
using RestSharp;

namespace MTGDataAccess.Scryfall.Models
{
    internal class ScryfallParameter<TScryfallParameterValue>
    {

        internal string? Name { get; }
        internal TScryfallParameterValue Value { get; }

        internal ScryfallParameter(string name, TScryfallParameterValue value)
        {
            Name = name;
            Value = value;
        }

        internal static Parameter BuildParameter(ScryfallParameter<TScryfallParameterValue> parameter)
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
