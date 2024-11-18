public class Task3 : ITask
{
    public void Execute()
    {
        Console.WriteLine("Завдання 3:");
        int[] array = { 5, 7, 3, 12, 4, 8, 9, 1, 15, 2, 6, 10, 11 };
        int groupNumber = 7; // Замість "7" підставляється ваша остання цифра порядкового номеру у списку групи
        int arrayLength = 10 + groupNumber;

        if (array.Length != arrayLength)
        {
            Console.WriteLine($"Довжина масиву має бути {arrayLength}, але отримано {array.Length}.");
            return;
        }

        int min = array[0];
        int max = array[0];

        foreach (int number in array)
        {
            if (number < min)
            {
                min = number;
            }
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine("Масив: " + string.Join(", ", array));
        Console.WriteLine($"Мінімальне значення: {min}");
        Console.WriteLine($"Максимальне значення: {max}");
        Console.WriteLine();
    }
}