namespace IdentifiersTable;

public class KeyValue
{
    public KeyValue(string key, string value)
    {
        Key = key;
        Value = value;
    }

    public string Key { get; }
    public string Value { get; }
}