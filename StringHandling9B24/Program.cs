namespace StringHandling9B24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string first = "This is a string";
            string second = "This is a another string";
            //Length of a string
            Console.WriteLine(first.Length);
            Console.WriteLine(second.Length);
            //Position
            Console.WriteLine(first[0]); // the first character in a string
            Console.WriteLine(first[first.Length-1]);
            Console.WriteLine(first.IndexOf('s')); //3 because it is the 4th character
            Console.WriteLine(first.IndexOf('Z')); //-1 becauase it isn't there
                                                   // Console.WriteLine(first[100]);

            int userNumber;
            Console.Write("Enter a number: ");
            userNumber =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine(userNumber);
            double userDecimalNumber;
            Console.Write("Enter a decimal number: ");
            userDecimalNumber = Convert.ToDouble( Console.ReadLine());
            Console.WriteLine(userDecimalNumber);
            string numString = userNumber.ToString();
            char myChar = 'A';
            Console.WriteLine(Convert.ToInt32(myChar));
            myChar = 'a';
            Console.WriteLine(Convert.ToInt32(myChar));
            myChar = '0';
            Console.WriteLine(Convert.ToInt32(myChar));

            //Find the ASCII Score for my name
            string name;
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            int sum = 0;
            for(int i = 0;i<name.Length;i++)
            {
                sum +=Convert.ToInt32(name[i]);
            }
            Console.WriteLine(sum);

            int numChar = 42;
            Console.WriteLine(Convert.ToChar(numChar));

        }
    }
}
