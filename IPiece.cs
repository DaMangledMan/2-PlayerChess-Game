public abstract class IPiece
{
    // attributes
    protected string _isPiece;
    protected bool _isAlive;
    protected bool _hasMoved;
    protected string _color;
    protected Position _position = new Position(0, 0);

    // constructor
    public IPiece(string color, string isPiece, bool isAlive = true, bool hasMoved = false)
    {
        _isPiece = isPiece;
        _isAlive = isAlive;
        _hasMoved = hasMoved;
        _color = color;
    }

    // methods

    public abstract string symbol();

    public string getIsPiece()
    {
        return _isPiece;
    }

    public bool getIsAlive()
    {
        return _isAlive;
    }

    public void setIsAlive(bool isAlive)
    {
        _isAlive = isAlive;
    }

    public bool getHasMoved()
    {
        return _hasMoved;
    }

    public void setHaveMoved(bool hasMoved)
    {
        _hasMoved = hasMoved;
    }

    public string getColor()
    {
        return _color;
    }

    public Position GetPosition()
    {
        return _position;
    }

    public void setPosition(Position position)
    {
        _position = position;
    }
}