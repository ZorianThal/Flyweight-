public class Forest
{
    private readonly TreeTypeFactory _factory;
    private readonly List<Tree> _trees = new();

    public Forest (TreeTypeFactory factory)
    {
        _factory = factory;
    }

    public void Addoak(float x, float y, float scale)
    {
        TreeType oak = _factory.GetTreeType("0ak", "0ak.png", "0ak.fbx");

        Tree tree = new Tree(oak, x, y, scale);

        _trees.Add(tree);
    }

    public void Render()
    {
        foreach (Tree tree in _trees)
        {
            tree.Render();
        }
    }
}