public class TreeType
{
    public string Name { get; }
    public string Texture { get; }
    public string Model { get; }

    public TreeType(string name, string texture, string model)
    {
        Name = name;
        Texture = texture;
        Model = model;
    }
}
