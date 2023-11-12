using Lab4;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("---------------------4_1_a-----------------");
        Lab4_1_a();
        Console.WriteLine("---------------------4_1_b-----------------");
        Lab4_1_b();
        Console.WriteLine("---------------------4_2_1-----------------");
        Lab4_2_1();
        Console.WriteLine("---------------------4_2_2-----------------");
        Lab4_2_2();
        Console.WriteLine("---------------------4_3_a-----------------");
        Lab4_3_a();
        Console.WriteLine("---------------------4_3_b-----------------");
        Lab4_3_b();
    }

    static void Lab4_1_a()
    {
        // Генерация случайного массива
        int[] originalArray = Util.GenerateRandomArray(10);

        // Печать исходного массива
        Console.WriteLine("Исходный массив:");
        Util.PrintArray(originalArray);

        // Создание нового массива с тем же размером
        int[] newArray = Util.GenerateRandomArray(10);
        // Копирование второго, четвертого и т.д. элементов в новый массив
        for (int i = 1; i < originalArray.Length; i += 2)
        {
            newArray[i] = originalArray[i];
        }

        // Печать нового массива
        Console.WriteLine("Новый массив:");
        Util.PrintArray(newArray);
    }

    static void Lab4_1_b()
    {
        // Генерация случайного массива
        int[] originalArray = Util.GenerateRandomArray(10);

        // Печать исходного массива
        Console.WriteLine("Исходный массив:");
        Util.PrintArray(originalArray);

        // Создание нового массива с тем же размером
        int[] newArray = Util.GenerateRandomArray(10);
        int counter = 0;
        // Копирование второго, четвертого и т.д. элементов в новый массив
        for (int i = 1; i < originalArray.Length; i += 2)
        {
            newArray[counter] = originalArray[i];
            counter++;
        }

        // Печать нового массива
        Console.WriteLine("Новый массив:");
        Util.PrintArray(newArray);
    }

    static void Lab4_2_1()
    {
        GameResults gameResults = new GameResults();
        // Массивы с количеством забитых и пропущенных мячей
        int[] goals = Util.GenerateRandomArray(20);
        int[] conceded = Util.GenerateRandomArray(20);

        Console.WriteLine("Goals: ");
        Util.PrintArray(goals);
        Console.WriteLine("Conceded: ");
        Util.PrintArray(conceded);

        for (int i = 0; i < goals.Length; i++)
        {
            string result = "";
            if (goals[i] > conceded[i])
            {
                result = "выигрыш";
                gameResults.GoalsInWinningGames += goals[i];
                gameResults.ConcededsInWinningGames += conceded[i];
            }
            else if (goals[i] < conceded[i])
            {
                result = "проигрыш";
                gameResults.GoalsInLosingGames += goals[i];
                gameResults.ConcededsInLosingGames += conceded[i];
            }
            else
            {
                result = "ничья";
                gameResults.GoalsInTieGames += goals[i];
                gameResults.ConcededsInTieGames += conceded[i];
            }

            Console.WriteLine($"Игра {i + 1}: {result}");
        }

        Util.printOutResults(gameResults);
    }

    static void Lab4_2_2()
    {
        GameResults gameResults = new GameResults();
        // Массивы с количеством забитых и пропущенных мячей
        int[] goals = Util.GenerateRandomArray(20);
        int[] conceded = Util.GenerateRandomArray(20);
        string[] uselessArray = new string[20];

        Console.WriteLine("Goals: ");
        Util.PrintArray(goals);
        Console.WriteLine("Conceded: ");
        Util.PrintArray(conceded);

        for (int i = 0; i < goals.Length; i++)
        {
            string result = "";
            if (goals[i] > conceded[i])
            {
                result = "выигрыш";
                uselessArray[i] = result;
                gameResults.GoalsInWinningGames += goals[i];
                gameResults.ConcededsInWinningGames += conceded[i];
            }
            else if (goals[i] < conceded[i])
            {
                result = "проигрыш";
                uselessArray[i] = result;
                gameResults.GoalsInLosingGames += goals[i];
                gameResults.ConcededsInLosingGames += conceded[i];
            }
            else
            {
                result = "ничья";
                uselessArray[i] = result;
                gameResults.GoalsInTieGames += goals[i];
                gameResults.ConcededsInTieGames += conceded[i];
            }

            Console.WriteLine($"Игра {i + 1}: {result}");
        }

        Util.printOutResults(gameResults);
    }

     
       static void Lab4_3_a()
    {
        int[] birthYears = Util.GenerateRandomArray(30);
        Console.WriteLine("birthYears: ");
        Util.PrintArray(birthYears);

        // Find the maximum birth year
        int maxBirthYear = birthYears.Max();

        // Find the index of the maximum birth year
        int maxBirthYearIndex = Array.IndexOf(birthYears, maxBirthYear);
        Console.WriteLine($"{maxBirthYearIndex}");
    }
       
       static void Lab4_3_b()
       {
           int[] birthYears = Util.GenerateRandomArray(30);
           Console.WriteLine("birthYears: ");
           Util.PrintArray(birthYears);

           // Find the maximum birth year
           int maxBirthYear = birthYears.Max();

           // Find the index of the maximum birth year
           int maxBirthYearIndex = Array.LastIndexOf(birthYears, maxBirthYear);
           Console.WriteLine($"{maxBirthYearIndex}");
       }
}