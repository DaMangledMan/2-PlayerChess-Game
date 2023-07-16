public class Pawn : IPiece
{
    // attributes

    // constructor
    public Pawn(string color, string isPiece = "P", bool isAlive = true, bool hasMoved = false) : base(color, isPiece, isAlive, hasMoved)
    {
    }

    // methods

    public override string symbol()
    {
        if (_color == "white")
        {
            return $"W,P";
        }
        else if (_color == "black")
        {
            return $"B,P";
        }    
        else
        {
            return "";
        }
    }
}