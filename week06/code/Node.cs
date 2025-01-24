public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // Avoid inserting duplicates
        if (value == Data)
        {
            return; // Do nothing if the value already exists
        }

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        if (value == Data)
        {
            return true; // Value found
        }

        if (value < Data)
        {
            return Left?.Contains(value) ?? false; // Check the left subtree
        }
        else
        {
            return Right?.Contains(value) ?? false; // Check the right subtree
        }
    }


    public int GetHeight()
    {
        int leftHeight = Left?.GetHeight() ?? 0; // If Left is null, return 0
        int rightHeight = Right?.GetHeight() ?? 0; // If Right is null, return 0

        return Math.Max(leftHeight, rightHeight) + 1; // The height is the max of left and right subtree heights plus 1
    }

}