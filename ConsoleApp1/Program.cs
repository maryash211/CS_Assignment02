using System.Globalization;
using System.Numerics;

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

            //Console.Write("Input starting number of range: ");
            //int.TryParse(Console.ReadLine(), out int num1);

            //Console.Write("Input ending number of range: ");
            //int.TryParse(Console.ReadLine(), out int num2);

            //Console.Write($"The prime number between {num1} and {num2} are : ");

            //bool isPrime = true;
            //for (int i = num1; i <= num2; i++)
            //{
            //    if (i > 1)
            //    {
            //        isPrime = true; //to reset isaprime to true for each loop
            //        for (int j = 2; j < i; j++)     // or j <= Math.Sqrt(i) as logically any factor of i must be less than or equal to square root of it
            //        //for (int j = 2; j <= Math.Sqrt(i); j++)
            //        {
            //            if (i % j == 0)
            //            {
            //                isPrime = false;
            //                break;
            //            }
            //        }
            //    }
            //    else
            //    {
            //        isPrime = false;
            //    }

            //    if (isPrime)
            //    {
            //        Console.Write($"{i} ");

            //    }

            //}

            #endregion

            #region Q16

            //Console.Write("Enter a number to convert : ");
            //int.TryParse(Console.ReadLine(), out int num);

            //Console.WriteLine($"The Binary of {num} is {Convert.ToString(num, 2)}");




            ////or without using Convert.ToString method


            //Console.Write("Enter a number to convert : ");
            //int.TryParse(Console.ReadLine(), out int num);
            //int numCopy = num; // to display num before converting to binry

            //string binary = "";
            //do
            //{
            //    binary = num % 2 + binary;
            //    num /= 2;
            //}
            //while (num > 0);
            //Console.Write($"The Binary of {numCopy} is {binary}.");

            #endregion

            #region Q17

            //Console.Write("Enter for first point:\nX= ");
            //double.TryParse(Console.ReadLine(), out double x1);
            //Console.Write("Y= ");
            //double.TryParse(Console.ReadLine(), out double y1);

            //Console.Write("Enter for second point:\nX= ");
            //double.TryParse(Console.ReadLine(), out double x2);
            //Console.Write("Y= ");
            //double.TryParse(Console.ReadLine(), out double y2);

            //Console.Write("Enter for third point:\nX= ");
            //double.TryParse(Console.ReadLine(), out double x3);
            //Console.Write("Y= ");
            //double.TryParse(Console.ReadLine(), out double y3);

            //double slope1 = (y2 - y1) / (x2 - x1);
            //double slope2 = (y3 - y2) / (x3 - x2);

            //// if the slope of first 2 points = the slope of last 2 points then they are on a single straight line 
            //if (slope1 == slope2)
            //{
            //    Console.WriteLine("The points are on a single straight line");
            //}
            //else
            //{
            //    Console.WriteLine("The points are not on a single straight line.");
            //}

            #endregion

            #region Q18

            //Console.Write("Time taken for task = ");
            //double.TryParse(Console.ReadLine(), out double t);

            //string result = t switch
            //{
            //    >=2 and <=3 => "Highly efficient",
            //    >=3 and <=4 => "Increase speed",
            //    >=4 and <=5 => "Training required to enhance speed",
            //    > 5 => "Leave the company",
            //    _ => "Invalid input"
            //};
            //Console.WriteLine(result);

            #endregion

            #region Q19

            //Console.Write("Enter n: ");
            //int.TryParse(Console.ReadLine(), out int n);

            //for (int i=0; i<n;  i++)
            //{
            //    for (int j=0; j<n; j++)
            //    {
            //        // the identity diagonal is in elements [1][1], [2][2], [3][3] ... so when i==j => 1
            //        if (j == i)
            //            Console.Write("1 ");
            //        else
            //            Console.Write("0 ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Q20

            //Console.Write("Enter size of array: ");
            //int.TryParse(Console.ReadLine(), out int size);

            //int sum = 0;
            //Console.WriteLine("Enter elements of array: ");
            //int[] nums = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out nums[i]);
            //    sum += nums[i];
            //}
            //Console.WriteLine($"Sum of all elements of array = {sum}");

            #endregion

            #region Q21

            //Console.Write("Enter size of array: ");
            //int.TryParse(Console.ReadLine(), out int size);

            //int[] arr1 = new int[size];
            //Console.WriteLine("Enter elements of first array: ");
            //for (int i = 0; i < size; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out arr1[i]);
            //}

            //int[] arr2 = new int[size];
            //Console.WriteLine("Enter elements of second array: ");
            //for (int i = 0; i < size; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out arr2[i]);
            //}

            //int[] merge = new int[size*2];
            //merge = arr1.Concat(arr2).ToArray();

            ////or without using Concat method

            ////Array.Copy(arr1, merge, size);
            ////Array.Copy(arr2, 0, merge, size, size);

            //Array.Sort(merge);
            //Console.WriteLine("Arrays sorted and merged: ");
            //foreach (var item in  merge)
            //{
            //    Console.Write(item + ", ");
            //}

            #endregion

            #region Q22

            //Console.Write("Enter size of array: ");
            //int.TryParse(Console.ReadLine(), out int size);

            //int[] nums = new int[size];
            //int count = 1;
            //bool[] isvisited = new bool[size];

            //Console.WriteLine("Enter elements of array: ");
            //for (int i = 0; i < size; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out nums[i]);
            //}

            //for (int j = 0; j<size; j++)
            //{
            //    if (isvisited[j]) 
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        count = 1;
            //        for (int k = j + 1; k < size; k++)
            //        {
            //            if (nums[j] == nums[k])
            //            {
            //                count++;
            //                isvisited[k] = true;
            //            }
            //        }
            //    }

            //     Console.WriteLine($"frequency of {nums[j]} is {count}"); 
            //}   

            #endregion

            #region Q23

            //Console.Write("Enter size of array: ");
            //int.TryParse(Console.ReadLine(), out int size);

            //int[] nums = new int[size];
            //Console.WriteLine("Enter elements of array: ");
            //for (int i = 0; i < size; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out nums[i]);
            //}
            //Console.WriteLine($"Max element = {nums.Max()}\nMin element = {nums.Min()}");

            #endregion

            #region Q24

            //Console.Write("Enter size of array: ");
            //int.TryParse(Console.ReadLine(), out int size);

            //int[] nums = new int[size];
            //Console.WriteLine("Enter elements of array: ");
            //for (int i = 0; i < size; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out nums[i]);
            //}
            //Array.Sort(nums);
            //Console.WriteLine($"The second largest element = {nums[size-2]}");


            #endregion

            #region Q25

            // Console.Write("Enter size of array: ");
            // int.TryParse(Console.ReadLine(), out int size);

            // int[] nums = new int[size];
            // Console.WriteLine("Enter elements of array: ");
            // for (int i = 0; i <= size - 1; i++)
            // {
            //     int.TryParse(Console.ReadLine(), out nums[i]);
            // }

            // int distance = 0;
            // int max = 0;
            // int iCopy = 0;
            // int jCopy = 0;
            // for (int i = 0; i < size; i++)
            // {
            //     for (int j = size - 1; j > i; j--)
            //     {
            //         if (nums[j] == nums[i])
            //         {

            //             distance = (j - i) - 1;
            //             if (distance > max)
            //             {
            //                 max = distance;
            //                 iCopy = i;
            //                 jCopy = j;

            //             }
            //             break;

            //         }
                    
            //     }
            // }
            // Console.WriteLine($"Longest distance = {max} is between the {nums[iCopy]}'s of indexes {iCopy} and {jCopy}");

            #endregion

            #region Q26

            //Console.Write("Enter a sentence: ");
            //string str = Console.ReadLine();

            //string[] words = str.Split(' ');

            //Array.Reverse(words); //to reverse the array
            //foreach (var word in words)
            //{
            //    Console.Write(word + " ");
            //}

            #endregion

            #region Q27

            //Console.Write("Enter size of array: ");
            //int.TryParse(Console.ReadLine(), out int size);

            //int[] nums = new int[size];
            //Console.WriteLine("Enter elements of array: ");
            //for (int i = 0; i < size; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out nums[i]);
            //}
            //Console.Write("Array reversed: ");
            //for (int i = (nums.Length)-1; i >= 0; i--)
            //{
            //    Console.Write($"{nums[i]}, ");
            //}

            #endregion



        }
    }
}
