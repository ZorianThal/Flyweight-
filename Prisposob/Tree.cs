public class Tree
{
    private readonly TreeType _tree;
    public float X {  get; }
    public float Y { get; }
    public float Scale { get; }

    public Tree(TreeType tree, float scale, float x, float y)
    {
        _tree = tree;

        X = x;
        Y = y;
        Scale = scale;
    }
    public void Render()
    {
        Console.WriteLine(
            $"Дерево - {_tree.Name}," +
            $"позиция: ({X}, {Y})," +
            $"Размер: {Scale}"
            );
    }
}