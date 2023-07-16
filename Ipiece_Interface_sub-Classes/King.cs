public class King : IPiece
{
    // attributes

    // constructor
    public King(string color, string isPiece = "K", bool isAlive = true, bool hasMoved = false) : base(color, isPiece, isAlive, hasMoved)
    {
    }

    // methods

    public override string symbol()
    {
        if (_color == "white")
        {
            return $"W,K";
        }
        else if (_color == "black")
        {
            return $"B,K";
        }    
        else
        {
            return "";
        }
    }
}