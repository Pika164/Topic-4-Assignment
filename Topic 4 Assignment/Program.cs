using System.Diagnostics;

namespace Topic_4_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name, firstName, lastName, login, item1, item2;
            int age, grade, studentID, number;
            Double perHour, average, num1, num2, num3, price1, price2;

            number = 5;

            
            Console.Write("Hello! " + "What is your name? ");
            name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Your name is: " + name);
            Console.WriteLine();
            Console.Write("Hello " + name + "! " + "How old are you? ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("The age you entered is: " + age);
            Console.WriteLine();
            Console.WriteLine("So you're " + age + " Huh? " + "That isn't very old.");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("How much do you make " + name + "? ");
            Double.TryParse(Console.ReadLine(), out perHour);
            Console.WriteLine();
            Console.WriteLine(perHour + "! " + "That isn't bad as long as it's per hour " + name + ".");
            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine("Now please enter the following information shown as follows:");
            Console.WriteLine();
            Console.Write("First name: ");
            firstName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Last name: ");
            lastName = Console.ReadLine();  
            Console.WriteLine();
            Console.Write("Grade 9-12: ");
            grade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Student ID: ");
            studentID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Login: ");
            login = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Average: ");
            Double.TryParse(Console.ReadLine(), out average);
            Console.WriteLine();
            Console.WriteLine("Your information:");
            Console.WriteLine();
            Console.WriteLine("\tlogin:\t" + login);
            Console.WriteLine("\tID:\t" + studentID);
            Console.WriteLine("\tName:\t" + firstName + ", " + lastName);
            Console.WriteLine("\tAverage: " + average + "%");
            Console.WriteLine("\tGrade:\t" + grade);
            Console.ReadLine();
            Console.WriteLine();
            Console.Write("Hello! " + "What is your name? ");
            name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Hello " + name + "! " + "How old are you? ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Did you know that in five years you will be " + (age + number) + " Years old? " + " And five years ago you were " + (age - number) + "! " + "Imagine that!");
            Console.WriteLine();
            Console.WriteLine("Please enter three numbers below:");
            Console.Write("Number 1: ");
            Double.TryParse(Console.ReadLine(), out num1);
            Console.WriteLine();
            Console.Write("Number 2: ");
            Double.TryParse(Console.ReadLine(), out num2);
            Console.WriteLine();
            Console.Write("Number 3: ");
            Double.TryParse(Console.ReadLine(), out num3);
            Console.WriteLine();
            Console.WriteLine("Your Total when divided by 2 is: " + ((num1 + num2 + num3)/2));
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Sales Receipt");
            Console.WriteLine();
            Console.Write("Item 1: ");
            item1 = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Price 1: ");
            Double.TryParse(Console.ReadLine(), out price1);
            Console.WriteLine();
            Console.Write("Item 2: ");
            item2 = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Price 2: ");
            Double.TryParse(Console.ReadLine(), out price2);
            Console.WriteLine();
            Console.WriteLine("======================");
            Console.WriteLine();
            Console.WriteLine("\tTotal:\t" + (price1 + price2));
            Console.ReadLine();



        }
    }
}
