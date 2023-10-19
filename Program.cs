    // 1. Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare. 
    // 2. Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile. 
    // 3. Determinati daca n se divide cu k, unde n si k sunt date de intrare. 
    // 4. Detreminati daca un an y este an bisect. 
    // 5. Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. 
    // 6. Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. 
    // 7. (Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor. 
    // 8. (Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.  
    // 9. Afisati toti divizorii numarului n. 
    // 10. Test de primalitate: determinati daca un numar n este prim.
    // 11. Afisati in ordine inversa cifrele unui numar n. 
    // 12. Determinati cate numere integi divizibile cu n se afla in intervalul [a, b]. 
    // 13. Determianti cati ani bisecti sunt intre anii y1 si y2.
    // 14. Determianti daca un numar n este palindrom. (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321. 
    // 15. Se dau 3 numere. Sa se afiseze in ordine crescatoare. 
    // 16. Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)
    // 17. Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid. 
    // 18. Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1176 afisati 2^3 x 3^1 x 7^2. 
    // 19. Determinati daca un numar e format doar cu 2 cifre care se pot repeta. De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt. 
    // 20. Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul). Exemplu: 13/30 = 0.4(3). (https://github.com/HoreaOros/ROSE2020/blob/master/2611/Program.cs)
    //         O fractie este neperiodica daca numitorul este de forma 2^m*5^n unde m si n sunt mai mari sau egale decat 0
    //         O fractie este periodica simpla daca numitorul nu se divide cu 2 si nici cu 5. 
    //         O fractie este periodica mixta daca se divide cu 2 si/sau 5 SI se mai divide si cu alte numere prime diferite de 2 si 5. 
    // 21. Ghiciti un numar intre 1 si 1024 prin intrebari de forma "numarul este mai mare sau egal decat x?". 

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

            System.Console.WriteLine(leapYearsEx4(2500));
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

            countNumsDivEx12(3, 10, 55);
            System.Console.WriteLine("------------- Ex12");

            countLeapYearsEx13(1999, 2101);
            System.Console.WriteLine("------------- Ex13");

            System.Console.WriteLine(palindromeEx14(1234321));
            System.Console.WriteLine("------------- Ex14");

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
        public static bool leapYearsEx4(int y){ // According to the Gregorian calendar,
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
                if(leapYearsEx4(i)){
                    count++;
                    y1 = i;
                    break;
                }
            for(int i = y1; i <= y2; i+=4)      // Only check every 4 numbers to save time
                if(leapYearsEx4(i))
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


        public static void risingOrderEx15(int a, int b, int c){
            
        }
    }
}
