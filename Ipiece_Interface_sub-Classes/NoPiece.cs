public class NoPiece : IPiece
{
    // attributes

    // constructor
    public NoPiece(string color = "clear", bool isAlive = false, bool hasMoved = true) : base(color, isAlive, hasMoved)
    {
    }

    // methods

    public override void makeMove()
    {
        throw new NotImplementedException();
    }

    public override string symbol()
    {
        return "_";
    }
}