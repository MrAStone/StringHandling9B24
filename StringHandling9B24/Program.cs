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
            Console.WriteLine(first[100]);



        }
    }
}
