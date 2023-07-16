public class Bishop : IPiece
{
    // attributes

    // constructor
    public Bishop(string color, string isPiece = "B", bool isAlive = true, bool hasMoved = false) : base(color, isPiece, isAlive, hasMoved)
    {
    }

    // methods

    public override string symbol()
    {
        if (_color == "white")
        {
            return $"W,B";
        }
        else if (_color == "black")
        {
            return $"B,B";
        }    
        else
        {
            return "";
        }
    }
}