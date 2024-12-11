namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 :  Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            //Console.WriteLine("Enter The Number: ");
            //String num = Console.ReadLine();
            //bool flag = int.TryParse(num, out int NewNum);

            //if (flag){
            //    if (NewNum % 3 == 0 && NewNum % 4 == 0){
            //        Console.WriteLine("Yes");
            //    }
            //    else{
            //        Console.WriteLine("No");
            //    }
            //}else{
            //    Console.WriteLine("Invalid Input");
            //}

            #endregion

            #region Q2 : Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.

            //Console.WriteLine("Enter The Number: ");
            //String num = Console.ReadLine();
            //bool flag = int.TryParse(num, out int NewNum);
            ////didn't mention to handle zero
            //if (flag)
            //{
            //    if (NewNum < 0)
            //    {
            //        Console.WriteLine("Negative");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Posetive");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Input");
            //}

            #endregion

            #region Q3 : Write a program that takes 3 integers from the user then prints the max element and the min element.
            ////no need to do big try parse [i understand]
            //Console.WriteLine("Enter the first number:");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the second number:");
            //int num2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the third number:");
            //int num3 = int.Parse(Console.ReadLine());

            //int max = Math.Max(num1, Math.Max(num2, num3));
            //int min = Math.Min(num1, Math.Min(num2, num3));

            //Console.WriteLine($"The maximum value is: {max}");
            //Console.WriteLine($"The minimum value is: {min}");


            #endregion

            #region Q4 : Write a program that allows the user to insert an integer number then check If a number is even or odd.

            //Console.WriteLine("Enter an integer number:");

            //string input = Console.ReadLine();
            //bool flag = int.TryParse(input, out int number);

            //if (flag)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine($"{number} is even");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{number} is odd");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input");
            //}

            #endregion

            #region Q5 : Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).

            //Console.WriteLine("Enter a character:");
            //char input = Console.ReadKey().KeyChar;

            //char lowerInput = Char.ToLower(input);

            //if (lowerInput == 'a' || lowerInput == 'e' || lowerInput == 'i' || lowerInput == 'o' || lowerInput == 'u')
            //{
            //    Console.WriteLine("\nVowel");
            //}
            //else
            //{
            //    Console.WriteLine("\nConsonant");
            //}

            #endregion

            #region Q6 : Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //Console.WriteLine("Enter positive number:");

            //bool flag = int.TryParse(Console.ReadLine(), out int number);

            //if (flag && number > 0)
            //{

            //    for (int i = 1; i <= number; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Please enter a valid positive number");
            //}
            #endregion

            #region Q7 : Write a program that allows the user to insert an integer then print a multiplication table up to 12.

            Console.WriteLine("Enter a number:");

            
            bool flag = int.TryParse(Console.ReadLine(), out int number);

            if (flag)
            {
                Console.WriteLine($"Multiplication table for {number}:");
                for (int i = 1; i <= 12; i++)
                {
                    Console.WriteLine($"{number} x {i} = {number * i}");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
            }
            #endregion
        }
    }
}
