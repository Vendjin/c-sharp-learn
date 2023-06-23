internal class Program
{
    private static void Main(string[] args)
    {
        //ReadLine - метод для ввода в консоль
        string name = Console.ReadLine();

        Console.WriteLine($"Привет {name}");

        //Конвертация типа
        int a1 = Convert.ToInt32(Console.ReadLine());
        int a2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(a1+a2);

        


        //Арифметические операции
        int a = 5;
        int b = 10;

        int c = a + b;
        Console.WriteLine(c);

        Console.ReadKey();

    }
}