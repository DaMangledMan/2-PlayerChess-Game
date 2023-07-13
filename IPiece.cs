public abstract class IPiece
{
    // attributes
    protected bool _isAlive;
    protected bool _hasMoved;
    protected string _color;
    protected Position _position = new Position(0, 0);

    // constructor
    public IPiece(string color, bool isAlive = true, bool hasMoved = false)
    {
        _isAlive = isAlive;
        _hasMoved = hasMoved;
        _color = color;
    }

    // methods
    
    public abstract void makeMove();

    public abstract string symbol();

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