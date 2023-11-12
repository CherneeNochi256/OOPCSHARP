namespace Lab4;

public struct GameResults
{
    private int goalsInWinningGames = 0;
    private int concededsInWinningGames = 0;
    private int goalsInLosingGames = 0;
    private int concededsInLosingGames = 0;
    private int goalsInTieGames = 0;
    private int concededsInTieGames = 0;

    public GameResults()
    {
    }

    public int GoalsInWinningGames
    {
        get => goalsInWinningGames;
        set => goalsInWinningGames = value;
    }

    public int ConcededsInWinningGames
    {
        get => concededsInWinningGames;
        set => concededsInWinningGames = value;
    }

    public int GoalsInLosingGames
    {
        get => goalsInLosingGames;
        set => goalsInLosingGames = value;
    }

    public int ConcededsInLosingGames
    {
        get => concededsInLosingGames;
        set => concededsInLosingGames = value;
    }

    public int GoalsInTieGames
    {
        get => goalsInTieGames;
        set => goalsInTieGames = value;
    }

    public int ConcededsInTieGames
    {
        get => concededsInTieGames;
        set => concededsInTieGames = value;
    }
}