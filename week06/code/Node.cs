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
        // TODO Start Problem 1
        if (value == Data) //This is my recursion exit strategy
        return;

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
        // TODO Start Problem 2
        if (value == Data) //This is my base case
            return true;

        if (value < Data) //I searched the smaller values in the left subtree
        return Left is not null && Left.Contains(value);

        return Right is not null && Right.Contains(value);
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        //I first need to measure the subtrees:
        int leftHeight = Left is null ? 0 : Left.GetHeight();
        int rightHeight = Right is null ? 0 : Right.GetHeight();

        return 1 + Math.Max(leftHeight, rightHeight);//Only the tallest path wins
        //return 0; // Replace this line with the correct return statement(s)
    }
}