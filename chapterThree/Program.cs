// 1. Write an expression that checks whether an integer is odd or even.

Console.WriteLine("-----------------------------Chapter 3,  Solution 1----------------------");
Console.Write("Enter an integer: ");
int checkForOddAndEven = int.Parse(Console.ReadLine());
Console.WriteLine((checkForOddAndEven % 2==0)? "{0} is an Even number" : "{0} is an odd number", checkForOddAndEven);


// 2. Write a Boolean expression that checks whether a given integer is divisible by both 5 and 7, without a remainder.
Console.WriteLine("-----------------------------Chapter 3,  Solution 2----------------------");
Console.Write("Enter an integer: ");
int questionTwoInput = int.Parse(Console.ReadLine());
Console.WriteLine((questionTwoInput % 5 == 0 && questionTwoInput % 7 == 0) ? "{0} is divisible by 5 and 7" :"{0} is not divisible by 5 and 7", questionTwoInput );




// 3. Write an expression that looks for a given integer if its third digit (right to left) is 7.
Console.WriteLine("-----------------------------Chapter 3,  Solution 3----------------------");
 int thirdDigitNeeded = 45764;
    bool isSeven = (thirdDigitNeeded / 100) % 10 == 7 ? true : false;
    Console.WriteLine("Third digit of {0} is 7", thirdDigitNeeded, isSeven);


// 4. Write an expression that checks whether the third bit in a given integer is 1 or 0.
Console.WriteLine("-----------------------------Chapter 3,  Solution 4----------------------");

    int thirdBit = 452;    
    Console.WriteLine("The third bit of {0} is 1? {1}", thirdBit, ((thirdBit >> 3) & 1) == 1);


// 5. Write an expression that calculates the area of a trapezoid by given sides a, b and height h.
Console.WriteLine("-----------------------------Chapter 3,  Solution 5----------------------");
  float a = 2;
    float b = 3;
    float h = 1;
    Console.WriteLine("S={0}", (a + b) / (2 * h));

// 6. Write a program that prints on the console the perimeter and the area of a rectangle by given side and height entered by the user.
Console.WriteLine("-----------------------------Chapter 3,  Solution 6----------------------");
   Console.Write("Enter a: ");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter b: ");
    int B = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("S={0}, P={1}", A * B, (A + B) * 2);

// 7. The gravitational field of the Moon is approximately 17% of that on the Earth. Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
Console.WriteLine("-----------------------------Chapter 3,  Solution 7----------------------");
   Console.WriteLine("Enter weight of a man: ");
    int weight = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("This person will weight {0}kg on the Moon.", weight * 0.17);

// 8. Write an expression that checks for a given point {x, y} if it is within the circle K({0, 0}, R=5). Explanation: the point {0, 0} is the center of the circle and 5 is the radius.
Console.WriteLine("-----------------------------Chapter 3,  Solution 8----------------------");
    Console.Write("Enter x: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter y: ");
    int y = Convert.ToInt32(Console.ReadLine());
    bool isInside = (x * x * + y * y <= 25) ? true : false;
    Console.WriteLine("The point O({0},{1}) is inside K((0,0),5)?: {2}", x, y, isInside);



// 9. Write an expression that checks for given point {x, y} if it is within the circle K({0, 0}, R=5) and out of the rectangle [{-1, 1}, {5, 5}]. Clarification: for the rectangle the lower left and the upper right corners are given.
Console.WriteLine("-----------------------------Chapter 3,  Solution 9----------------------");

Console.Write("Enter x: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter y: ");
int Y = Convert.ToInt32(Console.ReadLine());
bool isInsideCircle = (X * X + Y * Y <= 5) ? true : false;
bool isOutsideRectangle = (X < -1 && X > 5 && Y < 1 && Y > 5) ? true : false;
Console.WriteLine("The point O({0},{1}) is inside K((0,0),5)?: {2}", X, Y, isInsideCircle);
Console.WriteLine("The point O({0},{1}) is outside rectangle ((-1, 1), (5, 5)?: {2}", X, Y, isOutsideRectangle);


// 10. Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following actions:
// - Calculates the sum of the digits (in our example 2+0+1+1 = 4).
// - Prints on the console the number in reversed order: dcba (in our example 1102).
// - Puts the last digit in the first position: dabc (in our example 1201).
// - Exchanges the second and the third digits: acbd (in our example 2101).
Console.WriteLine("-----------------------------Chapter 3,  Solution 10----------------------");

Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
int firstDigit = number / 1000;
int secondDigit = (number / 100) % 10;
int thirdDigit = (number / 10) % 10;
int fourthdigit = number % 10;
Console.WriteLine("1.Sum of digits = {0}", firstDigit + secondDigit + thirdDigit + fourthdigit);
Console.WriteLine("2.Digits backwards = {3}{2}{1}{0}", firstDigit, secondDigit, thirdDigit, fourthdigit);
Console.WriteLine("3.Last digit on first place = {3}{0}{1}{2}", firstDigit, secondDigit, thirdDigit, fourthdigit);
Console.WriteLine("4.Replace third and second digit = {0}{2}{1}{3}", firstDigit, secondDigit, thirdDigit, fourthdigit);


