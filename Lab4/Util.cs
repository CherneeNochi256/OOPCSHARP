namespace Lab4;

public class Util
{
    // Метод для генерации случайного массива
    public static int[] GenerateRandomArray(int size)
    {
        Random random = new Random();
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(100);
        }
        return array;
    }

    // Метод для печати массива
    public static void PrintArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
    
    
    public static void printOutResults(GameResults gameResults)
    {
        // Вывод результатов
        Console.WriteLine($"Забито мячей в выигрышных играх: {gameResults.GoalsInWinningGames}");
        Console.WriteLine($"Забито мячей в проигрышных играх: {gameResults.GoalsInLosingGames}");
        Console.WriteLine($"Забито мячей в ничейных играх: {gameResults.GoalsInTieGames}");
        Console.WriteLine($"Пропущено мячей в выигрышных играх: {gameResults.ConcededsInWinningGames}");
        Console.WriteLine($"Пропущено мячей в проигрышных играх: {gameResults.ConcededsInLosingGames}");
        Console.WriteLine($"Пропущено мячей в ничейных играх: {gameResults.ConcededsInTieGames}");
    }
}