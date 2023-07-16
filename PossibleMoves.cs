public class PossibleMoves
{
    // attributes
    private string _currentColor;

    // constructor
    public PossibleMoves(string currentColor)
    {
        _currentColor = currentColor;
    }


    // methods

    //  public

/*

    public List<Position> checkKingMoves(List<List<Square>> board, Position position)
    {

    }

    public List<Position> checkQueenMoves(List<List<Square>> board, Position position)
    {
        List<Position> possibleMoves = new List<Position>();

        List<Position> horizantalRookMoves = RookHorizontalMove(board, position);

        foreach (Position i in horizantalRookMoves)
        {
            possibleMoves.Add(i);
        }

        List<Position> verticalRookMoves = RookVerticalMove(board, position);

        foreach (Position i in verticalRookMoves)
        {
            possibleMoves.Add(i);
        }

        List<Position> NEBishopMoves = BishopNorthEastMove(board, position);

        foreach (Position i in NEBishopMoves)
        {
            possibleMoves.Add(i);
        }

        List<Position> NWBishopMoves = BishopNorthWestMove(board, position);

        foreach (Position i in NWBishopMoves)
        {
            possibleMoves.Add(i);
        }

        return possibleMoves;
    }

*/

    public List<Position> checkRookMoves(List<List<Square>> board, Position position)
    {
        List<Position> possibleMoves = new List<Position>();

        List<Position> horizantalRookMoves = RookHorizontalMove(board, position);

        Console.WriteLine("load H movelist");

        foreach (Position i in horizantalRookMoves)
        {
            Console.WriteLine("added position from H movelist to all movelist");
            possibleMoves.Add(i);
        }

        List<Position> verticalRookMoves = RookVerticalMove(board, position);

        Console.WriteLine("load V movelist");

        foreach (Position i in verticalRookMoves)
        {
            Console.WriteLine("added position from V movelist to all movelist");
            possibleMoves.Add(i);
        }

        Console.WriteLine("return all movelist");
        return possibleMoves;
    }

/*

    public List<Position> checkBishopMoves(List<List<Square>> board, Position position)
    {
        List<Position> possibleMoves = new List<Position>();

        List<Position> NEBishopMoves = BishopNorthEastMove(board, position);

        foreach (Position i in NEBishopMoves)
        {
            possibleMoves.Add(i);
        }

        List<Position> NWBishopMoves = BishopNorthWestMove(board, position);

        foreach (Position i in NWBishopMoves)
        {
            possibleMoves.Add(i);
        }

        return possibleMoves;
    }



    public List<Position> checkKnightMoves(List<List<Square>> board, Position position)
    {
        
    }

    public List<Position> checkPawnMoves(List<List<Square>> board, Position position)
    {
        
    }

*/

    //  private

/*

    private List<Position> KingMove(List<List<Square>> board, Position position)
    {

    }

*/

    private List<Position> RookHorizontalMove(List<List<Square>> board, Position position)
    {
        List<Position> list = new List<Position> {};

        int posX = position.getPosition()[0];
        int posY = position.getPosition()[1];

        if (_currentColor == "white")
        {
            
            for (int i = posX - 1; i >= 0; i --)
            {
                Console.WriteLine("check left white");
                if (board[posY][i].getOccupiedBy().getColor() == "clear")
                {
                    Console.WriteLine("found clear");
                    list.Add(new Position(i, posY));
                }
                else if (board[posY][i].getOccupiedBy().getColor() == "white")
                {
                    Console.WriteLine("found white");
                    break;
                }
                else if (board[posY][i].getOccupiedBy().getColor() == "black")
                {
                    Console.WriteLine("found black");
                    list.Add(new Position(i, posY));
                    break;
                }
            }

            for (int i = posX + 1; i <= 7; i ++)
            {
                Console.WriteLine("check right white");
                if (board[posY][i].getOccupiedBy().getColor() == "clear")
                {
                    Console.WriteLine("found clear");
                    list.Add(new Position(i, posY));
                }
                else if (board[posY][i].getOccupiedBy().getColor() == "white")
                {
                    Console.WriteLine("found white");
                    break;
                }
                else if (board[posY][i].getOccupiedBy().getColor() == "black")
                {
                    Console.WriteLine("found black");
                    list.Add(new Position(i, posY));
                    break;
                }
            }
            Console.WriteLine("returned white H move list");
            return list;
        }
        else if (_currentColor == "black")
        {
            
            for (int i = posX - 1; i >= 0; i --)
            {
                Console.WriteLine("check left black");
                if (board[posY][i].getOccupiedBy().getColor() == "clear")
                {
                    Console.WriteLine("found clear");
                    list.Add(new Position(i, posY));
                }
                else if (board[posY][i].getOccupiedBy().getColor() == "black")
                {
                    Console.WriteLine("found black");
                    break;
                }
                else if (board[posY][i].getOccupiedBy().getColor() == "white")
                {
                    Console.WriteLine("found white");
                    list.Add(new Position(i, posY));
                    break;
                }
            }

            for (int i = posX + 1; i <= 7; i ++)
            {
                Console.WriteLine("check right black");
                if (board[posY][i].getOccupiedBy().getColor() == "clear")
                {
                    Console.WriteLine("found clear");
                    list.Add(new Position(i, posY));
                }
                else if (board[posY][i].getOccupiedBy().getColor() == "black")
                {
                    Console.WriteLine("found black");
                    break;
                }
                else if (board[posY][i].getOccupiedBy().getColor() == "white")
                {
                    Console.WriteLine("found white");
                    list.Add(new Position(i, posY));
                    break;
                }
            }
            Console.WriteLine("returned black H move list");
            return list;
        }
        else
        {
            Console.WriteLine("some color other than 'white' or 'black' was given to the 'RookHorizontalMove' method.");
            return list;
        }
    }

    private List<Position> RookVerticalMove(List<List<Square>> board, Position position)
    {
        List<Position> list = new List<Position> {};

        int posX = position.getPosition()[0];
        int posY = position.getPosition()[1];

        if (_currentColor == "white")
        {
            
            for (int i = posY - 1; i >= 0; i --)
            {
                Console.WriteLine("check up white");
                if (board[i][posX].getOccupiedBy().getColor() == "clear")
                {
                    Console.WriteLine("found clear");
                    list.Add(new Position(posX, i));
                }
                else if (board[i][posX].getOccupiedBy().getColor() == "white")
                {
                    Console.WriteLine("found white");
                    break;
                }
                else if (board[i][posX].getOccupiedBy().getColor() == "black")
                {
                    Console.WriteLine("found black");
                    list.Add(new Position(posX, i));
                    break;
                }
            }

            for (int i = posY + 1; i <= 7; i ++)
            {
                Console.WriteLine("check down white");
                if (board[i][posX].getOccupiedBy().getColor() == "clear")
                {
                    Console.WriteLine("found clear");
                    list.Add(new Position(posX, i));
                }
                else if (board[i][posX].getOccupiedBy().getColor() == "white")
                {
                    Console.WriteLine("found white");
                    break;
                }
                else if (board[i][posX].getOccupiedBy().getColor() == "black")
                {
                    Console.WriteLine("found black");
                    list.Add(new Position(posX, i));
                    break;
                }
            }
            Console.WriteLine("returned white V move list");
            return list;
        }
        else if (_currentColor == "black")
        {
            
            for (int i = posY - 1; i >= 0; i --)
            {
                Console.WriteLine("check up black");
                if (board[i][posX].getOccupiedBy().getColor() == "clear")
                {
                    Console.WriteLine("found clear");
                    list.Add(new Position(posX, i));
                }
                else if (board[i][posX].getOccupiedBy().getColor() == "black")
                {
                    Console.WriteLine("found black");
                    break;
                }
                else if (board[i][posX].getOccupiedBy().getColor() == "white")
                {
                    Console.WriteLine("found white");
                    list.Add(new Position(posX, i));
                    break;
                }
            }

            for (int i = posY + 1; i <= 7; i ++)
            {
                Console.WriteLine("check down black");
                if (board[i][posX].getOccupiedBy().getColor() == "clear")
                {
                    Console.WriteLine("found clear");
                    list.Add(new Position(posX, i));
                }
                else if (board[i][posX].getOccupiedBy().getColor() == "black")
                {
                    Console.WriteLine("found black");
                    break;
                }
                else if (board[i][posX].getOccupiedBy().getColor() == "white")
                {
                    Console.WriteLine("found white");
                    list.Add(new Position(posX, i));
                    break;
                }
            }
            Console.WriteLine("returned black V move list");
            return list;
        }
        else
        {
            Console.WriteLine("some color other than 'white' or 'black' was given to the 'RookVerticalMove' method.");
            return list;
        }
    }

/*

    private List<Position> BishopNorthEastMove(List<List<Square>> board, Position position)
    {

    }

    private List<Position> BishopNorthWestMove(List<List<Square>> board, Position position)
    {

    }

    private List<Position> KnightMove(List<List<Square>> board, Position position)
    {

    }

    private List<Position> PawnForwardMove(List<List<Square>> board, Position position)
    {

    }

    private List<Position> PawnTakeMove(List<List<Square>> board, Position position)
    {

    }

*/

}


