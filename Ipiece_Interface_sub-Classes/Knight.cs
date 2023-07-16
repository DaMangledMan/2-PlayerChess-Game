public class Knight : IPiece
{
    // attributes

    // constructor
    public Knight(string color, string isPiece = "N", bool isAlive = true, bool hasMoved = false) : base(color, isPiece, isAlive, hasMoved)
    {
    }

    // methods

    public override string symbol()
    {
        if (_color == "white")
        {
            return $"W,N";
        }
        else if (_color == "black")
        {
            return $"B,N";
        }    
        else
        {
            return "";
        }
    }
}