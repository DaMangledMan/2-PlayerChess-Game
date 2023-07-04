public class Square
{
    // attributes
    private Position _position;
    private IPiece _occupiedBy;
    private string _colorOfOccupier;

    // constructor
    public Square(Position position, IPiece occupiedBy, string color)
    {
        _position = position;
        _occupiedBy = occupiedBy;
        _colorOfOccupier = color;
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

    public string getColorOfOccupier()
    {
        return _colorOfOccupier;
    }
}