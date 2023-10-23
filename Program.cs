using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Xml;

namespace Program{
    class Set1{
        public static void Main(){
            int a, b, c, d, e;

            Console.WriteLine("------------- Ex1");
            Console.WriteLine("This method solves the equation \"ax + b = 0\" ");
            a = getUserInput("a");
            b = getUserInput("b");
            firstGradeEqEx1(a, b);

            Console.WriteLine("------------- Ex2");
            Console.WriteLine("This method solves the equation \"ax^2 + bx + c = 0\" ");
            a = getUserInput("a");
            b = getUserInput("b");
            c = getUserInput("c");
            secondGradeEqEx2(a, b, c);

            Console.WriteLine("------------- Ex3");
            Console.WriteLine("This method determines if a number n is divisible by another number k");
            a = getUserInput("number to divide by");
            b = getUserInput("divisor");
            Console.WriteLine(divisibilityEx3(a, b));

            Console.WriteLine("------------- Ex4");
            Console.WriteLine("This method determines whether the year passed is a leap year");
            a = getUserInput("year to test for");
            Console.WriteLine(leapYearEx4(a));

            Console.WriteLine("------------- Ex5");
            Console.WriteLine("This method finds the n-th digit of a number, counting from right to left");
            a = getUserInput("number");
            b = getUserInput("digit position to find");
            displayDigitEx5(a, b);

            Console.WriteLine("------------- Ex6");
            Console.WriteLine("This method determines whether 3 numbers can form the vertices of a valid triangle");
            a = getUserInput("vertex a");
            b = getUserInput("vertex b");
            c = getUserInput("vertex c");
            Console.WriteLine(pythagorasEx6(a, b, c));

            Console.WriteLine("------------- Ex7+8");
            Console.WriteLine("This method swaps two numbers");
            a = getUserInput("first number to swap");
            b = getUserInput("second number to swap");
            swapEx7(ref a, ref b);
            Console.WriteLine("Swap 1: " + a + " " + b);
            swapRestrictEx8(ref a, ref b);
            Console.WriteLine("Swap 2: " + a + " " + b);

            Console.WriteLine("------------- Ex9");
            Console.WriteLine("This method displays all divisors of a given number");
            a = getUserInput("number to find the divisors of");
            divisorsEx9(a);

            Console.WriteLine("------------- Ex10");
            Console.WriteLine("This method displays whether a number is prime or not");
            a = getUserInput("number to test the primality of");
            Console.WriteLine(primeEx10(a));

            Console.WriteLine("------------- Ex11");
            Console.WriteLine("This method reverses a given number");
            a = getUserInput("number to reverse");
            reverseNumberEx11(a);

            Console.WriteLine("------------- Ex12");
            Console.WriteLine("This method counts all numbers divisible by a value k, within an interval [a,b]");
            a = getUserInput("divisor");
            b = getUserInput("lower bound");
            c = getUserInput("upper bound");
            countNumsDivEx12(a, b, c);

            Console.WriteLine("------------- Ex13");
            Console.WriteLine("This method counts all the leap years within an interval [a,b]");
            a = getUserInput("lower bound");
            b = getUserInput("upper bound");
            countLeapYearsEx13(a, b);

            Console.WriteLine("------------- Ex14");
            Console.WriteLine("This method checks if a number is a palindrome");
            a = getUserInput("number to check for palindrome");
            Console.WriteLine(palindromeEx14(a));

            Console.WriteLine("------------- Ex15");
            Console.WriteLine("This method takes 3 integers and displays them in rising order");
            a = getUserInput("integer 1");
            b = getUserInput("integer 2");
            c = getUserInput("integer 3");
            risingOrderEx15(a, b, c);

            Console.WriteLine("------------- Ex16");
            Console.WriteLine("This method takes 5 integers and displays them in rising order");
            a = getUserInput("integer 1");
            b = getUserInput("integer 2");
            c = getUserInput("integer 3");
            d = getUserInput("integer 4");
            e = getUserInput("integer 5");
            risingOrderNoArraysEx16(a, b, c, d, e);

            Console.WriteLine("------------- Ex17");
            Console.WriteLine("This method displays the GCD and LCM of two numbers");
            a = getUserInput("first number");
            b = getUserInput("second number");
            euclidEx17(a, b);

            Console.WriteLine("------------- Ex18");
            Console.WriteLine("This method breaks down a number into its prime factors");
            a = getUserInput("number to find prime factors of");
            primeFactorsEx18(a);

            Console.WriteLine("------------- Ex19");
            Console.WriteLine("This method checks if a given number is built only using two different digits");
            a = getUserInput("number to check for double digits");
            Console.WriteLine(doubleDigitsEx19(a));

            Console.WriteLine("------------- Ex20");
            Console.WriteLine("This method displays a fraction (m/n) in decimal format");
            a = getUserInput("numerator");
            b = getUserInput("denominator");
            displayFractionEx20(a, b);

            Console.WriteLine("------------- Ex21");
            Console.WriteLine("This method guesses a number between 1 and 1024 via 'greater' or 'smaller' statements");
            a = getUserInput("number to guess");
            guessNumberEx21(a);
        }

