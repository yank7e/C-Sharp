public class Task4 : ITask
{
    public void Execute()
    {
        Console.WriteLine("Завдання 4:");
        int[] array = { -5, 7, 0, -12, 4, 8, -9, 1, 15, -2, 6, 10, -11 };
        int m = 5;
        int groupNumber = 7; // Замість "7" підставляється ваша остання цифра порядкового номеру у списку групи
        int arrayLength = 10 + groupNumber;

        if (array.Length != arrayLength)
        {
            Console.WriteLine($"Довжина масиву має бути {arrayLength}, але отримано {array.Length}.");
            return;
        }

        int[] filteredArray = Array.FindAll(array, element => Math.Abs(element) > m);

        Console.WriteLine($"Задане число M: {m}");
        Console.WriteLine("Масив X: " + string.Join(", ", array));
        Console.WriteLine("Новий масив Y: " + string.Join(", ", filteredArray));
        Console.WriteLine();
    }
}