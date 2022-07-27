// 1. Write an if-statement that takes two integer variables and exchanges their values if the first one is greater than the second one.
Console.WriteLine("-----------------------------Chapter 5,  Solution 1----------------------");

   Console.Write("Enter first number: ");
    int a = Int32.Parse(Console.ReadLine());
    Console.Write("Enter second number: ");
    int b = Int32.Parse(Console.ReadLine());    

    if (a > b)
    {
        a = a + b;
        b = a - b;
        a = a - b;
    }
    
    Console.WriteLine("First number - {0}, Second number - {1}.", a, b);









// 2. Write a program that shows the sign (+ or -) of the product of three real numbers, without calculating it. Use a sequence of if operators.
Console.WriteLine("-----------------------------Chapter 5,  Solution 2----------------------");



           Console.Write("Enter first number: ");
            int a2 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b2 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int c2 = Int32.Parse(Console.ReadLine());

            if (a2 < 0 && b2 < 0 && c2 < 0){ Console.WriteLine("-");}
            else if (a2 >= 0 && b2 >= 0 && c2 >= 0){ Console.WriteLine("+");}
            else if (a2 < 0 && b2 < 0 && c2 >= 0) {Console.WriteLine("+");}
            else if (a2 < 0 && b2 >= 0 && c2 < 0) {Console.WriteLine("+");}
            else if (a2 >= 0 && b2 < 0 && c2 < 0) {Console.WriteLine("+");}
            else if (a2 < 0 && b2 >= 0 && c2 >= 0){ Console.WriteLine("-");}
            else if (a2 >= 0 && b2 < 0 && c2 >= 0){ Console.WriteLine("-");}
            else if (a2 >= 0 && b2 >= 0 && c2 < 0) {Console.WriteLine("-");}











// 3. Write a program that finds the biggest of three integers, using nested if statements.
Console.WriteLine("-----------------------------Chapter 5,  Solution 3----------------------");


            Console.Write("Enter first number: ");
            int a3 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b3 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int c3 = Int32.Parse(Console.ReadLine());

            if (a3 > b3)
                if (a3 > c3){ Console.WriteLine("A is the biggest");}
                else if (a3 < c3) {Console.WriteLine("C is the biggest");}
                else {Console.WriteLine("A and C are the biggest");}
            else if (a3 < b3)
                if (b3 > c3) {Console.WriteLine("B is the biggest");}
                else if (b3 < c3) {Console.WriteLine("C is the biggest");}
                else {Console.WriteLine("B and C are the biggest");}
            else if (a3 == b3)
                if (a3 == c3) {Console.WriteLine("All are equal");}
                else if (a3 < c3) {Console.WriteLine("C is the biggest");}
                else {Console.WriteLine("A and B are the biggest");}











// 4. Sort 3 real numbers in descending order. Use nested if statements.
Console.WriteLine("-----------------------------Chapter 5,  Solution 4----------------------");
           Console.Write("Enter first number: ");
            int a4 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b4 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int c4 = Int32.Parse(Console.ReadLine());

            if (a4 < b4)
            {
                if (a4 < c4)
                {
                    a4 = a4 + c4;
                    c4 = a4 - c4;
                    a4 = a4 - c4;

                    if (b4 > c4)
                    {                        
                        a4 = a4 + b4;
                        b4 = a4 - b4;
                        a4 = a4 - b4;
                    }
                }
                else if (a4 >= c4)
                {
                    a4 = a4 + b4;
                    b4 = a4 - b4;
                    a4 = a4 - b4;
                }
            }
            else if (a4 == b4)
            {
                if (a4 < c4)
                {
                    a4 = a4 + c4;
                    c4 = a4 - c4;
                    a4 = a4 - c4;
                }
            }
            else
            {
                if (b4 < c4)
                {
                    b4 = b4 + c4;
                    c4 = b4 - c4;
                    b4 = b4 - c4;
                }
                if (a4 < b4)
                {
                    a4 = a4 + b4;
                    b4 = a4 - b4;
                    a4 = a4 - b4;
                }
            }
            Console.WriteLine("{0}, {1}, {2}", a4, b4, c4);
            Console.ReadLine();



// 5. Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English). Use a switch statement.

