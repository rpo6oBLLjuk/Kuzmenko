

public static class Programm
{
    public static void Main()
    {
        while (true)
        {
            Qwerty();
        }
    }

    public static void Qwerty()
    {
        Console.Write("Введите тип ошибки:\n 1. DivideByZeroException\n 2. FormatException\n 3. DirectoryNotFoundException\n 4. CustomException\n\nТип: ");
        int choice;
        try
        {
            choice = int.Parse(Console.ReadLine());
        }
        catch (Exception ex)
        {
            Console.WriteLine("> Некорректный ввод. Введите число от 1 до 4.\n\n");
            return;
        }

        Console.Write("> ");

        switch (choice)
        {
            case 1:
                try
                {
                    int zero = 0;
                    int result = 10 / zero;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Деление на 0 невозможно");
                }
                break;
            case 2:
                try
                {
                    int invalidNumber = int.Parse("не число");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Попытка преобразовать не числовую строку в число");
                }
                break;

            case 3:
                try
                {
                    Directory.GetFiles("C:/несуществующая_папка");
                }
                catch (DirectoryNotFoundException ex)
                {
                    Console.WriteLine("Невозможно обратиться к несуществующей директории");
                }
                break;

            case 4:
                try
                {
                    throw new MyCustomException();
                }
                catch (MyCustomException ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                break;

            default:
                Console.WriteLine("Неизвестный выбор");
                break;
        }

        Console.WriteLine("\n");
    }
}

public class MyCustomException : Exception
{
    public override string Message => "Моя кастомная ошибка";
}