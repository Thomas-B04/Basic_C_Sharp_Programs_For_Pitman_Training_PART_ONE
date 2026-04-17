namespace Student_Report
{
    /// <summary>
    /// Main program class for the Academy of Learning Career College Student Daily Report application.
    /// This console application collects daily feedback and progress information from students.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Entry point for the Student Daily Report application.
        /// Collects student information including name, course details, progress, help requirements,
        /// experiences, feedback, and study hours, then displays a summary of the submitted information.
        /// </summary>
        static void Main()
        {
            // Display application header
            Console.WriteLine("Academy of Learning Career College");
            Console.WriteLine("Student Daily Report");

            // Collect student's name (strings automatically accept any text input)
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            // Collect current course information
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();

            // Collect current page number in course materials (validate integer input)
            Console.WriteLine("What page number?");
            int pageNumber;
            while (!int.TryParse(Console.ReadLine(), out pageNumber))
            {
                Console.WriteLine("Invalid input. Please enter a valid number:");
            }

            // Determine if student requires assistance (validate boolean input)
            Console.WriteLine("Do you need any help with anything? Please answer \"true\" or \"false\".");
            bool needsHelp;
            while (!bool.TryParse(Console.ReadLine(), out needsHelp))
            {
                Console.WriteLine("Invalid input. Please enter \"true\" or \"false\":");
            }

            // Collect positive experiences from the student
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExperience = Console.ReadLine();

            // Collect additional feedback from the student
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            // Collect number of hours studied today (validate integer input)
            Console.WriteLine("How many hours did you study today?");
            int hoursStudied;
            while (!int.TryParse(Console.ReadLine(), out hoursStudied))
            {
                Console.WriteLine("Invalid input. Please enter a valid number:");
            }

            // Display summary of collected information
            Console.WriteLine($"Hello, {name}!");
            Console.WriteLine($"You are currently enrolled in the {course} course.");
            Console.WriteLine($"You are currently on page {pageNumber}.");
            Console.WriteLine($"It is {needsHelp} that you need help with something.");
            Console.WriteLine($"You shared the following positive experience: {positiveExperience}");
            Console.WriteLine($"You provided the following feedback: {feedback}");
            Console.WriteLine($"You studied for {hoursStudied} hours today.");
            
            // Display closing message
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
        }
    }
}