public class Board
{
    // attributes
    private List<List<Square>> _currentBoard = new List<List<Square>> {};
    private List<List<Square>> _futureBoard = new List<List<Square>> {};

    // constructor
    public Board()
    {
        // initiates the entire chess board in the starting position
    }

    // methods

    public void displayBoard()
    {
        // console writelines the entire board in a simple to understand manner
    }

    public bool checkForStalemates(string colorWeCareAbout)
    {
        return false; // this is just to prevent it from looking highlighting red

        // this should check to make sure there is a possible move for the player who's turn it currently is
    }

    public bool checkForChecks(string colorWeCareAbout) : bool
}