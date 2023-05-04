namespace IdentifiersTable.Implementations
{
    public class HashTableWithRehashing : IIdentifiersTable
    {
        private readonly KeyValue[] _identifiers;

        public HashTableWithRehashing()
        {
            _identifiers = new KeyValue[HashFunctions.PossibleHashValues];
        }

        public void Add(string key, string value)
        {
            var hash = HashFunctions.CalculateHash(key);

            while (_identifiers[hash] != null)
            {
                hash = HashFunctions.ReCalculateHash(key);
            }

            _identifiers[hash] = new KeyValue(key, value);
        }

        public string Get(string key)
        {
            var hash = HashFunctions.CalculateHash(key);

            while (_identifiers[hash].Key != key)
            {
                hash = HashFunctions.ReCalculateHash(key);
            }

            return _identifiers[hash].Value;
        }
    }
}
