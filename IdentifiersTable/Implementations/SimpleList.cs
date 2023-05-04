namespace IdentifiersTable.Implementations;

public class SimpleList : IIdentifiersTable
{
    private readonly List<KeyValue> _identifiers;

    public SimpleList()
    {
        _identifiers = new List<KeyValue>();
    }

    public void Add(string key, string value)
    {
        _identifiers.Add(new KeyValue(key, value));
    }

    public string Get(string key)
    {
        var identifier = _identifiers.FirstOrDefault(id => id.Key == key);

        if (identifier != null)
        {
            return identifier.Value;
        }

        return null;
    }
}