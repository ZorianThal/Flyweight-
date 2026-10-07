public class TreeTypeFactory
{
    private readonly Dictionary<string, TreeType> _types = new();

    public TreeType GetTreeType(string name, string texture, string model)
    {
        if (_types.TryGetValue(name, out TreeType? existingType))
        {
            return existingType;
        }

        TreeType newType = new TreeType(name, texture, model);

        _types.Add(name, newType);

        return newType;

    }
}