public class Rook : IPiece
{
    // attributes

    // constructor
    public Rook(string color, bool isAlive = true, bool hasMoved = false) : base(color, isAlive, hasMoved)
    {
    }

    // methods

    public override void makeMove()
    {

    }

    public override string symbol()
    {
        return "R";
    }
}