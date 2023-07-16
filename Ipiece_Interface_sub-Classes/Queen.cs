public class Queen : IPiece
{
    // attributes

    // constructor
    public Queen(string color, string isPiece = "Q", bool isAlive = true, bool hasMoved = false) : base(color, isPiece, isAlive, hasMoved)
    {
    }

    // methods

    public override string symbol()
    {
        if (_color == "white")
        {
            return $"W,Q";
        }
        else if (_color == "black")
        {
            return $"B,Q";
        }    
        else
        {
            return "";
        }
    }
}