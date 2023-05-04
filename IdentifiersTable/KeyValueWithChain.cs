namespace IdentifiersTable;

public class KeyValueWithChain
{
    public KeyValueWithChain(KeyValue keyValue)
    {
        KeyValue = keyValue;
    }

    public KeyValue KeyValue { get; }

    public int? Chain { get; set; }
}