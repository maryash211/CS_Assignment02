using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            //Console.Write("Enter a number:");
            //bool isparsed = int.TryParse(Console.ReadLine(), out int num);
            //if (isparsed) {
            //    if (num % 3 == 0 && num % 4 == 0)
            //        Console.WriteLine("Yes");

            //    else
            //        {
            //            Console.WriteLine("No");
            //        }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //}

            #endregion

            #region Q2

            //Console.Write("Enter a number:");
            //int.TryParse(Console.ReadLine(), out int num);

            //string result = num switch
            //{
            //    < 0 => "Negative",
            //    > 0 => "Positive",
            //    0 => "Zero"
            //};
            //Console.WriteLine(result);

            #endregion

            #region Q3

            //Console.WriteLine("Enter three number: ");
            //int[] nums = new int[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out nums[i]);
            //}
            //Console.WriteLine($"Max element = {nums.Max()}\nMin element = {nums.Min()}");

            ////or without loops

            //Console.WriteLine("Enter first number: ");
            //int.TryParse(Console.ReadLine(), out int num1);

            //Console.WriteLine("Enter second number: ");
            //int.TryParse(Console.ReadLine(), out int num2);

            //Console.WriteLine("Enter third number: ");
            //int.TryParse(Console.ReadLine(), out int num3);

            //int max = Math.Max(num1, Math.Max(num2, num3));
            //Console.WriteLine($"Max element = {max}");

            //int min = Math.Min(num1, Math.Min(num2, num3));
            //Console.WriteLine($"Min element = {min}");

            #endregion

            #region Q4

            //Console.Write("Enter a number: ");
            //bool isparsed = int.TryParse(Console.ReadLine(), out int num);
            //if (isparsed)
            //{
            //    if (num % 2 == 0)
            //        Console.WriteLine("Your number is Even");

            //    else
            //    {
            //        Console.WriteLine("Your number is Odd");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //}

            #endregion

            #region Q5

            //Console.Write("Enter a character: ");
            //char.TryParse(Console.ReadLine(), out char c);

            //string result = c switch
            //{
            //    'a' or 'e' or 'i' or 'o' or 'u' => "Vowel",
            //    'A' or 'E' or 'I' or 'O' or 'U' => "Vowel",
            //    _ => "Consonant"
            //};
            //Console.WriteLine(result);

            #endregion

            #region Q6

            //Console.Write("Enter a number: ");
            //int.TryParse(Console.ReadLine(), out int num);

            //for (int i = 1; i <= num; i++)
            //{
            //    Console.Write(i);
            //}

            #endregion

            #region Q7

            //Console.Write("Enter a number: ");
            //int.TryParse(Console.ReadLine(), out int num);

            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.Write((i * num) + " ");
            //}

            #endregion

            #region Q8

            //Console.Write("Enter a number: ");
            //int.TryParse(Console.ReadLine(), out int num);

            //for (int i = 1; i <= num; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}

            #endregion

            #region Q9

            //Console.Write("Enter number: ");
            //int.TryParse(Console.ReadLine(), out int num);

            //Console.Write("Enter power: ");
            //int.TryParse(Console.ReadLine(), out int power);

            //int result =1;
            //for (int i = 1; i <= power; i++)
            //{ 
            //    result *= num;
            //}
            //Console.WriteLine(result);

            #endregion

            #region Q10

            //Console.WriteLine("Enter Marks of five subjects: ");
            //int[] nums = new int[5];
            //int Sum = 0;

            //for (int i = 0; i < 5; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out nums[i]);
            //    Sum += nums[i]; 
            //}
            //int Average = Sum / 5;
            //int prcnt = (Sum * 100) / 500;

            //Console.WriteLine($"Total marks = {Sum} ");
            //Console.WriteLine($"Average Marks = {Average} ");
            //Console.WriteLine($"Percentage = {prcnt} ");

            #endregion

            #region Q11

            //Console.Write("Month number: ");
            //int.TryParse(Console.ReadLine(), out int num);

            //string result = num switch
            //{
            //    4 or 6 or 9 or 11 => "30 days",
            //    2 => "28 or 29 days",
            //    1 or 3 or 5 or 7 or 8 or 10 or 12 => "31 days",
            //    _ => "Invalid month number"
            //};
            //Console.WriteLine($"Days in Month: {result}");


            #endregion

            #region Q12

            //Console.Write("Enter first number: ");
            //double.TryParse(Console.ReadLine(), out double num1);

            //Console.WriteLine("Choose an operator (+, -, *, /): ");
            //char.TryParse(Console.ReadLine(), out char op);

            //Console.Write("Enter second number: ");
            //double.TryParse(Console.ReadLine(), out double num2);

            //double result = 0;
            //switch (op)
            //{
            //    case '+':
            //        result = num1 + num2;
            //        break;

            //    case '-':
            //        result = num2 - num1;
            //        break;

            //    case '*':
            //        result = num1 * num2;
            //        break;

            //    case '/':
            //        if (num2 != 0)
            //        {
            //           result = num1 / num2;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Error: Can't divide by zero");
            //        }
            //        break;

            //    default:
            //        Console.WriteLine("Invalid Operation");
            //        break;
            //}
            //Console.WriteLine($"{num1} {op} {num2} = {result}" );

            #endregion

            #region Q13

            ////looping over the string

            //Console.Write("Enter a string: ");
            //string str = Console.ReadLine();

            //for (int i = str.Length-1; i >=0; i--)
            //{
            //    Console.Write(str[i]);
            //}


            #endregion

            #region Q14

            //Console.Write("Enter a number: ");
            //int.TryParse(Console.ReadLine(), out int num);

            //string str = num.ToString();

            //for (int i = str.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(str[i]);
            //}

            #endregion

            #region Q15

            Console.Write("Input starting number of range: ");
            int.TryParse(Console.ReadLine(), out int num1);

            Console.Write("Input ending number of range: ");
            int.TryParse(Console.ReadLine(), out int num2);



            Console.Write($"The prime number between {num1} and {num2} are : ");
            for (int i = num1; i <= num2; i++)
            {
                if (i==2)
                {
                    Console.Write($"{i} ");
                }
                else
                {
                    for (int j = 2; j <= 9; j++)
                    {
                        if (i % j != 0)
                        {
                            Console.Write($"{i} ");
                        }
                        //if (j == (int)Math.Sqrt(i))
                        //{
                            
                        //}
                    }
                }
            }

            #endregion

        }
    }
}
