public class Board
{
    // attributes
    private List<List<Square>> _currentBoard = new List<List<Square>> {};
    private List<List<Square>> _futureBoard = new List<List<Square>> {};

    // constructor
    public Board()
    {
        // initiates the entire chess board in the starting position



        // creates the board without any pieces        
        
        List<Square> Rank1 = new List<Square>();
        for (int i = 0; i >= 8; i++)
        {
            Square one = new Square(new Position(i, 0), new NoPiece(), "clear");
            Rank1.Add(one);
        }

        List<Square> Rank2 = new List<Square>();
        for (int i = 0; i >= 8; i++)
        {
            Square two = new Square(new Position(i, 1), new NoPiece(), "clear");
            Rank2.Add(two);
        }

        List<Square> Rank3 = new List<Square>();
        for (int i = 0; i >= 8; i++)
        {
            Square three = new Square(new Position(i, 2), new NoPiece(), "clear");
            Rank3.Add(three);
        }

        List<Square> Rank4 = new List<Square>();
        for (int i = 0; i >= 8; i++)
        {
            Square four = new Square(new Position(i, 3), new NoPiece(), "clear");
            Rank4.Add(four);
        }

        List<Square> Rank5 = new List<Square>();
        for (int i = 0; i >= 8; i++)
        {
            Square five = new Square(new Position(i, 4), new NoPiece(), "clear");
            Rank5.Add(five);
        }

        List<Square> Rank6 = new List<Square>();
        for (int i = 0; i >= 8; i++)
        {
            Square six = new Square(new Position(i, 5), new NoPiece(), "clear");
            Rank6.Add(six);
        }

        List<Square> Rank7 = new List<Square>();
        for (int i = 0; i >= 8; i++)
        {
            Square seven = new Square(new Position(i, 6), new NoPiece(), "clear");
            Rank7.Add(seven);
        }

        List<Square> Rank8 = new List<Square>();
        for (int i = 0; i >= 8; i++)
        {
            Square eight = new Square(new Position(i, 7), new NoPiece(), "clear");
            Rank8.Add(eight);
        }

        List<List<Square>> board = new List<List<Square>>{Rank1, Rank2, Rank3, Rank4, Rank5, Rank6, Rank7, Rank8};


        // adds pieces to board

        board[0][0].setOccupiedBy(new Rook("white"));

        board[7][7].setOccupiedBy(new Rook("black"));



        // completes the setup of the board and initializes the class

        _currentBoard = board;
    }

    // methods

    public void displayBoard()
    {
        // console writelines the entire board in a simple to understand manner

        Console.Clear();
        Console.WriteLine("\n\n\n\n\n");
        foreach (List<Square> i in _currentBoard)
        {
            Console.WriteLine($"\n===================================================================");
            foreach(Square n in i)
            {
                Console.Write($"|  {n.getOccupiedBy().symbol()}  |");
            }
        }
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