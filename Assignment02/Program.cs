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
            //no need to do big try parse [i understand]
            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number:");
            int num3 = int.Parse(Console.ReadLine());
            
            int max = Math.Max(num1, Math.Max(num2, num3));
            int min = Math.Min(num1, Math.Min(num2, num3));

            Console.WriteLine($"The maximum value is: {max}");
            Console.WriteLine($"The minimum value is: {min}");


            #endregion
        }
    }
}
