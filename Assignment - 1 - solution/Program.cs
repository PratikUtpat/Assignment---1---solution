using System;

namespace Assignment___1___solution
{
    class Program
    {
        public static void Main()
        {
            int a = 5, b = 15;
            printPrimeNumbers(a, b);

            int n1 = 5;
            double r1 = getSeriesResult(n1);
            Console.WriteLine("The sum of the series is: " + r1);


            long n2 = 15;
            long r2 = decimalToBinary(n2);
            Console.WriteLine("Binary conversion of the decimal number " + n2 + " is: " + r2);


            long n3 = 1111;
            long r3 = binaryToDecimal(n3);
            Console.WriteLine("Decimal conversion of the binary number " + n3 + " is: " + r3);


            int n4 = 5;
            printTriangle(n4);

            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };
            computeFrequency(arr);

            // write your self-reflection here as a comment -
            
            // This Assignment was useful for understanding and applying basic concepts like looping, program structuring, conditional statement use,
            // method calling, passing parameters, data types usage.
            // It was also very useful for me for practising and understanding debugger and compiler concepts. I put break-points for checking the program-flow, checking/removing errors and validation.
            // good practise for logic building.
            // I learned how to use gitHub and push the files.
        }

        public static void printPrimeNumbers(int x, int y)      // This method prints all the prime numbers between x and y
        {
            try
            {
                Console.WriteLine("Question 1 solution");
                Console.Write("Prime numbers between {0} and {1} are: \n", x, y);
                for (int i = x; i <= y; i++)        // iteration to check every number if it is prime or not
                {
                    bool value = isPrime(i);    // calling this method and passing number to this method to compute if a number is prime or not.
                    if (value)
                    {
                        Console.WriteLine(i);       // if value is true then printing number which is prime !
                    }
                }
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");
            }
        }

        public static bool isPrime(int i)       // this method is to compute if a number is prime or not.
        {
            bool value = false;
            int control = 0;
            if (i > 1)          // all the prime numbers are greater than 1
            {
                for (int j = 2; j < i; j++)     // checking if the number has any factors
                {
                    if (i % j == 0)
                    {
                        control = 1;
                        break;
                    }
                }
                if (control == 0)
                {
                    value = true;
                }
            }
            return value;
        }

        public static double getSeriesResult(int n)    // This method computes the series 1/2 – 2!/3 + 3!/4 – 4!/5 --- n     * where ! means factorial
        {
            Console.WriteLine("********************************************************************");
            Console.WriteLine("Question 2 - solution");
            double result = 0;
            try
            {

                while (n != 0)      // we have to iterate the loop till we cover the 'n' numbers
                {
                    double res = 1;
                    int num = n;
                    res = fact(num);            // calling a method which will return the factorial of given number
                    res = (res / (n + 1));      // here I am dividing the result of factorial of each number by (n+1)
                    if (n % 2 == 0)             // in this If condition, I am checking if the numer position is even or odd and then adding or subtracting the number for final result of the series.
                    {
                        result = result - res;
                    }
                    else
                    {
                        result = result + res;
                    }
                    n--;
                }
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            }
            return Math.Round(result, 3);       // returning the final result rounded of to 3 decimal places.
        }

        public static int fact(int num)        // method to calculate factorial of given number
        {
            int res = 1;
            while (num != 0)    // here, in this while loop, I am calculating the factorial of each number from last iteration 
            {
                res = res * num;
                num = num - 1;
            }
            return res;
        }

        public static long decimalToBinary(long n)      //This method converts a number from decimal (base 10) to binary (base 2).
        {
            Console.WriteLine("********************************************************************");
            Console.WriteLine("Question 3 - solution");
            string reverse = "";
            try
            {
                int quot;
                string rem = "";
                while (n >= 1)                      // getting the quotient for next iteration, getting the reminder for binary digit and repeating until quotient = 0
                {
                    quot = Convert.ToInt32(n / 2);
                    rem += (n % 2).ToString();
                    n = quot;
                }

                for (int i = rem.Length - 1; i >= 0; i--)       // getting the binary number
                {
                    reverse = reverse + rem[i];
                }
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Exception occured while computing decimalToBinary()");
            }

            return Convert.ToInt64(reverse);
        }

        public static long binaryToDecimal(long n)      // This method converts a number from binary (base 2) to decimal (base 10).
        {
            Console.WriteLine("********************************************************************");
            Console.WriteLine("Question 4 - solution");
            long deci_val = 0;
            try
            {
                long bin_val, base_val = 1, rem;
                bin_val = n;

                for(int i=0; bin_val>0;i++)     // this loop is used for getting the bits (from right most bit to left) and multipying each by power of 2 and for computation of final decimal number computation.
                {
                    rem = bin_val % 10;

                    deci_val = deci_val +   rem* power(i); // this method is being called for calculation of power of 2
                    bin_val = bin_val / 10;
                    base_val = base_val * 2;
                }
                Console.ReadKey();
            }

            catch
            {
                Console.WriteLine("Exception occured while computing binaryToDecimal()");
            }
            return deci_val;        // returning final decimal value
        }

        public static int power(int i)      // method to compute 2^n
        {
            int ans = 1;
            for (int j=0; j<i;j++)
            {
                ans = ans * 2;
            }
            return ans;
        }

        public static void printTriangle(int n)     // This method prints a triangle pattern using *
        {
            Console.WriteLine("********************************************************************");
            Console.WriteLine("Question 5 - solution");
            try
            {
                int i, j, k;
                for (i = 1; i <= n; i++)            // iteration for row number
                {
                    for (j = i; j < n; j++)         // iteration for printing space before *
                    {
                        Console.Write(" ");
                    }
                    for (k = 1; k < (i * 2); k++)      // iteration for printing *
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        public static void computeFrequency(int[] a)        // This method computes the frequency of each element in the array
        {
            Console.WriteLine("\n********************************************************************");
            Console.WriteLine("Question 6 - solution");
            try
            {
                int len = a.Length;                         // getting length of array in a variable
                int i, j, count = 0;
                int[] countnum = new int[len];              // array of same lenght as given array length for later purpose

                for (i = 0; i < len; i++)                   // loop used for getting frequency of numbers
                {
                    count = 1;
                    for (j = i + 1; j < len; j++)
                    {
                        if (a[i] == a[j])
                        {
                            count++;
                            countnum[j] = -1;
                        }
                    }
                    if (countnum[i] != -1)              // storing frequency in this 'countnum' array
                    {
                        countnum[i] = count;
                    }
                }

                Console.WriteLine("Number   Frequency");

                for (i = 0; i < len; i++)               // loop used to print numbers and their frequency
                {
                    if (countnum[i] != -1)
                    {
                        Console.Write(a[i] + "\t" + countnum[i] + "\n");
                        Console.ReadKey();
                    }
                }
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            }
        }
    }
}
