using System;

namespace testGit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = string.Empty;
            string surname = string.Empty;
            int age = 0;
<<<<<<< HEAD
            int height = 0;
=======
            int weight = 0;
>>>>>>> weight
            int responce = 0;
            while (responce != -1)
            {
                Console.WriteLine("Enter 0 to enter your name" + Environment.NewLine +
                                    "Enter 1 to enter your surname" + Environment.NewLine +                                    
                                    "Enter 2 to enter your age" + Environment.NewLine +
<<<<<<< HEAD
                                    "Enter 3 to enter your height" + Environment.NewLine +
=======
                                    "Enter 4 to enter your weight" + Environment.NewLine +
>>>>>>> weight
                                    "Enter -2 to print resume" + Environment.NewLine +
                                    "Enter -1 to EXIT");
                responce = int.Parse(Console.ReadLine());
                switch (responce)
                {
                    case 0:
                        {
                            Console.WriteLine("Enter your name");
                            name = Console.ReadLine();
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("Enter your surname");
                            surname = Console.ReadLine();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter your age");
                            age = int.Parse(Console.ReadLine());
                            break;
                        }
<<<<<<< HEAD
                    case 3:
                        {
                            Console.WriteLine("Enter your height");
                            height = int.Parse(Console.ReadLine());
=======
                    case 4:
                        {
                            Console.WriteLine("Enter your weight");
                            weight = int.Parse(Console.ReadLine());
>>>>>>> weight
                            break;
                        }
                    case -2:
                        {
                            Console.WriteLine(name);
                            Console.WriteLine(surname);
                            Console.WriteLine(age);
<<<<<<< HEAD
                            Console.WriteLine(height);
=======
                            Console.WriteLine(weight);
>>>>>>> weight
                            break;
                        }
                    case -1:
                        {
                            Console.WriteLine("You exited program");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("You entered wrong number");
                            break;
                        }
                }
            }
        }
    }
}