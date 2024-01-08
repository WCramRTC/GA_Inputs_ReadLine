namespace GA_Inputs_ReadLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asking for the user's name
            Console.WriteLine("What is your name?");

            // Reading user input for the name
            string userName = Console.ReadLine();

            // Responding to user input with a greeting
            Console.WriteLine("Hello, " + userName + "!");

            // Asking for the user's favorite color
            Console.WriteLine("What is your favorite color?");

            // Reading user input for the favorite color
            string favoriteColor = Console.ReadLine();

            // Responding with the favorite color
            Console.WriteLine("Ah, " + favoriteColor + " is a great color!");

            // Combining information for a final message
            Console.WriteLine(userName + ", who likes " + favoriteColor + ", welcome to the program!");
        } // End main

    } // class

} // namespace
