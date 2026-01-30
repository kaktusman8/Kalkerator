namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== МАЛЕНЬКАЯ АНКЕТА ===\n");

            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите ваш возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n=== РЕЗУЛЬТАТЫ АНКЕТЫ ===");
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Возраст: {age} лет");

            if (age >= 18)
                Console.WriteLine("Вы совершеннолетний(яя)");
            else
                Console.WriteLine("Вы несовершеннолетний(яя)");
        }
    }
}
