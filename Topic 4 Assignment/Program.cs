using System.Diagnostics;

namespace Topic_4_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name, firstName, lastName;
            int age, grade, olderAge, number;
            Double perHour;

            number = 5;

            
            Console.WriteLine("Hello! " + "What is your name?");
            name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Your name is: " + name);
            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine("Hello " + name + "! " + "How old are you?");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("The age you entered is: " + age);
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("So you're " + age + " Huh? " + "That isn't very old.");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("How much do you make " + name + "?");
            Console.WriteLine();
            Double.TryParse(Console.ReadLine(), out perHour);
            Console.WriteLine(perHour + "! " + "That isn't bad as long as it's per hour " + name + ".");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Now please enter the following information shown as follows:");
            Console.WriteLine();
            firstName = Console.ReadLine();
            Console.WriteLine("First name: " + firstName);
            Console.WriteLine();
            lastName = Console.ReadLine();  
            Console.WriteLine("Last name: " + lastName);
            Console.WriteLine();
            grade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Grade 9-12: " + grade);
            Console.WriteLine();
            Console.WriteLine("");
            //Working on rest of assignment, MAKE SURE TO COME BACK TO THIS ABOVE
            Console.WriteLine();
            Console.WriteLine("Hello! " + "What is your name?");
            name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Your name is: " + name);
            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine("Hello " + name + "! " + "How old are you?");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("The age you entered is: " + age);
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("");


        }
    }
}
