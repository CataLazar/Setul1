using System;

namespace Program{
    class Setul1{
        public static void Main(){
            int a, b;

            firstGradeEqEx1(3,5);
            System.Console.WriteLine("------------- Ex1");

            secondGradeEqEx2(1, 5, 3);
            System.Console.WriteLine("------------- Ex2");

            System.Console.WriteLine(divisibilityEx3(10, 5));
            System.Console.WriteLine("------------- Ex3");

            System.Console.WriteLine(anBisectEx4(2500));
            System.Console.WriteLine("------------- Ex4");

            displayDigitEx5(-47718974, 3);
            System.Console.WriteLine("------------- Ex5");

            System.Console.WriteLine(pythagorasEx6(5,3,9));
            System.Console.WriteLine("------------- Ex6");

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            swapEx7(ref a, ref b);
            System.Console.WriteLine(a + " " + b);

            swapRestrictEx8(ref a, ref b);
            System.Console.WriteLine(a + " " + b);
            System.Console.WriteLine("------------- Ex7+8");

            divisorsEx9(42);
            System.Console.WriteLine("------------- Ex9");

            System.Console.WriteLine(primeEx10(7));
            System.Console.WriteLine("------------- Ex10");

            reverseNumberEx11(1234567);
            System.Console.WriteLine("------------- Ex11");

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
        public static bool anBisectEx4(int y){ // According to the Gregorian calendar,
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
        /// Display n with its digits reversed
        /// </summary>
        public static void reverseNumberEx11(int n){
            System.Console.Write(n + " ");
            char[] revArray = n.ToString().ToCharArray();
            Array.Reverse(revArray);
            System.Console.WriteLine(revArray);
        }
    }
}
