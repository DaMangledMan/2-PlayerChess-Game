public class Board
{
    // attributes
    private string _currentTurn = "white";
    private List<List<Square>> _Board = new List<List<Square>> {};

    // constructor
    public Board()
    {
        // initiates the entire chess board in the starting position



        // creates the board without any pieces

        List<List<Square>> chessBoard = new List<List<Square>> {};
        for (int i = 0; i <= 7; i++)
        {
            List<Square> Rank = new List<Square> {};
            for (int n = 0; n <= 7; n++)
            {
                Square R = new Square(new Position(n, i), new NoPiece());
                Rank.Add(R);
            }
            chessBoard.Add(Rank);
        }

        
        // adds pieces to board (coordinates are in order [y][x])

        chessBoard[0][0].setOccupiedBy(new Rook("white"));

        chessBoard[0][7].setOccupiedBy(new Rook("white"));

        chessBoard[7][7].setOccupiedBy(new Rook("black"));

        chessBoard[7][0].setOccupiedBy(new Rook("black"));



        // completes the setup of the board and initializes the class

        _Board = chessBoard;
    }

    // methods

    private void displayBoard()
    {
        // console writelines the entire board in a simple to understand manner

        Console.WriteLine("\n\n\n\n\n");
        Console.Write($"   |  0  ||  1  ||  2  ||  3  ||  4  ||  5  ||  6  ||  7  | X");
        int y = 0;
        foreach (List<Square> i in _Board)
        {
            Console.Write($"\n===========================================================\n {y} ");
            foreach(Square n in i)
            {
                Console.Write($"| {n.getOccupiedBy().symbol()} |");
            }
            y ++;
        }
        Console.WriteLine("\n===========================================================\n Y");
        Console.WriteLine($"\n\n\n\n\nIt is {_currentTurn}'s Turn.");
    }

    public void takeTurn()
    {
        displayBoard();
        
        while (true)
        {
            Console.WriteLine("What is the x value for the square that the piece you want to move is on?");
            int posX = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the y value for the square that the piece you want to move is on?");
            int posY = int.Parse(Console.ReadLine());

            if (_Board[posY][posX].getOccupiedBy().getColor() != _currentTurn)
            {
                displayBoard();
                Console.WriteLine("You must choose a piece that is your color.");
                continue;
            }

            Console.WriteLine("What is the x value for the square that you want to move the piece to?");
            int toPosX = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the y value for the square that you want to move the piece to?");
            int toPosY = int.Parse(Console.ReadLine());

            Position from = new Position(posX, posY);
            Position to = new Position(toPosX, toPosY);

            if (attemptToMakeMove(from, to))
            {
                break;
            }
            else
            {
                displayBoard();
                Console.WriteLine("The attempted move was not possible. Please try again.");
                continue;
            }
        }
        if (_currentTurn == "white")
        {
            _currentTurn = "black";
        }    
        else if (_currentTurn == "black")
        {
            _currentTurn = "white";
        }

        if (!searchForKing())
        {
            Console.Clear();
            Console.WriteLine($"\n\n\n\n{_currentTurn} wins!!!\n  Congratulations\n\n\n\n\n\n\n\n");
            Environment.Exit(1);
        }
    }

    private bool attemptToMakeMove(Position from, Position to)
    {
        PossibleMoves PosMov = new PossibleMoves(_currentTurn);

        List<Position> possibleMoves = new List<Position> {};

        int posX = from.getPosition()[0];
        int posY = from.getPosition()[1];

        int toPosX = to.getPosition()[0];
        int toPosY = to.getPosition()[1];

        string swi = _Board[posY][posX].getOccupiedBy().getIsPiece();
        Console.WriteLine(swi);

        switch (swi)
        {
            case "K":

                break;

            case "Q":

                break;

            case "R":
                Console.WriteLine("it recognized the Rook");
                possibleMoves = PosMov.checkRookMoves(_Board, from);
                break;

            case "B":

                break;

            case "Kn":

                break;

            case "P":

                break;

            default:

                break;

        }

        bool contains = false;
        foreach (Position i in possibleMoves)
        {
            if (i.getPosition()[0] == to.getPosition()[0] && i.getPosition()[1] == to.getPosition()[1])
            {
                contains = true;
            }
        }

        if (contains)
        {
            Console.WriteLine("board contains 'to' move");
            
            _Board[posY][posX].setOccupiedBy(new NoPiece());

            switch (swi)
            {
                case "K":

                    break;

                case "Q":

                    break;

                case "R":
                    Console.WriteLine("should edit the board");
                    _Board[toPosY][toPosX].setOccupiedBy(new Rook(_currentTurn));
                    break;

                case "B":

                    break;

                case "Kn":

                    break;

                case "P":

                    break;

                default:

                    break;

            }
            return true;
        }
        else
        {
            return false;
        }
    }

    private bool searchForKing()
    {
        return true;
    }
}