Console.WriteLine("-----------------------------Chapter 5,  Solution 5----------------------");

  Console.Write("Enter first number: ");
    int number = Int32.Parse(Console.ReadLine());

    switch (number)
    {
        case 0: Console.WriteLine("Nula"); break;
        case 1: Console.WriteLine("Edno"); break;
        case 2: Console.WriteLine("Dve"); break;
        case 3: Console.WriteLine("Tri"); break;
        case 4: Console.WriteLine("Chetiri"); break;
        case 5: Console.WriteLine("Pet"); break;
        case 6: Console.WriteLine("Shest"); break;
        case 7: Console.WriteLine("Sedem"); break;
        case 8: Console.WriteLine("Osem"); break;
        case 9: Console.WriteLine("Devet"); break;
        default: Console.WriteLine("Wrong input"); break;
    }






// 6. Write a program that gets the coefficients a, b and c of a quadratic equation: ax2 + bx + c, calculates and prints its real roots (if they exist). Quadratic equations may have 0, 1 or 2 real roots.
Console.WriteLine("-----------------------------Chapter 5,  Solution 6----------------------");


           Console.Write("Input A (not 0): ");
            sbyte a6 = Convert.ToSByte(Console.ReadLine());
            Console.Write("Input B: ");
            sbyte b6 = Convert.ToSByte(Console.ReadLine());
            Console.Write("Input C: ");
            sbyte c6 = Convert.ToSByte(Console.ReadLine());

            sbyte d6 = (sbyte)(b6 * b6 - 4 * a6 * c6);
            if (d6 < 0)
                Console.WriteLine("\nD={0}\nThere are no real roots.", d6);
            else if (d6 == 0)
            {
                sbyte x1 = (sbyte)(-b6 / 2 * a6);
                Console.WriteLine("\nX={0}", x1);
            }
            else
            {
                sbyte x1 = (sbyte)((-b6 + Math.Sqrt(d6)) / (2 * a6));
                sbyte x2 = (sbyte)((-b6 - Math.Sqrt(d6)) / (2 * a6));
                Console.WriteLine("\nX1={0}\nX2={1}", x1, x2);
            }
            Console.ReadLine();







// 7. Write a program that finds the greatest of given 5 numbers.
Console.WriteLine("-----------------------------Chapter 5,  Solution -7---------------------");

   Console.Write("Enter first number: ");
    int a7 = Int32.Parse(Console.ReadLine());
    Console.Write("Enter second number: ");
    int b7 = Int32.Parse(Console.ReadLine());
    Console.Write("Enter third number: ");
    int c7 = Int32.Parse(Console.ReadLine());
    Console.Write("Enter fourth number: ");
    int d7 = Int32.Parse(Console.ReadLine());
    Console.Write("Enter fifth number: ");
    int e7 = Int32.Parse(Console.ReadLine());
    
    if (a7 < b7) {a7 = b7;}
    if (a7 < c7) {a7 = c7;}
    if (a7 < d7){ a7 = d7;}
    if (a7 < e7) {a7 = e7;}
    
    Console.WriteLine("{0} is the biggest number.", a7);













// 8. Write a program that, depending on the user’s choice, inputs int, double or string variable. If the variable is int or double, the program increases it by 1. If the variable is a string, the program appends "*" at the end. Print the result at the console. Use switch statement.
Console.WriteLine("-----------------------------Chapter 5,  Solution 8----------------------");


            Console.Write("Enter variable type (0 - int, 1 - double, 2 string): ");
            int intVar = Int32.Parse(Console.ReadLine());

            switch (intVar)
            {
                case 0:
                    {
                        Console.Write("Enter int variable: ");
                        intVar = Int32.Parse(Console.ReadLine());
                        intVar++;
                        Console.WriteLine("Int variable +1 = {0}", intVar);
                        break;
                    }
                case 1:
                    {
                        Console.Write("Enter double variable: ");
                        double doubleVar = double.Parse(Console.ReadLine());
                        doubleVar++;
                        Console.WriteLine("Double variable +1 = {0}", doubleVar);
                        break;
                    }
                case 2:
                    {
                        Console.Write("Enter string variable: ");
                        string stringVar = Console.ReadLine();
                        stringVar = stringVar + '*';
                        Console.WriteLine("String variable +* = {0}", stringVar);
                        break;
                    }
                default: Console.WriteLine("Wrong input"); break;
            }




