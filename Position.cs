public class Position
{
    // attributes
    private int _x;
    private int _y;

    // constructor
    public Position(int x, int y)
    {
        _x = x;
        _y = y;
    }

    // methods
    public List<int> getPosition()
    {
        return new List<int>{_x, _y};
    }

}