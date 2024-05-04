namespace MTGDataAccess.Scryfall.Interfaces
{
    internal interface IParametersCollection
    {
        IEnumerable<object> Parameters { get; }
        void AddParameter(object param);
    }
}
