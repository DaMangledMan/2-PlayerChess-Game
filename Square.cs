public class Square
{
    // attributes
    private Position _position;
    private IPiece _occupiedBy;
    

    // constructor
    public Square(Position position, IPiece occupiedBy)
    {
        _position = position;
        _occupiedBy = occupiedBy;
    }

    // methods

    public Position getPosition()
    {
        return _position;
    }

    public IPiece getOccupiedBy()
    {
        return _occupiedBy;
    }

    public void setOccupiedBy(IPiece piece)
    {
        _occupiedBy = piece;
    }

    public string getColorOfOccupier()
    {
        return _occupiedBy.getColor();
    }
}


