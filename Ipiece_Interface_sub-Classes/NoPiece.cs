public class NoPiece : IPiece
{
    // attributes

    // constructor
    public NoPiece(string color = "clear", string isPiece = "null", bool isAlive = false, bool hasMoved = true) : base(color, isPiece, isAlive, hasMoved)
    {
    }

    // methods

    public override string symbol()
    {
        return "___";
    }
}