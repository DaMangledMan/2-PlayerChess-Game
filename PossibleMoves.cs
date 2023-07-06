public class PossibleMoves
{
    // attributes

    // constructor

    // methods

    //  public

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

    public List<Position> checkRookMoves(List<List<Square>> board, Position position)
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
        
    }

    public List<Position> checkPawnMoves(List<List<Square>> board, Position position)
    {
        
    }

    //  private

    private List<Position> KingMove(List<List<Square>> board, Position position)
    {

    }

    private List<Position> CastlingKingSideMove(List<List<Square>> board, Position position)
    {

    }
    
    private List<Position> CastlingQueenSideMove(List<List<Square>> board, Position position)
    {

    }

    private List<Position> RookHorizontalMove(List<List<Square>> board, Position position)
    {

    }

    private List<Position> RookVerticalMove(List<List<Square>> board, Position position)
    {

    }

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

    private List<Position> EnPassantMove(List<List<Square>> board, Position position)
    {

    }
}