namespace IdentifiersTable
{
    internal class HashFunctions
    {
        public const int PossibleHashValues = 5;

        public static int CalculateHash(string key)
        {
            var notNormalizedHash = key.ToCharArray().Sum(symbol => symbol.GetHashCode());

            return notNormalizedHash % PossibleHashValues;
        }

        public static int ReCalculateHash(string key)
        {
            var random = new Random().Next(PossibleHashValues);

            return (CalculateHash(key) + random) % PossibleHashValues;
        }
    }
}
