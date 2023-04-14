using UtilityLibraries;

class Program
{
    static void Main(string[] args)
    {
        int row = 0;

        do
        {
            if (row == 0 || row >= 25)
                ResetConsole();

            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) break;
            Console.WriteLine($"Input: {input}");
            Console.WriteLine("Entered String Starts with uppercase? " +
                 $"{(input.StartsWithUpper() ? "Yes" : "No")}");
            Console.WriteLine();
            row += 2;
        } while (true);

        return;

        // Declare a ResetConsole local method
        void ResetConsole()
        {
            if (row > 0)
            {
                Console.WriteLine("Press any key to continue......");
                Console.ReadKey();
            }

            Console.Clear();
            Console.WriteLine($"{Environment.NewLine}Enter a string input and press enter:{Environment.NewLine}");
            row = 3;
        }
    }
}