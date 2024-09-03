// See https://aka.ms/new-console-template for more information

// A calculator program that can perform basic arithmetic operations
// such as addition, subtraction, multiplication, and division.

// Variables
int choice = 0;
int num1, num2 = 0;

// Calculator Options
while (choice != -1)
{
    try
    {

        //Welcome message
        Console.WriteLine("***************** Welcome to the Calculator! *****************");
        Console.WriteLine("Choose an operation (enter -1 to quit):");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Fibonacci sequence");

        choice = Convert.ToInt32(Console.ReadLine());
    
        if (choice == -1)
        {
            break;
        }

        Console.Clear();

        Console.WriteLine("Enter the first number");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number");
        num2 = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Addition Result:");
                Console.WriteLine(num1 + num2);
                break;

            case 2:
                Console.WriteLine("Subtraction Result:");
                Console.WriteLine(num1 - num2);
                break;

            case 3:
                Console.WriteLine("Multiplication Result:");
                Console.WriteLine(num1 * num2);
                break;
            case 4:
                Console.WriteLine("Division Result:");
                Console.WriteLine(num1 / num2);
                break;
            case 5:
                Console.WriteLine("Fibonacci sequence:");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(num1 + " " + num2);
                    num1 += num2;
                    num2 += num1;
                }
                break;
            default:
                Console.WriteLine("Invalid Choice");
                break;
        }
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        Console.WriteLine("Press any key...");
        Console.ReadKey();
        Console.Clear();
    }
}
