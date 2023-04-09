namespace CheckInput
{
    public class Check
    {
        public static string NotEmptyString()
        {
            bool checkString = false;
            string input;
            do
            {
                input = Console.ReadLine();
                if (String.IsNullOrEmpty(input))
                {
                    Console.WriteLine("You must write a text");
                    Console.WriteLine("Try it again:");
                }
                else
                    checkString = true;
            } while (checkString == false);
            return input;
        }


        public static int PositiveIntCheck()
        {
            int option;
            bool checkInt = false;
            do
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out option))
                {
                    if (option > 0)
                    {
                        checkInt = true;
                    }

                    else
                    {
                        Console.WriteLine("The inserted integer must be positive\n");
                        Console.WriteLine("Try it again:");
                    }
                }
                else
                {
                    Console.WriteLine("Input must be a positive integer\n");
                    Console.WriteLine("Try it again:");
                }
            } while (checkInt == false);
            return option;
        }
    }
}