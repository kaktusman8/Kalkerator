namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ПРОСТОЙ КАЛЬКУЛЯТОР (+ - * /)");
            Console.WriteLine("=============================");

            bool continueCalculating = true;

            while (continueCalculating)
            {
                try
                {
                    Console.Write("\nВведите первое число: ");
                    double number1 = GetValidNumber();

                    Console.Write("Введите оператор (+, -, *, /): ");
                    char operation = GetValidOperator();

                    Console.Write("Введите второе число: ");
                    double number2 = GetValidNumber();

                    double result = Calculate(number1, number2, operation);
                    DisplayResult(number1, number2, operation, result);

                    continueCalculating = AskToContinue();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }

            Console.WriteLine("\nПрограмма завершена. Спасибо!");
        }

        // Метод для получения корректного числа
        static double GetValidNumber()
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (double.TryParse(input, out double number))
                {
                    return number;
                }

                Console.Write("Ошибка! Введите корректное число: ");
            }
        }

        // Метод для получения корректного оператора
        static char GetValidOperator()
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input.Length == 1 && IsValidOperator(input[0]))
                {
                    return input[0];
                }

                Console.Write("Ошибка! Введите один из операторов: +, -, *, /: ");
            }
        }

        // Проверка валидности оператора
        static bool IsValidOperator(char op)
        {
            return op == '+' || op == '-' || op == '*' || op == '/';
        }

        // Основной метод вычислений
        static double Calculate(double a, double b, char operation)
        {
            switch (operation)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '/':
                    if (b == 0)
                    {
                        throw new DivideByZeroException("Деление на ноль невозможно!");
                    }
                    return a / b;
                default:
                    throw new ArgumentException("Недопустимый оператор");
            }
        }

        // Метод для отображения результата
        static void DisplayResult(double a, double b, char op, double result)
        {
            Console.WriteLine($"\n{a} {op} {b} = {result}");
        }

        // Метод для запроса продолжения
        static bool AskToContinue()
        {
            Console.Write("\nХотите выполнить еще одно вычисление? (да/нет): ");
            string answer = Console.ReadLine().ToLower();

            return answer == "да" || answer == "д" || answer == "yes" || answer == "y";
        }
    }
}
