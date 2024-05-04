namespace MTGDataAccess.Scryfall.Interfaces
{
    internal interface IParametersCollection
    {
        public IEnumerable<object> Parameters { get; }
        internal void AddParameter(object param);
    }
}