// 9. We are given 5 integer numbers. Write a program that finds those subsets whose sum is 0. Examples:
// - If we are given the numbers {3, -2, 1, 1, 8}, the sum of -2, 1 and 1 is 0.
// - If we are given the numbers {3, 1, -7, 35, 22}, there are no subsets with sum 0.
Console.WriteLine("-----------------------------Chapter 5,  Solution 9 ----------------------");


           Console.Write("Enter first number: ");
            sbyte first = Convert.ToSByte(Console.ReadLine());
            Console.Write("Enter second number: ");
            sbyte second = Convert.ToSByte(Console.ReadLine());
            Console.Write("Enter third number: ");
            sbyte third = Convert.ToSByte(Console.ReadLine());
            Console.Write("Enter fourth number: ");
            sbyte fourth = Convert.ToSByte(Console.ReadLine());
            Console.Write("Enter fifth number: ");
            sbyte fifth = Convert.ToSByte(Console.ReadLine());

            if(first + second == 0)
               { Console.WriteLine("{0}+ {1} = 0", first, second);}
            if (first + third == 0)
              {  Console.WriteLine("{0}+ {1} = 0", first, third);}
            if (first + fourth == 0)
               { Console.WriteLine("{0}+ {1} = 0", first, fourth);}
            if (first + fifth == 0)
                {Console.WriteLine("{0}+ {1} = 0", first, fifth);}
            if (second + third == 0)
               { Console.WriteLine("{0}+ {1} = 0", second, third);}
            if (second + fourth == 0)
                {Console.WriteLine("{0}+ {1} = 0", second, fourth);}
            if (second + fifth == 0)
               { Console.WriteLine("{0}+ {1} = 0", second, fifth);}
            if (third + fourth == 0)
               { Console.WriteLine("{0}+ {1} = 0", third, fourth);}
            if (third + fifth == 0)
                {Console.WriteLine("{0}+ {1} = 0", third, fifth);}
            if (fourth + fifth == 0)
                {Console.WriteLine("{0}+ {1} = 0", fourth, fifth);}
            if (first + second + third == 0)
                {Console.WriteLine("{0}+ {1}+ {2} = 0", first, second, third);}
            if (first + second + fourth == 0)
                {Console.WriteLine("{0}+ {1}+ {2} = 0", first, second, fourth);}
            if (first + second + fifth == 0)
                {Console.WriteLine("{0}+ {1}+ {2} = 0", first, second, fifth);}
            if (first + third + fourth == 0)
                {Console.WriteLine("{0}+ {1}+ {2} = 0", first, third, fourth);}
            if (first + third + fifth == 0)
               { Console.WriteLine("{0}+ {1}+ {2} = 0", first, third, fifth);}
            if (second + third + fourth == 0)
               { Console.WriteLine("{0}+ {1}+ {2} = 0", second, third, fourth);}
            if (second + third + fifth == 0)
                {Console.WriteLine("{0}+ {1}+ {2} = 0", second, third, fifth);}
            if (third + fourth + fifth == 0)
                {Console.WriteLine("{0}+ {1}+ {2} = 0", third, fourth, fifth);}

            Console.ReadLine();














// 10. Write a program that applies bonus points to given scores in the range [1…9] by the following rules:
// - If the score is between 1 and 3, the program multiplies it by 10.
// - If the score is between 4 and 6, the program multiplies it by 100.
// - If the score is between 7 and 9, the program multiplies it by 1000.
// - If the score is 0 or more than 9, the program prints an error message.
Console.WriteLine("-----------------------------Chapter 5,  Solution 10----------------------");
Random random = new Random();

 int number5 = random.Next(12);
int bonus5 = 0;
Console.WriteLine("your Score is : " + number5);
   
if (number5 <= 0 )
{
        Console.WriteLine( "Invalid Score");
}
    else if (number5 <=3) {
        bonus5 = 10;
    }
     else if (number5 <=6) {
        bonus5 = 100;
    }
     else if (number5 <=9) {
        bonus5 = 1000;
    }
     else if (number5 >9) {
        Console.WriteLine( "Invalid Score");
    }

    int Totalscore = number5 * bonus5;
    switch (number5)
    {
        case 1: Console.WriteLine("Your Score is " + number5 + " and bonus is " + bonus5 + " Your total score is " + Totalscore); break;
        case 2: Console.WriteLine("Your Score is " + number5 + " and bonus is " + bonus5 + " Your total score is " + Totalscore); break;
        case 3: Console.WriteLine("Your Score is " + number5 + " and bonus is " + bonus5 + " Your total score is " + Totalscore); break;
        case 4: Console.WriteLine("Your Score is " + number5 + " and bonus is " + bonus5 + " Your total score is " + Totalscore); break;
        case 5: Console.WriteLine("Your Score is " + number5 + " and bonus is " + bonus5 + " Your total score is " + Totalscore); break;
        case 6: Console.WriteLine("Your Score is " + number5 + " and bonus is " + bonus5 + " Your total score is " + Totalscore); break;
        case 7: Console.WriteLine("Your Score is " + number5 + " and bonus is " + bonus5 + " Your total score is " + Totalscore); break;
        case 8: Console.WriteLine("Your Score is " + number5 + " and bonus is " + bonus5 + " Your total score is " + Totalscore); break;
        case 9: Console.WriteLine("Your Score is " + number5 + " and bonus is " + bonus5 + " Your total score is " + Totalscore); break;
    }

















