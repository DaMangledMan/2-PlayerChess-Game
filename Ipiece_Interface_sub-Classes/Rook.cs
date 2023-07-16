public class Rook : IPiece
{
    // attributes

    // constructor
    public Rook(string color, string isPiece = "R", bool isAlive = true, bool hasMoved = false) : base(color, isPiece, isAlive, hasMoved)
    {
    }

    // methods

    public override string symbol()
    {
        if (_color == "white")
        {
            return $"W,R";
        }
        else if (_color == "black")
        {
            return $"B,R";
        }    
        else
        {
            return "";
        }
    }
}