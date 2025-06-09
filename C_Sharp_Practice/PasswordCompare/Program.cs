class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Password : ");
        string pass = Console.ReadLine();

        Console.WriteLine("Confirm Password: ");
        string pass2 = Console.ReadLine();

        if (!pass.Equals(string.Empty))
        {
            if (!pass2.Equals(string.Empty))
            {
                if(pass.Length >=6 && pass2.Length >=6)
                {
                    if (pass.Equals(pass2))
                    {
                        Console.WriteLine("Match");
                    }
                    else
                    {
                        Console.WriteLine("Not Match");
                    }
                }
                else
                {
                    Console.WriteLine("Enter 6 or more character.");
                }
            }
            else
            {
                Console.WriteLine("Enter password for confirmation.");
            }
        }
        else
        {
            Console.WriteLine("Enter a password.");
        }
    }
}