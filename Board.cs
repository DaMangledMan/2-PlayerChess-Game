public class Board
{
    // attributes
    private List<List<Square>> _currentBoard = new List<List<Square>> {};
    private List<List<Square>> _futureBoard = new List<List<Square>> {};

    // constructor
    public Board()
    {
        // initiates the entire chess board in the starting position

        // creates the first rank
        List<Square> firstRank = new List<Square>();

        

        

        for (int i = 0; i >= 8; i++)
        {
            Square A = new Square(new Position(0,0), new Rook("white", new Position(0,0)), "white");
        }
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

    public bool checkForChecks(string colorWeCareAbout)
    {
        return false; // this is just to prevent it from looking highlighting red

        // this should check to make sure there is a possible move for the player who's turn it currently is
    }

    public bool checkForChecksMates(string colorWeCareAbout)
    {
        return false; // this is just to prevent it from looking highlighting red

        // this should check to make sure there is a possible move for the player who's turn it currently is
    }

    public bool attemptToMakeMove(string moveToAttempt)
    {
        return false; // this is just to prevent it from looking highlighting red

        // takes input as a move, attempts to make the move, returns a bool to notify the program if the move was succesful
    }


}