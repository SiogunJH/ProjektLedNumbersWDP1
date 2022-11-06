namespace System
{
    class Program
    {
        static void Main()
        {
            char[] numbers = Console.ReadLine().ToCharArray();
            for (int ii = 1; ii <= 3; ii++)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    Display(numbers[i], ii);
                }
                Console.WriteLine();
            }
        }
        public static void Display(char number, int part)
        {
            switch (part)
            {
                case 1:
                    if (number != '1' && number != '4')
                        Console.Write(" _ ");
                    else
                        Console.Write("   ");
                    break;

                case 2:
                    if (number == '1' || number == '7')
                        Console.Write("  |");
                    else if (number == '2' || number == '3')
                        Console.Write(" _|");
                    else if (number == '4' || number == '8' || number == '9')
                        Console.Write("|_|");
                    else if (number == '5' || number == '6')
                        Console.Write("|_ ");
                    else //if (number == '0')
                        Console.Write("| |");
                    break;

                case 3:
                    if (number == '1' || number == '4' || number == '7' || number == '9')
                        Console.Write("  |");
                    else if (number == '3' || number == '5')
                        Console.Write(" _|");
                    else if (number == '6' || number == '8' || number == '0')
                        Console.Write("|_|");
                    else //if (number == '2')
                        Console.Write("|_ ");
                    break;
            }
        }
    }
}