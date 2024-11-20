namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create a program that allows a user to play a game where they must guess what your favorite number is:
            //Using a random number generator for number to guess

            var r = new Random();
            var favNumber = r.Next(1, 5);
            

            Console.WriteLine("Guess the number 1 - 5");

            bool correctGuess = false;

            while (!correctGuess)
            {
                var userInput = int.Parse(Console.ReadLine());

                if (userInput > favNumber)
                {
                    Console.WriteLine("Too High");
                }
                else if (userInput < favNumber)
                {
                    Console.WriteLine("Too Low");
                }
                else
                {
                    Console.WriteLine("Thats correct!");
                    correctGuess = true;
                }
            }
            


            Console.WriteLine("Whats your favorite school subject?");
            string favoriteSubject = Console.ReadLine().ToLower();

            switch (favoriteSubject)
            {
                case "math":
                    Console.WriteLine("Do numbers love you as much as you love them? You bet!");
                    break;
                case "english":
                    Console.WriteLine("Something about getting lost in a good book.. or trying to figure out when to use a comma correctly..");
                    break;
                case "history":
                    Console.WriteLine("Abe Lincoln Rocked!");
                    break;
                case "science":
                    Console.WriteLine("The Magic School Bus was my jam. Dissecting frogs.. not so much.");
                    break;
                case "band":
                    Console.WriteLine("Boom, Snap, Clap!");
                    break;
                default:
                    Console.WriteLine($"Interesting choice! Ive never heard of {favoriteSubject} before.");
                    break;
            }

            Console.ReadKey();




        }
    }
}
