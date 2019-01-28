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

            // write your self-reflection here as a comment

        }

        public static void printPrimeNumbers(int x, int y)      // This method prints all the prime numbers between x and y
        {
            try
            {

                Console.WriteLine("Prime numbers between {0} and {1} are: \n", x, y);
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
            string reverse = "";
            try
            {
                int quot;
                string rem = "";
                while (n >= 1)                      // getting the quotient and the reminder for the given number
                {
                    quot = Convert.ToInt32(n / 2);
                    rem += (n % 2).ToString();
                    n = quot;
                }

                for (int i = rem.Length - 1; i >= 0; i--)
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

        public static long binaryToDecimal(long n)
        {
            long deci_val = 0;
            try
            {
                long bin_val, base_val = 1, rem;
                bin_val = n;

                while (bin_val > 0)
                {
                    rem = bin_val % 10;
                    deci_val = deci_val + rem * base_val;
                    bin_val = bin_val / 10;
                    base_val = base_val * 2;
                }
                Console.ReadKey();
            }

            catch
            {
                Console.WriteLine("Exception occured while computing binaryToDecimal()");
            }
            return deci_val;
        }

        public static void printTriangle(int n)
        {
            try
            {
                int i, j, k;
                for (i = 1; i <= n; i++)
                {
                    for (j = i; j < n; j++)
                    {
                        Console.Write(" ");
                    }
                    for (k = 1; k < (i * 2); k++)
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

        public static void computeFrequency(int[] a)
        {
            try
            {
                int len = a.Length;
                int i, j, count = 0;
                int[] countnum = new int[len];

                for (i = 0; i < len; i++)
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
                    if (countnum[i] != -1)
                    {
                        countnum[i] = count;
                    }
                }

                Console.WriteLine("Number   Frequency");

                for (i = 0; i < len; i++)
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
