using System;

namespace MethodsExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            //Name: Jael
            // Age: 16
            //Favorite Color: Yellow
            //Favorite Animal: Elephant
            //Favorite Band: BTS
            //City: Arlington
            //State: Massachusetts

            string studentname = "Jael";
            string favcolor = "yellow";
            string studentstate = "Massachusetts";

            string username = GetUserResponse($"Hello - What is your name?");
            

            Console.WriteLine($"Hi {studentname}, How old are you?");
            string age = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();

            Console.WriteLine($"{favcolor} is a cool color! now What is your favorite animal?");
            string animal = Console.ReadLine();

            Console.WriteLine("Interesting. Could you please tell me What is your favorie band?");
            string bandname = Console.ReadLine();

            Console.WriteLine("Nice. In what state and city do you live?");
            string citystate = Console.ReadLine();

            Console.WriteLine($"Really! {studentstate} is a cold state. some of my cousins went to school there. Do you work?");
            string occupation = Console.ReadLine();

            //Part 2
            Console.WriteLine("What is the first number you want to add?");
            var num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the second number you want to add?");
            var num2 = int.Parse(Console.ReadLine());

            var additionResult = Sum(num1, num2);
            Console.WriteLine(additionResult);
        }
        public static int Sum(int num1, int num2)
        {
            // int sum = num1 + num2;
            // return sum;

            return num1 + num2;
        }

        public static string GetUserResponse(string question)
        {
            Console.WriteLine(question);

            return Console.ReadLine();
        }


    }
}
