public abstract class IPiece
{
    // attributes
    protected bool _isAlive;
    protected bool _hasMoved;
    protected string _color;
    protected Position _position;

    // constructor
    public IPiece(string color, Position position, bool isAlive = true, bool hasMoved = false)
    {
        _isAlive = isAlive;
        _hasMoved = hasMoved;
        _color = color;
        _position = position;
    }

    // methods
    
    public abstract void makeMove();

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