        /// <summary>
        /// Get an integer as input from the user
        /// </summary>
        public static int getUserInput(string variableName){
            Console.Write("Enter a value for '" + variableName + "': ");
            return int.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Solve the equation ax + b = 0
        /// </summary>
        public static void firstGradeEqEx1(float a, float b){
            if (a == 0) {
                System.Console.WriteLine("Invalid equation");
                return;
            }
            if (b == 0) {
                System.Console.WriteLine(0);
                return;
            }
            System.Console.WriteLine("Root: ");
            System.Console.WriteLine(-(b/a));
        }

        /// <summary>
        /// Solve the quadratic equation, ax^2 + bx + c = 0
        /// </summary>
        public static void secondGradeEqEx2(float a, float b, float c){
            if (a == 0){
                System.Console.WriteLine(-(c/b));
                return;
            }
            float delta = b * b - 4 * a * c;
            if (delta < 0){
                System.Console.WriteLine("Complex quadratic equation");
                return;
            } else if (delta == 0) {
                System.Console.WriteLine("One root only: ");
                System.Console.WriteLine(-b / (2 * a));
                return;
            } else {
                System.Console.WriteLine("Two roots: ");
                System.Console.WriteLine((-b + Math.Sqrt(delta)) / (2 * a));
                System.Console.WriteLine((-b - Math.Sqrt(delta)) / (2 * a));
            }
        }

        /// <summary>
        /// Determine whether n is divisible by k
        /// </summary>
        public static bool divisibilityEx3(int n, int k){
            return n % k == 0;
        }

        /// <summary>
        /// Determine whether year "y" is a leap year
        /// </summary>
        public static bool leapYearEx4(int y){ // According to the Gregorian calendar,
            if (y % 4 != 0)                    // Every 4th year is a leap year...
                return false;
            if (y % 100 == 0 && y % 400 != 0)  //... except if it's divisible by 100
                return false;                  // if it's divisible by 400 however, 
            return true;                       // it remains a leap year
        }

        /// <summary>
        /// Display the k-th digit of n, counting from right to left; 
        /// two ways, via string conversion or via digit operations
        /// </summary>
        public static void displayDigitEx5(int n, int k){
            System.Console.WriteLine(n.ToString()[n.ToString().Length - k]);

            // System.Console.WriteLine("\n\nOption 2:");
            
            // for (int i = 1; i < k; i++){
            //     n /= 10;
            // }
            // System.Console.WriteLine(n % 10);
        }

        /// <summary>
        /// Determine whether 3 numbers can form a triangle; 
        /// if the sum of any two values is greater than the other 
        /// value, it is a valid triangle
        /// </summary>
        public static bool pythagorasEx6(float a, float b, float c){
            return a + b > c && b + c > a && c + a > b;
        }

        /// <summary>
        /// Swap a and b, using a temporary value
        /// </summary>
        public static void swapEx7(ref int a, ref int b){
            int temp = a;
            a = b;
            b = temp;
        }

        /// <summary>
        /// Swap a and b, without any temporary values
        /// </summary>
        public static void swapRestrictEx8(ref int a, ref int b){
            a = a + b;
            b = a - b;
            a = a - b;
        }

        /// <summary>
        /// Display all positive divisors of n 
        /// </summary>
        public static void divisorsEx9(int n){
            System.Console.Write(1 + " ");
            for(int d = 2; d <= n/2; d++){
                if(n % d == 0)
                    System.Console.Write(d + " ");
            }
            System.Console.WriteLine(n);
        }

        /// <summary>
        /// Determine whether n is a prime number
        /// </summary>
        public static bool primeEx10(int n){
            if (n <= 1)                         // 0 and 1 are not prime
                return false;
            if (n <= 3)                         // 2 and 3 are prime
                return true;
            if (n % 2 == 0 || n % 3 == 0)       // check for divisibility by 2 and 3
                return false;
            for (int i = 5; i * i <= n; i += 6)         // all remaining numbers take the form of
                if (n % i == 0 || n % (i + 2) == 0)     // 6k+1 or 6k-1
                    return false;
            return true;                        // time complexity: O(sqrt(n))
        }

        /// <summary>
        /// Display n with its digits reversed, 2 ways
        /// </summary>
        public static void reverseNumberEx11(int n){
            System.Console.Write(n + " ");
            char[] revArray = n.ToString().ToCharArray();
            Array.Reverse(revArray);
            System.Console.WriteLine(revArray);

            // System.Console.WriteLine("\n\nOption 2:");
            
            // while(n > 0){
            //     System.Console.Write(n % 10);
            //     n /= 10;
            // }
        }

        /// <summary>
        /// Counts how many numbers between a and b are divisible by n
        /// </summary>
        public static void countNumsDivEx12(int n, int a, int b){
            int count = 0;
            for(int i = a; i <= b; i++)
                if (i % n == 0)
                    count++;
            System.Console.WriteLine(count);
        }

        /// <summary>
        /// Count the amount of leap years between y1 and y2 using 'leapYearsEx4' method
        /// </summary>
        public static void countLeapYearsEx13(int y1, int y2){
            int count = 0;
            for(int i = y1; i <= y2; i++)       // Find the first leap year greater than or equal to y1
                if(leapYearEx4(i)){
                    count++;
                    y1 = i;
                    break;
                }
            for(int i = y1; i <= y2; i+=4)      // Only check every 4 numbers to save time
                if(leapYearEx4(i))
                    count++;
            System.Console.WriteLine(count);
        }

        /// <summary>
        /// Determine whether n is a palindrome (12321, 4315134, etc)
        /// </summary>
        public static bool palindromeEx14(int n){
            int mirror = 0, copy = n;
            while(copy > 0){
                mirror = mirror * 10 + copy % 10;   // Rebuild n backwards
                copy /= 10;
            }
            return n == mirror;                     // If n is the same backwards and forwards, it's a palindrome
        }

        /// <summary>
        /// Take 3 integers as parameters, display them in rising order
        /// </summary>
        public static void risingOrderEx15(int a, int b, int c){
            int[] rising = {a, b, c};
            Array.Sort(rising);
            for(int i = 0; i < 3; i++)
                System.Console.Write(rising[i] + " ");
            System.Console.WriteLine();
        }

        /// <summary>
        /// Take 5 integers as parameters, display them in rising order without making use of arrays
        /// </summary>
        public static void risingOrderNoArraysEx16(int a, int b, int c, int d, int e){
            if (a > b) (b, a) = (a, b);
            if (b > c) (c, b) = (b, c);
            if (c > d) (d, c) = (c, d);
            if (d > e) (e, d) = (d, e);
            if (a > b) (b, a) = (a, b);
            if (b > c) (c, b) = (b, c);
            if (c > d) (d, c) = (c, d);
            if (a > b) (b, a) = (a, b);
            if (b > c) (c, b) = (b, c);
            if (a > b) (b, a) = (a, b);

            Console.WriteLine($"{a} {b} {c} {d} {e}");
        }

        /// <summary>
        /// Find the GCD and LCM of a and b using Euclid's algorithm
        /// </summary>
        public static void euclidEx17(int a, int b){
            int r, copyA = a, copyB = b;
            while(copyB != 0){
                r = copyA % copyB;
                copyA = copyB;
                copyB = r;
            }
            System.Console.WriteLine("Greatest common divisor: " + copyA);
            System.Console.WriteLine("Least common multiple: " + (a * b / copyA));
        }

        /// <summary>
        /// Break down n into its prime factors
        /// </summary>
        public static void primeFactorsEx18(int n){
            int powCount = 0;
            for(int d = 2; d <= n && n > 1; d++){
                while (n % d == 0){
                    powCount++;
                    n /= d;
                }
                if (powCount != 0)
                    System.Console.Write(d + "^" + powCount + " ");
                powCount = 0;
            }
            System.Console.WriteLine();
        }

        /// <summary>
        /// Determine whether n can be built only using two different digits (e.g. 242242, 90990,  but not 812281)
        /// </summary>
        public static bool doubleDigitsEx19(int n){
            int[] freq = new int[10];
            int validate = 0;
            for(int i = 0; i < 10; i++)
                freq[i] = 0;
            while(n > 0){
                freq[n%10] = 1;
                n /= 10;
            }
            for(int i = 0; i < 10; i++)
                if(freq[i] != 0)
                    validate++;
            if(validate == 2)
                return true;
            return false;
        }

        /// <summary>
        /// Displays the fraction m/n in decimal form
        /// </summary>
        public static void displayFractionEx20(int m, int n){
            double d = (double)m / n;
            Console.WriteLine(d.ToString("0.00"));
        }

        /// <summary>
        /// Find n between 1 and 1024 using binary search
        /// </summary>
        public static void guessNumberEx21(int n){
            int low = 1, high = 1024, mid = (low + high) / 2;
            while(mid != n){
                if (n > mid)
                    low = mid;
                else
                    high = mid;
                mid = (low + high) / 2;
            }
            System.Console.WriteLine(mid);
        }
    }
}
