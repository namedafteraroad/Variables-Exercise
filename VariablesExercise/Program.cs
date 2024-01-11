namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            string newPark = "Jurassic Park: Alabama";
            int numberOfDinos = 384;
            char dangerLevel = 'H';
            bool securityClearance = true;
            double avgDollarSpent = 523.56;
            decimal dinoGenomeProgress = 52342346.44233424342424m;
            
            Console.WriteLine($"Hello, welcome to {newPark}!");
            Console.WriteLine($"{newPark} is happy that you have chosen to spent your career with us!");
            Console.WriteLine($"We currently have {numberOfDinos} dinosaurs at our park.");
            Console.WriteLine($"Please exercise caution. The current warning level is set at {dangerLevel}. A fairly safe level, but again exercise caution");
            Console.WriteLine($"{newPark} has approved your security clearance: {securityClearance}");
            Console.WriteLine($"Internal use only: we can move forward with Project x354. The desired income per customer is $300 with 25000 visitors. We exceeded that with a return of {avgDollarSpent} and 32,000 visitors ");
            Console.WriteLine($"Current genome progress: {dinoGenomeProgress}. With your help we will be able to continue to understand how these creatures are created. The more we know the better we can serve our customers and create new and exciting dinos for the world to see");
            Console.WriteLine($"I hope your new career here at {newPark} is a mutually beneficial. Also I hope your accomidations are to your liking, we sparred no expense.");
            
        }
    }
}
