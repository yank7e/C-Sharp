public class Task2 : ITask
{
    public void Execute()
    {
        Console.WriteLine("Завдання 2:");
        double a = 3, b = 4, c = 5;

        if (!IsValidTriangle(a, b, c))
        {
            Console.WriteLine("Неможливо утворити трикутник із заданими сторонами.");
            return;
        }

        double perimeter = a + b + c;
        double semiPerimeter = perimeter / 2;
        double area = Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));

        Console.WriteLine($"Периметр трикутника: {perimeter}");
        Console.WriteLine($"Площа трикутника: {area}");
        Console.WriteLine($"Вид трикутника: {GetTriangleType(a, b, c)}");
        Console.WriteLine();
    }

    private bool IsValidTriangle(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }

    private string GetTriangleType(double a, double b, double c)
    {
        if (a == b && b == c)
        {
            return "Рівносторонній";
        }
        else if (a == b || a == c || b == c)
        {
            return "Рівнобедрений";
        }
        else
        {
            return "Різносторонній";
        }
    }
}