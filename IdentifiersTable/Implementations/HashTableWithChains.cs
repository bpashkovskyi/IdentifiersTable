namespace IdentifiersTable.Implementations
{
    public class HashTableWithChains : IIdentifiersTable
    {
        private readonly KeyValueWithChain[] _identifiers;

        public HashTableWithChains()
        {
            _identifiers = new KeyValueWithChain[HashFunctions.PossibleHashValues];
        }

        public void Add(string key, string value)
        {
            var index = HashFunctions.CalculateHash(key);

            int? previousIndex = null;

            while (_identifiers[index] != null)
            {
                previousIndex = index;
                index = (index + 1) % HashFunctions.PossibleHashValues;
            }

            _identifiers[index] = new KeyValueWithChain(new KeyValue(key, value));

            if (previousIndex != null)
            {
                _identifiers[previousIndex.Value].Chain = index;
            }
        }

        public string Get(string key)
        {
            var index = HashFunctions.CalculateHash(key);

            while (_identifiers[index].KeyValue.Key != key)
            {
                index = _identifiers[index].Chain.Value;
            }

            return _identifiers[index].KeyValue.Value;
        }
    }
}
