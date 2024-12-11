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

            //Console.WriteLine("Enter a number:");


            //bool flag = int.TryParse(Console.ReadLine(), out int number);

            //if (flag)
            //{
            //    Console.WriteLine($"Multiplication table for {number}:");
            //    for (int i = 1; i <= 12; i++)
            //    {
            //        Console.WriteLine($"{number} x {i} = {number * i}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Please enter a valid number");
            //}
            #endregion

            #region Q8 : Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //Console.WriteLine("Enter a number:");


            //bool flag = int.TryParse(Console.ReadLine(), out int number);

            //if (flag && number >= 1)
            //{
            //    Console.WriteLine($"Even numbers between 1 and {number}:");
            //    for (int i = 2; i <= number; i += 2)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Please enter a valid positive integer.");
            //}

            #endregion

            #region Q9 : Write a program that takes two integers then prints the power.

            //Console.WriteLine("Enter the base number:");

            //bool FlagBase = int.TryParse(Console.ReadLine(), out int baseNumber);

            //Console.WriteLine("Enter the exponent:");

            //bool FlagExponent = int.TryParse(Console.ReadLine(), out int exponent);

            //if (FlagBase && FlagExponent && exponent >= 0)
            //{
            //    int result = 1;

            //    for (int i = 1; i <= exponent; i++)
            //    {
            //        result *= baseNumber; 
            //    }

            //    Console.WriteLine($"{baseNumber} raised to the power of {exponent} is {result}");
            //}
            //else
            //{
            //    Console.WriteLine("Please enter valid integers, and ensure the exponent is non-negative.");
            //}

            #endregion

            #region Q10 : Write a program to enter marks of five subjects and calculate total, average and percentage.

            //Console.WriteLine("Enter marks for 5 subjects:");

            //int[] marks = new int[5];
            //int total = 0;
            //double average, percentage;

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write($"Enter marks for subject {i + 1}: ");
            //    bool flag = int.TryParse(Console.ReadLine(), out marks[i]);

            //    if (!flag || marks[i] < 0)
            //    {
            //        Console.WriteLine("Please enter a valid non-negative value for marks");
            //        return;
            //    }

            //    total += marks[i];
            //}

            //average = total / 5;
            //percentage = (total / 500) * 100;

            //Console.WriteLine($"\nTotal marks: {total}");
            //Console.WriteLine($"Average marks: {average}");
            //Console.WriteLine($"Percentage: {percentage}%");


            #endregion

            #region Q11 :  Write a program to input the month number and print the number of days in that month.

            //Console.WriteLine("Enter a number:");


            //bool flag = int.TryParse(Console.ReadLine(), out int month);

            //if (flag)
            //{
            //    switch (month) {

            //        case 1:
            //        case 3:
            //        case 5:
            //        case 7:
            //        case 8:
            //        case 10:
            //        case 12:
            //            Console.WriteLine("31 days");
            //            break;
            //        case 4:
            //        case 6:
            //        case 9:
            //        case 11:
            //            Console.WriteLine("30 days");
            //            break;
            //        case 2:
            //            Console.WriteLine("28 or 29 days");
            //            break;
            //        default:
            //            Console.WriteLine("Please enter a valid month number");
            //            break;

            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Please enter a valid number");
            //}

            #endregion

            #region Q12 : Write a program to create a Simple Calculator.

            //double num1, num2;
            //char operation;

            //Console.WriteLine("Enter the first number:");
            //if (!double.TryParse(Console.ReadLine(), out num1))
            //{
            //    Console.WriteLine("Invalid input for the first number.");
            //    return;
            //}

            //Console.WriteLine("Enter an operator (+, -, *, /):");
            //operation = Console.ReadKey().KeyChar;

            //Console.WriteLine("Enter the second number:");
            //if (!double.TryParse(Console.ReadLine(), out num2))
            //{
            //    Console.WriteLine("Invalid input for the second number.");
            //    return;
            //}

            //double result = 0;
            //bool validOperation = true;

            //switch (operation)
            //{
            //    case '+':
            //        result = num1 + num2;
            //        break;
            //    case '-':
            //        result = num1 - num2;
            //        break;
            //    case '*':
            //        result = num1 * num2;
            //        break;
            //    case '/':
            //        if (num2 != 0)
            //        {
            //            result = num1 / num2;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Error: Division by zero.");
            //            validOperation = false;
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("Invalid operator.");
            //        validOperation = false;
            //        break;
            //}

            //if (validOperation)
            //{
            //    Console.WriteLine($"The result of {num1} {operation} {num2} is: {result}");
            //}

            #endregion
        }
    }

}