// 11. * Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation. Examples:
// - 0 --> "Zero"
// - 12 --> "Twelve"
// - 98 --> "Ninety eight"
// - 273 --> "Two hundred seventy three"
// - 400 --> "Four hundred"
// - 501 --> "Five hundred and one"
// - 711 --> "Seven hundred and eleven"
Console.WriteLine("-----------------------------Chapter 5,  Solution 11----------------------");
            Console.Write("Enter a number between 0 and 999: ");
            short number11 = Convert.ToInt16(Console.ReadLine());

            byte hundreds = (byte)(number11 / 100 | 0);
            byte tensAndOnes;

            if (number11 > 99) tensAndOnes = (byte)(number11 % 100);
            else tensAndOnes = (byte)(number11 * 1);

            byte ones = (byte)(number11 % 10);

            switch (hundreds)
            {
                case 1: Console.Write("One hundred "); break;
                case 2: Console.Write("Two hundred "); break;
                case 3: Console.Write("Three hundred "); break;
                case 4: Console.Write("Four hundred "); break;
                case 5: Console.Write("Five hundred "); break;
                case 6: Console.Write("Six hundred "); break;
                case 7: Console.Write("Seven hundred "); break;
                case 8: Console.Write("Eight hundred "); break;
                case 9: Console.Write("Nine hundred "); break;
            }

            if (hundreds >= 1 && tensAndOnes >= 1) Console.Write("and ");

            if (tensAndOnes >= 20 && tensAndOnes < 30) Console.Write("Twenty");
            else if (tensAndOnes >= 30 && tensAndOnes < 40) Console.Write("Thirty");
            else if (tensAndOnes >= 40 && tensAndOnes < 50) Console.Write("Fourty");
            else if (tensAndOnes >= 50 && tensAndOnes < 60) Console.Write("Fifty");
            else if (tensAndOnes >= 60 && tensAndOnes < 70) Console.Write("Sixty");
            else if (tensAndOnes >= 70 && tensAndOnes < 80) Console.Write("Seventy");
            else if (tensAndOnes >= 80 && tensAndOnes < 90) Console.Write("Eighty");
            else if (tensAndOnes >= 90 && tensAndOnes < 100) Console.Write("Ninety");

            switch(tensAndOnes)
            {
                case 1: Console.Write("One"); break;
                case 2: Console.Write("Two"); break;
                case 3: Console.Write("Three"); break;
                case 4: Console.Write("Four"); break;
                case 5: Console.Write("Five"); break;
                case 6: Console.Write("Six"); break;
                case 7: Console.Write("Seven"); break;
                case 8: Console.Write("Eight"); break;
                case 9: Console.Write("Nine"); break;
                case 10: Console.Write("Ten"); break;
                case 11: Console.Write("Eleven"); break;
                case 12: Console.Write("Twelve"); break;
                case 13: Console.Write("Thirteen"); break;
                case 14: Console.Write("Fourteen"); break;
                case 15: Console.Write("Fifteen"); break;
                case 16: Console.Write("Sixteen"); break;
                case 17: Console.Write("Seventeen"); break;
                case 18: Console.Write("Eighteen"); break;
                case 19: Console.Write("Nineteen"); break;                
            }
            if (tensAndOnes > 20)
            {
                switch (ones)
                {
                    case 1: Console.Write("-one"); break;
                    case 2: Console.Write("-two"); break;
                    case 3: Console.Write("-three"); break;
                    case 4: Console.Write("-four"); break;
                    case 5: Console.Write("-five"); break;
                    case 6: Console.Write("-six"); break;
                    case 7: Console.Write("-seven"); break;
                    case 8: Console.Write("-eight"); break;
                    case 9: Console.Write("-nine"); break;
                }
            }
	        if (number11 == 0) Console.Write("Zero");
            Console.ReadLine();