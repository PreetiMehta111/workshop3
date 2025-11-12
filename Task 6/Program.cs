using System;

class ErrorHandling
{
    public void ConvertInput()
    {
        try
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You entered: " + number);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number format");
        }
        finally
        {
            Console.WriteLine("Program Executed");
        }
    }

    public void CheckPassword()
    {
        try
        {
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            if (password.Length < 6)
            {
                throw new Exception("Password must be at least 6 characters.");
            }
            else
            {
                Console.WriteLine("Password satisfied the requirement");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static void Main()
    {
        ErrorHandling obj = new ErrorHandling();
        obj.ConvertInput();
        obj.CheckPassword();
    }
}
