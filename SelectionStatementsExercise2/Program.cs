namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            FavSubject();
        }

        public static void FavSubject()
        {
            Console.WriteLine("What is your favorite subject?");
            string subject = (Console.ReadLine() ?? "").Trim();



            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is great for problem-solving!");
                    break;
                case "science":
                    Console.WriteLine("Science helps us understand the world!");
                    break;
                case "history":
                    Console.WriteLine("History teaches us about our past!");
                    break;
                case "art":
                    Console.WriteLine("Art allows for creative expression!");
                    break;
                case "music":
                    Console.WriteLine("Music makes the world go round!");
                    break;
                default:
                    Console.WriteLine("That's an interesting subject!");
                    break;

            }
            

        }
    }
}