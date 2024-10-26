using System;

class Program
{
    static void Main()
    {
        Program program = new Program();
        program.Run();
    }

    public void Run()
    {
        HelloWorldLoop();
        NumberCount();
        bool accessGranted = DoorKeypadEntry();

        if (accessGranted)
        {
            Console.WriteLine("Access granted. Welcome!");
        }
        else
        {
            Console.WriteLine("Too many incorrect attempts. Access denied.");
        }
    }

    public void HelloWorldLoop()
    {
        char continueResponse;
        do
        {
            Console.WriteLine("Hello, World!");
            Console.Write("Would you like to continue (y/n)? ");
            continueResponse = Console.ReadKey().KeyChar;
            Console.WriteLine();
        } while (continueResponse == 'y' || continueResponse == 'Y');

        Console.WriteLine("Goodbye!");
    }

    public void NumberCount()
    {
        char continueResponse;

        do
        {
            Console.Write("Enter a number: ");
            int number;

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Invalid input. Please enter a valid integer: ");
            }

            for (int i = number; i >= 0; i--)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            for (int i = 0; i <= number; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.Write("Would you like to continue (y/n)? ");
            continueResponse = Console.ReadKey().KeyChar;
            Console.WriteLine();
        } while (continueResponse == 'y' || continueResponse == 'Y');

        Console.WriteLine("Goodbye!");
    }

    public bool DoorKeypadEntry()
    {
        const string correctCode = "13579";
        int attempts = 0;
        const int maxAttempts = 5;

        while (attempts < maxAttempts)
        {
            Console.Write("Enter the keypad code: ");
            string enteredCode = Console.ReadLine();

            if (enteredCode == correctCode)
            {
                return true;
            }
            else
            {
                attempts++;
                Console.WriteLine("Incorrect code. Try again.");
            }
        }

        return false;
    }
}