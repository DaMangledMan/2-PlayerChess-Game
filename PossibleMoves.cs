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



    public List<Position> checkKingMoves(List<List<Square>> board, Position position)
    {
        return KingMove(board, position);
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



    public List<Position> checkRookMoves(List<List<Square>> board, Position position)
    {
        List<Position> possibleMoves = new List<Position>();

        List<Position> horizantalRookMoves = RookHorizontalMove(board, position);

        foreach (Position i in horizantalRookMoves)
        {
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
        return KnightMove(board, position);
    }

    public List<Position> checkPawnMoves(List<List<Square>> board, Position position)
    {
        List<Position> possibleMoves = new List<Position>();

        List<Position> pawnFowardMoves = PawnForwardMove(board, position);

        foreach (Position i in pawnFowardMoves)
        {
            possibleMoves.Add(i);
        }

        List<Position> pawnTakeMoves = PawnTakeMove(board, position);

        foreach (Position i in pawnTakeMoves)
        {
            possibleMoves.Add(i);
        }

        return possibleMoves;
    }





    //  private



    private List<Position> KingMove(List<List<Square>> board, Position position)
    {
        List<Position> list = new List<Position> {};

        int posX = position.getPosition()[0];
        int posY = position.getPosition()[1];

        if (_currentColor == "white")
        {

            if (posY-1 >= 0 && posX-1 !< 0)
            {
                Square square = board[posY-1][posX-1];
                if (square.getOccupiedBy().getColor() == "clear")
                {
                    list.Add(square.getPosition());
                }
                else if (square.getOccupiedBy().getColor() == "white")
                {
                }
                else if (square.getOccupiedBy().getColor() == "black")
                {
                    list.Add(square.getPosition());
                }
            }

            if (posY-1 >= 0)
            {
                Console.WriteLine(posY);
                Square square = board[posY-1][posX];
                if (square.getOccupiedBy().getColor() == "clear")
                {
                    list.Add(square.getPosition());
                }
                else if (square.getOccupiedBy().getColor() == "white")
                {
                }
                else if (square.getOccupiedBy().getColor() == "black")
                {
                    list.Add(square.getPosition());
                }
            }

            if (posY-1 !< 0 && posX+1 !> 7)
            {
                Square square = board[posY-1][posX+1];
                if (square.getOccupiedBy().getColor() == "clear")
                {
                    list.Add(square.getPosition());
                }
                else if (square.getOccupiedBy().getColor() == "white")
                {
                }
                else if (square.getOccupiedBy().getColor() == "black")
                {
                    list.Add(square.getPosition());
                }
            }

            if (posX+1 !> 7)
            {
                Square square = board[posY][posX-1];
                if (square.getOccupiedBy().getColor() == "clear")
                {
                    list.Add(square.getPosition());
                }
                else if (square.getOccupiedBy().getColor() == "white")
                {
                }
                else if (square.getOccupiedBy().getColor() == "black")
                {
                    list.Add(square.getPosition());
                }
            }

            if (posY+1 !> 7 && posX+1 !> 7)
            {
                Square square = board[posY+1][posX+1];
                if (square.getOccupiedBy().getColor() == "clear")
                {
                    list.Add(square.getPosition());
                }
                else if (square.getOccupiedBy().getColor() == "white")
                {
                }
                else if (square.getOccupiedBy().getColor() == "black")
                {
                    list.Add(square.getPosition());
                }
            }

            if (posY+1 !> 7)
            {
                Square square = board[posY+1][posX];
                if (square.getOccupiedBy().getColor() == "clear")
                {
                    list.Add(square.getPosition());
                }
                else if (square.getOccupiedBy().getColor() == "white")
                {
                }
                else if (square.getOccupiedBy().getColor() == "black")
                {
                    list.Add(square.getPosition());
                }
            }

            if (posY+1 !> 7 && posX-1 !< 0)
            {
                Square square = board[posY+1][posX-1];
                if (square.getOccupiedBy().getColor() == "clear")
                {
                    list.Add(square.getPosition());
                }
                else if (square.getOccupiedBy().getColor() == "white")
                {
                }
                else if (square.getOccupiedBy().getColor() == "black")
                {
                    list.Add(square.getPosition());
                }
            }

            if (posX-1 !< 0)
            {
                Square square = board[posY][posX-1];
                if (square.getOccupiedBy().getColor() == "clear")
                {
                    list.Add(square.getPosition());
                }
                else if (square.getOccupiedBy().getColor() == "white")
                {
                }
                else if (square.getOccupiedBy().getColor() == "black")
                {
                    list.Add(square.getPosition());
                }
            }

        }
        

        if (_currentColor == "black")
        {

            if (posY-1 !< 0 && posX-1 !< 0)
            {
                Square square = board[posY-1][posX-1];
                if (square.getOccupiedBy().getColor() == "clear")
                {
                    list.Add(square.getPosition());
                }
                else if (square.getOccupiedBy().getColor() == "black")
                {
                }
                else if (square.getOccupiedBy().getColor() == "white")
                {
                    list.Add(square.getPosition());
                }
            }

            if (posY-1 !< 0)
            {
                Square square = board[posY-1][posX];
                if (square.getOccupiedBy().getColor() == "clear")
                {
                    list.Add(square.getPosition());
                }
                else if (square.getOccupiedBy().getColor() == "black")
                {
                }
                else if (square.getOccupiedBy().getColor() == "white")
                {
                    list.Add(square.getPosition());
                }
            }

            if (posY-1 !< 0 && posX+1 !> 7)
            {
                Square square = board[posY-1][posX+1];
                if (square.getOccupiedBy().getColor() == "clear")
                {
                    list.Add(square.getPosition());
                }
                else if (square.getOccupiedBy().getColor() == "black")
                {
                }
                else if (square.getOccupiedBy().getColor() == "white")
                {
                    list.Add(square.getPosition());
                }
            }

            if (posX+1 !> 7)
            {
                Square square = board[posY][posX-1];
                if (square.getOccupiedBy().getColor() == "clear")
                {
                    list.Add(square.getPosition());
                }
                else if (square.getOccupiedBy().getColor() == "black")
                {
                }
                else if (square.getOccupiedBy().getColor() == "white")
                {
                    list.Add(square.getPosition());
                }
            }

            if (posY+1 !> 7 && posX+1 !> 7)
            {
                Square square = board[posY+1][posX+1];
                if (square.getOccupiedBy().getColor() == "clear")
                {
                    list.Add(square.getPosition());
                }
                else if (square.getOccupiedBy().getColor() == "black")
                {
                }
                else if (square.getOccupiedBy().getColor() == "white")
                {
                    list.Add(square.getPosition());
                }
            }

            if (posY+1 !> 7)
            {
                Square square = board[posY+1][posX];
                if (square.getOccupiedBy().getColor() == "clear")
                {
                    list.Add(square.getPosition());
                }
                else if (square.getOccupiedBy().getColor() == "black")
                {
                }
                else if (square.getOccupiedBy().getColor() == "white")
                {
                    list.Add(square.getPosition());
                }
            }

            if (posY+1 !> 7 && posX-1 !< 0)
            {
                Square square = board[posY+1][posX-1];
                if (square.getOccupiedBy().getColor() == "clear")
                {
                    list.Add(square.getPosition());
                }
                else if (square.getOccupiedBy().getColor() == "black")
                {
                }
                else if (square.getOccupiedBy().getColor() == "white")
                {
                    list.Add(square.getPosition());
                }
            }

            if (posX-1 !< 0)
            {
                Square square = board[posY][posX-1];
                if (square.getOccupiedBy().getColor() == "clear")
                {
                    list.Add(square.getPosition());
                }
                else if (square.getOccupiedBy().getColor() == "black")
                {
                }
                else if (square.getOccupiedBy().getColor() == "white")
                {
                    list.Add(square.getPosition());
                }
            }

        }

        else
        {
            Console.WriteLine("some color other than 'white' or 'black' was given to the 'KingMove' method.");
        }

        return list;


    }



    private List<Position> RookHorizontalMove(List<List<Square>> board, Position position)
    {
        List<Position> list = new List<Position> {};

        int posX = position.getPosition()[0];
        int posY = position.getPosition()[1];

        if (_currentColor == "white")
        {
            
            for (int i = posX - 1; i >= 0; i --)
            {
                if (board[posY][i].getOccupiedBy().getColor() == "clear")
                {
                    list.Add(new Position(i, posY));
                }
                else if (board[posY][i].getOccupiedBy().getColor() == "white")
                {
                    break;
                }
                else if (board[posY][i].getOccupiedBy().getColor() == "black")
                {
                    list.Add(new Position(i, posY));
                    break;
                }
            }

            for (int i = posX + 1; i <= 7; i ++)
            {
                if (board[posY][i].getOccupiedBy().getColor() == "clear")
                {
                    list.Add(new Position(i, posY));
                }
                else if (board[posY][i].getOccupiedBy().getColor() == "white")
                {
                    break;
                }
                else if (board[posY][i].getOccupiedBy().getColor() == "black")
                {
                    list.Add(new Position(i, posY));
                    break;
                }
            }
        }
        else if (_currentColor == "black")
        {
            
            for (int i = posX - 1; i >= 0; i --)
            {
                if (board[posY][i].getOccupiedBy().getColor() == "clear")
                {
                    list.Add(new Position(i, posY));
                }
                else if (board[posY][i].getOccupiedBy().getColor() == "black")
                {
                    break;
                }
                else if (board[posY][i].getOccupiedBy().getColor() == "white")
                {
                    list.Add(new Position(i, posY));
                    break;
                }
            }

            for (int i = posX + 1; i <= 7; i ++)
            {
                if (board[posY][i].getOccupiedBy().getColor() == "clear")
                {
                    list.Add(new Position(i, posY));
                }
                else if (board[posY][i].getOccupiedBy().getColor() == "black")
                {
                    break;
                }
                else if (board[posY][i].getOccupiedBy().getColor() == "white")
                {
                    list.Add(new Position(i, posY));
                    break;
                }
            }
            Console.WriteLine("returned black H move list");
        }
        else
        {
            Console.WriteLine("some color other than 'white' or 'black' was given to the 'RookHorizontalMove' method.");
        }

        return list;
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



    private List<Position> BishopNorthEastMove(List<List<Square>> board, Position position)
    {
        

        List<Position> list = new List<Position> {};

        int posX = position.getPosition()[0];
        int posY = position.getPosition()[1];

        if (_currentColor == "white")
        {

            for (int i = 1; posX + i <= 7 && posY - i >= 0 ; i ++)
            {

                Square square = board[posY-i][posX+i];

                if (square.getOccupiedBy().getColor() == "clear")
                {
                    list.Add(new Position(posX+i, posY-i));
                }
                else if (square.getOccupiedBy().getColor() == "white")
                {
                    break;
                }
                else if (square.getOccupiedBy().getColor() == "black")
                {
                    list.Add(new Position(posX+i, posY-i));
                    break;
                }

            }

            for (int i = 1; posX - i >= 0 && posY + i <= 7 ; i ++)
            {

                Square square = board[posY+i][posX-i];

                if (square.getOccupiedBy().getColor() == "clear")
                {
                    list.Add(new Position(posX-i, posY+i));
                }
                else if (square.getOccupiedBy().getColor() == "white")
                {
                    break;
                }
                else if (square.getOccupiedBy().getColor() == "black")
                {
                    list.Add(new Position(posX-i, posY+i));
                    break;
                }
                
            }


        }

        else if (_currentColor == "black")
        {

            for (int i = 1; posX + i <= 7 && posY - i >= 0 ; i ++)
            {

                Square square = board[posY-i][posX+i];

                if (square.getOccupiedBy().getColor() == "clear")
                {
                    list.Add(new Position(posX+i, posY-i));
                }
                else if (square.getOccupiedBy().getColor() == "black")
                {
                    break;
                }
                else if (square.getOccupiedBy().getColor() == "white")
                {
                    list.Add(new Position(posX+i, posY-i));
                    break;
                }

            }

            for (int i = 1; posX - i >= 0 && posY + i <= 7 ; i ++)
            {


                Square square = board[posY+i][posX-i];

                if (square.getOccupiedBy().getColor() == "clear")
                {
                    list.Add(new Position(posX-i, posY+i));
                }
                else if (square.getOccupiedBy().getColor() == "black")
                {
                    break;
                }
                else if (square.getOccupiedBy().getColor() == "white")
                {
                    list.Add(new Position(posX-i, posY+i));
                    break;
                }

                
            }


        }


        else
        {
            Console.WriteLine("some color other than 'white' or 'black' was given to the 'BishopNorthWestMove' method.");
            return list;
        }


        return list;

        
    }

    private List<Position> BishopNorthWestMove(List<List<Square>> board, Position position)
    {
        
        
        List<Position> list = new List<Position> {};

        int posX = position.getPosition()[0];
        int posY = position.getPosition()[1];

        if (_currentColor == "white")
        {

            for (int i = 1; posX + i <= 7 && posY + i <= 7 ; i ++)
            {

                Square square = board[posY+i][posX+i];

                if (square.getOccupiedBy().getColor() == "clear")
                {
                    list.Add(new Position(posX+i, posY+i));
                }
                else if (square.getOccupiedBy().getColor() == "white")
                {
                    break;
                }
                else if (square.getOccupiedBy().getColor() == "black")
                {
                    list.Add(new Position(posX+i, posY+i));
                    break;
                }

            }

            for (int i = 1; posX - i >= 0 && posY - i >= 0 ; i ++)
            {


                Square square = board[posY-i][posX-i];

                if (square.getOccupiedBy().getColor() == "clear")
                {
                    list.Add(new Position(posX-i, posY-i));
                }
                else if (square.getOccupiedBy().getColor() == "white")
                {
                    break;
                }
                else if (square.getOccupiedBy().getColor() == "black")
                {
                    list.Add(new Position(posX-i, posY-i));
                    break;
                }

                
            }


        }

        else if (_currentColor == "black")
        {

            for (int i = 1; posX + i <= 7 && posY + i <= 7 ; i ++)
            {

                Square square = board[posX+i][posY+i];

                if (square.getOccupiedBy().getColor() == "clear")
                {
                    list.Add(new Position(posX+i, posY+i));
                }
                else if (square.getOccupiedBy().getColor() == "black")
                {
                    break;
                }
                else if (square.getOccupiedBy().getColor() == "white")
                {
                    list.Add(new Position(posX+i, posY+i));
                    break;
                }

            }

            for (int i = 1; posX - i >= 0 && posY - i >= 0 ; i ++)
            {


                Square square = board[posX-i][posY-i];

                if (square.getOccupiedBy().getColor() == "clear")
                {
                    list.Add(new Position(posX-i, posY-i));
                }
                else if (square.getOccupiedBy().getColor() == "black")
                {
                    break;
                }
                else if (square.getOccupiedBy().getColor() == "white")
                {
                    list.Add(new Position(posX-i, posY-i));
                    break;
                }

                
            }


        }


        else
        {
            Console.WriteLine("some color other than 'white' or 'black' was given to the 'BishopNorthWestMove' method.");
            return list;
        }


        return list;


    }

    private List<Position> KnightMove(List<List<Square>> board, Position position)
    {


        List<Position> list = new List<Position> {};

        int posX = position.getPosition()[0];
        int posY = position.getPosition()[1];

        if (_currentColor == "white")
        {

            if (posY-2 !< 0 && posX-1 !< 0)
            {
                Square square = board[posY-2][posX-1];
                if (square.getOccupiedBy().getColor() == "clear")
                {
                    list.Add(square.getPosition());
                }
                else if (square.getOccupiedBy().getColor() == "white")
                {
                }
                else if (square.getOccupiedBy().getColor() == "black")
                {
                    list.Add(square.getPosition());
                }
            }

            if (posY-1 !< 0 && posX+1 !> 7)
            {
                Square square = board[posY-1][posX+1];
                if (square.getOccupiedBy().getColor() == "clear")
                {
                    list.Add(square.getPosition());
                }
                else if (square.getOccupiedBy().getColor() == "white")
                {
                }
                else if (square.getOccupiedBy().getColor() == "black")
                {
                    list.Add(square.getPosition());
                }
            }

            if (posY-1 !< 0 && posX+2 !> 7)
            {
                Square square = board[posY-1][posX+2];
                if (square.getOccupiedBy().getColor() == "clear")
                {
                    list.Add(square.getPosition());
                }
                else if (square.getOccupiedBy().getColor() == "white")
                {
                }
                else if (square.getOccupiedBy().getColor() == "black")
                {
                    list.Add(square.getPosition());
                }
            }

            if (posY+1 !> 7 && posX+2 !> 7)
            {
                Square square = board[posY+1][posX+2];
                if (square.getOccupiedBy().getColor() == "clear")
                {
                    list.Add(square.getPosition());
                }
                else if (square.getOccupiedBy().getColor() == "white")
                {
                }
                else if (square.getOccupiedBy().getColor() == "black")
                {
                    list.Add(square.getPosition());
                }
            }

            if (posY+2 !> 7 && posX-1 !< 0)
            {
                Square square = board[posY+2][posX-1];
                if (square.getOccupiedBy().getColor() == "clear")
                {
                    list.Add(square.getPosition());
                }
                else if (square.getOccupiedBy().getColor() == "white")
                {
                }
                else if (square.getOccupiedBy().getColor() == "black")
                {
                    list.Add(square.getPosition());
                }
            }

            if (posY+2 !> 7 && posX+1 !> 7)
            {
                Square square = board[posY+2][posX+1];
                if (square.getOccupiedBy().getColor() == "clear")
                {
                    list.Add(square.getPosition());
                }
                else if (square.getOccupiedBy().getColor() == "white")
                {
                }
                else if (square.getOccupiedBy().getColor() == "black")
                {
                    list.Add(square.getPosition());
                }
            }

            if (posY-1 !< 0 && posX-2 !< 0)
            {
                Square square = board[posY-1][posX-2];
                if (square.getOccupiedBy().getColor() == "clear")
                {
                    list.Add(square.getPosition());
                }
                else if (square.getOccupiedBy().getColor() == "white")
                {
                }
                else if (square.getOccupiedBy().getColor() == "black")
                {
                    list.Add(square.getPosition());
                }
            }

            if (posY+1 !> 7 && posX-2 !< 0)
            {
                Square square = board[posY+1][posX-2];
                if (square.getOccupiedBy().getColor() == "clear")
                {
                    list.Add(square.getPosition());
                }
                else if (square.getOccupiedBy().getColor() == "white")
                {
                }
                else if (square.getOccupiedBy().getColor() == "black")
                {
                    list.Add(square.getPosition());
                }
            }

        }
        

        if (_currentColor == "black")
        {

           if (posY-2 !< 0 && posX-1 !< 0)
            {
                Square square = board[posY-2][posX-1];
                if (square.getOccupiedBy().getColor() == "clear")
                {
                    list.Add(square.getPosition());
                }
                else if (square.getOccupiedBy().getColor() == "black")
                {
                }
                else if (square.getOccupiedBy().getColor() == "white")
                {
                    list.Add(square.getPosition());
                }
            }

            if (posY-1 !< 0 && posX+1 !> 7)
            {
                Square square = board[posY-1][posX+1];
                if (square.getOccupiedBy().getColor() == "clear")
                {
                    list.Add(square.getPosition());
                }
                else if (square.getOccupiedBy().getColor() == "black")
                {
                }
                else if (square.getOccupiedBy().getColor() == "white")
                {
                    list.Add(square.getPosition());
                }
            }

            if (posY-1 !< 0 && posX+2 !> 7)
            {
                Square square = board[posY-1][posX+2];
                if (square.getOccupiedBy().getColor() == "clear")
                {
                    list.Add(square.getPosition());
                }
                else if (square.getOccupiedBy().getColor() == "black")
                {
                }
                else if (square.getOccupiedBy().getColor() == "white")
                {
                    list.Add(square.getPosition());
                }
            }

            if (posY+1 !> 7 && posX+2 !> 7)
            {
                Square square = board[posY+1][posX+2];
                if (square.getOccupiedBy().getColor() == "clear")
                {
                    list.Add(square.getPosition());
                }
                else if (square.getOccupiedBy().getColor() == "black")
                {
                }
                else if (square.getOccupiedBy().getColor() == "white")
                {
                    list.Add(square.getPosition());
                }
            }

            if (posY+2 !> 7 && posX-1 !< 0)
            {
                Square square = board[posY+2][posX-1];
                if (square.getOccupiedBy().getColor() == "clear")
                {
                    list.Add(square.getPosition());
                }
                else if (square.getOccupiedBy().getColor() == "black")
                {
                }
                else if (square.getOccupiedBy().getColor() == "white")
                {
                    list.Add(square.getPosition());
                }
            }

            if (posY+2 !> 7 && posX+1 !> 7)
            {
                Square square = board[posY+2][posX+1];
                if (square.getOccupiedBy().getColor() == "clear")
                {
                    list.Add(square.getPosition());
                }
                else if (square.getOccupiedBy().getColor() == "black")
                {
                }
                else if (square.getOccupiedBy().getColor() == "white")
                {
                    list.Add(square.getPosition());
                }
            }

            if (posY-1 !< 0 && posX-2 !< 0)
            {
                Square square = board[posY-1][posX-2];
                if (square.getOccupiedBy().getColor() == "clear")
                {
                    list.Add(square.getPosition());
                }
                else if (square.getOccupiedBy().getColor() == "black")
                {
                }
                else if (square.getOccupiedBy().getColor() == "white")
                {
                    list.Add(square.getPosition());
                }
            }

            if (posY+1 !> 7 && posX-2 !< 0)
            {
                Square square = board[posY+1][posX-2];
                if (square.getOccupiedBy().getColor() == "clear")
                {
                    list.Add(square.getPosition());
                }
                else if (square.getOccupiedBy().getColor() == "black")
                {
                }
                else if (square.getOccupiedBy().getColor() == "white")
                {
                    list.Add(square.getPosition());
                }
            }

        }

        else
        {
            Console.WriteLine("some color other than 'white' or 'black' was given to the 'KnightMove' method.");
        }

        return list;

    }

    private List<Position> PawnForwardMove(List<List<Square>> board, Position position)
    {

        List<Position> list = new List<Position> {};

        int posX = position.getPosition()[0];
        int posY = position.getPosition()[1];

        if (_currentColor == "white")
        {

            if (posY+1 !> 7)
            {
                Square square = board[posY+1][posX];
                if (square.getOccupiedBy().getColor() == "clear")
                {
                    list.Add(square.getPosition());
                }
                else if (square.getOccupiedBy().getColor() == "black" || square.getOccupiedBy().getColor() == "white")
                {
                }
                
            }

            if (posY == 1)
            {
                Square square = board[posY+2][posX];
                if (square.getOccupiedBy().getColor() == "clear")
                {
                    list.Add(square.getPosition());
                }
                else if (square.getOccupiedBy().getColor() == "black" || square.getOccupiedBy().getColor() == "white")
                {
                }
                
            }

        }

        else if (_currentColor == "black")
        {

            if (posY-1 !> 0)
            {
                Square square = board[posY-1][posX];
                if (square.getOccupiedBy().getColor() == "clear")
                {
                    list.Add(square.getPosition());
                }
                else if (square.getOccupiedBy().getColor() == "black" || square.getOccupiedBy().getColor() == "white")
                {
                }
                
            }

            if (posY == 6)
            {
                Square square = board[posY-2][posX];
                if (square.getOccupiedBy().getColor() == "clear")
                {
                    list.Add(square.getPosition());
                }
                else if (square.getOccupiedBy().getColor() == "black" || square.getOccupiedBy().getColor() == "white")
                {
                }
                
            }

        }

        else
        {
            Console.WriteLine("some color other than 'white' or 'black' was given to the 'PawnForwardMove' method.");
        }

        return list;

    }

    private List<Position> PawnTakeMove(List<List<Square>> board, Position position)
    {

        List<Position> list = new List<Position> {};

        int posX = position.getPosition()[0];
        int posY = position.getPosition()[1];

        if (_currentColor == "white")
        {
            if (posY+1 !> 7)
            {
                if (posX+1 !> 7)
                {
                    Square square = board[posY+1][posX+1];
                    if (square.getOccupiedBy().getColor() == "black")
                    {
                        list.Add(square.getPosition());
                    }
                    else if (square.getOccupiedBy().getColor() == "clear" || square.getOccupiedBy().getColor() == "white")
                    {
                    }
                }
                else if (posX-1 !< 0)
                {
                    Square square = board[posY+1][posX-1];
                    if (square.getOccupiedBy().getColor() == "black")
                    {
                        list.Add(square.getPosition());
                    }
                    else if (square.getOccupiedBy().getColor() == "clear" || square.getOccupiedBy().getColor() == "white")
                    {
                    }
                }
            }
        }

        else if (_currentColor == "black")
        {
            if (posY-1 !> 7)
            {
                if (posX+1 !> 7)
                {
                    Square square = board[posY+1][posX+1];
                    if (square.getOccupiedBy().getColor() == "white")
                    {
                        list.Add(square.getPosition());
                    }
                    else if (square.getOccupiedBy().getColor() == "clear" || square.getOccupiedBy().getColor() == "black")
                    {
                    }
                }
                else if (posX-1 !< 0)
                {
                    Square square = board[posY+1][posX-1];
                    if (square.getOccupiedBy().getColor() == "white")
                    {
                        list.Add(square.getPosition());
                    }
                    else if (square.getOccupiedBy().getColor() == "clear" || square.getOccupiedBy().getColor() == "black")
                    {
                    }
                }
            }
        }

        else
        {
            Console.WriteLine("some color other than 'white' or 'black' was given to the 'PawnTakeMove' method.");
        }

        return list;

    }



}


