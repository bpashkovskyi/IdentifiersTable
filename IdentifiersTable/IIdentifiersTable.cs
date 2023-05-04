namespace IdentifiersTable;

public interface IIdentifiersTable
{
    public void Add(string key, string value);

    public string Get(string key);
}