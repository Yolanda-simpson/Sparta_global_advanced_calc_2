using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advanced_calc_2
{
    class Program
    {
        static double num1 = 0;
        static double num2 = 0;
        static double answer = 0.0;
        static string numoperator = "";
        static string optionnum;
        static string shapeChoice;
        static double areat, areas, arear;
        static double base1, height1;
        static string newChoice = "";
        static bool condition = true;

        static void Main(string[] args)
        {

            while (condition)
            {


                Console.WriteLine("What would you like to calculate? Maths or Shapes?");
                optionnum = Console.ReadLine();


                if (optionnum == "maths")

                {


                    Console.WriteLine("Enter the operator +,-,/,* or %");
                    numoperator = Console.ReadLine();

                    Console.Write("Please enter the first number: ");
                    num1 = Int32.Parse(Console.ReadLine());

                    Console.Write("Please enter the second number: ");
                    num2 = Int32.Parse(Console.ReadLine());

                    switch (numoperator)
                    {
                        case "+":
                            Console.WriteLine(answer = Add(num1, num2));
                            break;
                        case "-":
                            Console.WriteLine(answer = Minus(num1, num2));
                            break;
                        case "*":
                            Console.WriteLine(answer = Multiplication(num1, num2));
                            break;
                        case "/":
                            Console.WriteLine(answer = Divison(num1, num2));
                            break;
                        case "%":
                            Console.WriteLine(answer = Modulous(num1, num2));
                            break;
                        default:
                            Console.WriteLine("this calc doesnt understand");
                            break;

                    }
                    Console.WriteLine(num1 + " " + numoperator + " " + num2 + " = " + answer);
                    Console.ReadLine();
                }
                else
                {

                    Console.WriteLine(" choose a shape, square triangle, rectangle ");
                    shapeChoice = Console.ReadLine();

                    if (shapeChoice == "triangle")
                    {
                        Console.WriteLine("enter base");
                        double base1 = double.Parse(Console.ReadLine());

                        Console.WriteLine("enter height");
                        double height1 = double.Parse(Console.ReadLine());

                        areat = triangle(base1, height1);
                        Console.WriteLine(areat);
                        Console.Read();
                    }
                    else if (shapeChoice == "square")
                    {
                        Console.WriteLine("enter base");
                        double base1 = double.Parse(Console.ReadLine());

                        Console.WriteLine("enter height");
                        double height1 = double.Parse(Console.ReadLine());

                        areas = square(base1, height1);
                        Console.WriteLine(areas);
                        Console.Read();
                    }
                    else if (shapeChoice == "rectangle")
                    {
                        Console.WriteLine("enter base");
                        double base1 = double.Parse(Console.ReadLine());

                        Console.WriteLine("enter height");
                        double height1 = double.Parse(Console.ReadLine());

                        arear = rectangle(base1, height1);
                        Console.WriteLine(arear);
                        Console.Read();
                    }
                    else
                        Console.WriteLine("input not valid");


                }
                Console.WriteLine("would you like to continue Y or N");
                newChoice = Console.ReadLine();
                if (newChoice == "N")
                {
                    condition = false;
                }
            }

            }

            static double Add(double num1, double num2)
            {
                return num1 + num2;
            }
            static double Minus(double num1, double num2)
            {
                return num1 - num2;
            }
            static double Multiplication(double num1, double num2)
            {
                return num1 * num2;
            }
            static double Divison(double num1, double num2)
            {
                return num1 / num2;
            }
            static double Modulous(double num1, double num2)
            {
                return num1 % num2;
            }
            static double triangle(double base1, double height1)
            {
                return base1 * height1 * 0.5;
            }
            static double square(double num1, double num2)
            {
                return base1 * height1;
            }
            static double rectangle(double base1, double height1)
            {
                return base1 * height1;
            }
        }
    
                    
}
    