// 11. We are given a number n and a position p. Write a sequence of operations that prints the value of the bit on the position p in the number (0 or 1). Example: n=35, p=5 -> 1. Another example: n=35, p=6 -> 0.
Console.WriteLine("-----------------------------Chapter 3,  Solution 11----------------------");
int N = 35, pee = 6, i = 1, masK = i << pee;
Console.WriteLine((N & masK) != 0 ? "Third bit is 1" : "Third bit is 0");



// 12. Write a Boolean expression that checks if the bit on position p in the integer v has the value 1. Example v=5, p=1 -> false.
Console.WriteLine("-----------------------------Chapter 3,  Solution 12----------------------");
    int v = 350;
    int p = 350;
    int mask = 1 << p;
    bool isOne = (v & mask) != 0 ? true : false;
    Console.WriteLine("The bit at position {0}of number {1} is 1? {2}", p, v, isOne);

// 13. We are given the number n, the value v (v = 0 or 1) and the position p. write a sequence of operations that changes the value of n, so the bit on the position p has the value of v. Example: n=35, p=5, v=0 -> n=3. Another example: n=35, p=2, v=1 -> n=39.
Console.WriteLine("-----------------------------Chapter 3,  Solution 13----------------------");

    int n = 350;
    int V = 0;
    int P = 3;
    n = (V == 0) ? n = n & (~(1 << P)) : n = n | (1 << P);
    Console.WriteLine(n);

// 14. Write a program that checks if a given number n (1 < n < 100) is a prime number (i.e. it is divisible without remainder only to itself and 1).
Console.WriteLine("-----------------------------Chapter 3,  Solution 14----------------------");
Console.Write("Enter an integer: ");
int primeNumber = int.Parse(Console.ReadLine());
    bool isPrime = true;
    if (primeNumber > 2)
        for (int check = 2; check <= Math.Ceiling(Math.Sqrt(primeNumber)); ++check)
        {
            if (primeNumber % check == 0) isPrime = false;
        }
    Console.WriteLine("{0} is prime?: {1}", primeNumber, isPrime);


// 15. * Write a program that exchanges the values of the bits on positions 3, 4 and 5 with bits on positions 24, 25 and 26 of a given 32-bit unsigned integer.
Console.WriteLine("-----------------------------Chapter 3,  Solution 15----------------------");
Console.Write("Enter number: ");
int vee = Convert.ToInt32(Console.ReadLine());
int Mask = 1 << 3;
int bitAt3 = (vee & Mask) != 0 ? 1 : 0;
Mask = 1 << 4;
int bitAt4 = (vee & Mask) != 0 ? 1 : 0;
Mask = 1 << 5;
int bitAt5 = (vee & Mask) != 0 ? 1 : 0;
Mask = 1 << 24;
int bitAt24 = (vee & Mask) != 0 ? 1 : 0;
Mask = 1 << 25;
int bitAt25 = (vee & Mask) != 0 ? 1 : 0;
Mask = 1 << 26;
int bitAt26 = (vee & Mask) != 0 ? 1 : 0;
vee = (bitAt3 == 0) ? vee = vee & (~(1 << 24)) : vee = vee| (1 << 24);
vee = (bitAt4 == 0) ? vee = vee & (~(1 << 25)) : vee = vee | (1 << 25);
vee = (bitAt5 == 0) ? vee = vee & (~(1 << 26)) : vee = vee | (1 << 26);
vee = (bitAt24 == 0) ? vee = vee & (~(1 << 3)) : vee = vee | (1 << 3);
vee = (bitAt25 == 0) ? vee = vee & (~(1 << 4)) : vee = vee | (1 << 4);
vee = (bitAt26 == 0) ? vee = vee & (~(1 << 5)) : vee = vee | (1 << 5);
Console.WriteLine(vee);




// 16. * Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
// Console.WriteLine("-----------------------------Chapter 3,  Solution 16----------------------");


// uint numberAnswerSixteen; int pAnswerSixteen; int qAnswerSixteen; int kAnswerSixteen;
// int[] pBits = new int[kAnswerSixteen];
// int[] qBits = new int[kAnswerSixteen];
// for (int position = pAnswerSixteen, iAnswerSixteen = 0; iAnswerSixteen < pBits.Length; position++, iAnswerSixteen++)
// {
// pBits[iAnswerSixteen] = PthBit(numberAnswerSixteen, position);
// }

