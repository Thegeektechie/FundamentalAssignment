// 1. Write a program that prints on the console the numbers from 1 to N. The number N should be read from the standard input.

    Console.Write("Enter first number: ");
    int length = Int32.Parse(Console.ReadLine());
    
    for (int i = 1; i < length; i++)
        Console.WriteLine(i);




// 2. Write a program that prints on the console the numbers from 1 to N, which are not divisible by 3 and 7 simultaneously. The number N should be read from the standard input.


Console.Write("Enter your number to check number not divisible by 3 and 7 simultaneously: ");
            int length6 = Int32.Parse(Console.ReadLine());

            for (int i6 = 1; i6 < length6; i6++)
            {
                if (i6 % (3 * 7) != 0) Console.WriteLine(i6);
            }




// 3. Write a program that reads from the console a series of integers and prints the smallest and largest of them.

         int lowest = 0, highest = 0, input;

            Console.Write("Enter numbers length: ");
            int lenght = Int32.Parse(Console.ReadLine());            

            for (int i = 0; i < lenght; i++)
            {
                Console.Write("Enter number: ");
                input = Int32.Parse(Console.ReadLine());
                if (i == 0) lowest = highest = input;
                else
                {
                    if (lowest > input) lowest = input;
                    if (highest < input) highest = input;
                }                
            }
            Console.WriteLine("Lowest - {0}, Highest - {1}", lowest, highest);





// 4. Write a program that prints all possible cards from a standard deck of cards, without jokers (there are 52 cards: 4 suits of 13 cards).


 for (int i7 = 0; i7 < 4; i7++)
            {
                if(i7 != 0) Console.WriteLine();

                for (int j7 = 0; j7 < 13; j7++)
                {
                    switch (i7)
                    {
                        case 0: Console.Write("Hearts "); break;
                        case 1: Console.Write("Diamonds "); break;
                        case 2: Console.Write("Spades "); break;
                        case 3: Console.Write("Clubs "); break;
                    }
                    switch(j7)
                    {
                        case 0: Console.WriteLine("2"); break;
                        case 1: Console.WriteLine("3"); break;
                        case 2: Console.WriteLine("4"); break;
                        case 3: Console.WriteLine("5"); break;
                        case 4: Console.WriteLine("6"); break;
                        case 5: Console.WriteLine("7"); break;
                        case 6: Console.WriteLine("8"); break;
                        case 7: Console.WriteLine("9"); break;
                        case 8: Console.WriteLine("10"); break;
                        case 9: Console.WriteLine("J"); break;
                        case 10: Console.WriteLine("Q"); break;
                        case 11: Console.WriteLine("K"); break;
                        case 12: Console.WriteLine("A"); break;
                    }
                }
            }





// 5. Write a program that reads from the console number N and print the sum
// of the first N members of the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8,
// 13, 21, 34, 55, 89, 144, 233, 377, …


   Console.WriteLine("Please enter your Fibonacci number:");
        int Fibonacci1 = int.Parse(Console.ReadLine());
 
        if (Fibonacci1 == 0)
        {
            Console.WriteLine("Invalid input!");
            return;
        }
        else if (Fibonacci1 == 1)
        {
            Console.WriteLine(0);
            return;
        }
 
        int x1 = 0;
        int x2 = 1;
        Console.Write("{0} {1} ", x1, x2);
 
        for (int i8 = 2; i8 < Fibonacci1; i8++)
        {
            int x3 = x1 + x2;
            Console.Write("{0} ", x3);
            x1 = x2;
            x2 = x3;
        }
        Console.WriteLine();







// 6. Write a program that calculates N!/K! for given N and K (1<K<N).


   Console.Write("Enter N: (1<K<N) ");
    int n = Int32.Parse(Console.ReadLine());
    Console.Write("Enter K: (1<K<N) ");
    int k = Int32.Parse(Console.ReadLine());
    
    for (int i = n - 1; i > 0; i--)
    {
        n *= i;
    }
    
    for (int i = k - 1; i > 0; i--)
    {
        k *= i;
    }
    
    n /= k;    
    Console.WriteLine("Result is {0}", n);





// 7. Write a program that calculates N!*K!/(N-K)! for given N and K
// (1<K<N).

           Console.Write("Enter N: (1<K<N) ");
            int calcN = Int32.Parse(Console.ReadLine());
            Console.Write("Enter K: (1<K<N) ");
            int calcK = Int32.Parse(Console.ReadLine());
            int nMinusK = calcN - calcK;

            for (int i = calcN - 1; i > 0; i--)
            { calcN *= i;
            }
            for (int i = calcK - 1; i > 0; i--) 
            {calcK *= i;
            }
            for (int i = nMinusK - 1; i > 0; i--) 
            {nMinusK *= i;
            }
            Console.WriteLine("Result is {0}", calcN * calcK / nMinusK);






// 8. In combinatorics, the Catalan numbers are calculated by the following
// formula:
// ( 1)! !
// 2 (2 )!
// 1
// 1
// n n
// n
// n
// n
// n
// Cn 
//   
// 
// 
//  
// 
// 
// 
//  , for n ≥ 0. Write a program that
// calculates the nth Catalan number by given n.

            Console.Write("Enter N: (N >=0 ) ");
            int nunber8 = Int32.Parse(Console.ReadLine());

            int fact2N = 2 * nunber8, factNplus1 = nunber8 + 1;

            for (int i = fact2N - 1; i > 0; i--) 
            {fact2N *= i;
            }
            for (int i = factNplus1 - 1; i > 0; i--) 
            {factNplus1 *= i;
            }
            
            for (int i = nunber8 - 1; i > 0; i--) 
            {nunber8 *= i;
            }
            Console.WriteLine("Result is {0}", fact2N / (factNplus1 * nunber8));


// 9. Write a program that for a given integers n and x, calculates the sum:
// n x
// n
// x x
// S 1 1! 2! ... ! 2     


    int sum = 1, temp = 1;
    Console.Write("Enter n: ");
    int nunber9 = Int32.Parse(Console.ReadLine());
    Console.Write("Enter x: ");
    int nunber9x = Int32.Parse(Console.ReadLine());
    
    for (int i = 1; i <= nunber9; i++)
    {
        temp *= i / nunber9x;
        sum += temp;
    }    
    
    Console.WriteLine("Result is {0}", sum);

// 10. Write a program that reads from the console a positive integer number
// N (N < 20) and prints a matrix of numbers as on the figures below:
// N = 3 N = 4
// 1 2 3
// 2 3 4
// 3 4 5
// 1 2 3 4
// 2 3 4 5
// 3 4 5 6
// 4 5 6 7



    Console.Write("Enter N: (N < 20) ");
    int nunber10 = Int32.Parse(Console.ReadLine());
        
    for (int i = 1; i <= nunber10; i++)
    {
        for (int j = i; j <= i; j++)
        {
            Console.Write("{0} ", j);
        }
        Console.WriteLine();
    }        


// 11. Write a program that calculates with how many zeroes the factorial of
// a given number ends. Examples:
// N = 10 -> N! = 3628800 -> 2
// N = 20 -> N! = 2432902008176640000 -> 4


   Console.Write("Enter N: ");
    decimal nunber11 = Int32.Parse(Console.ReadLine());
    int zeroes = 0;
    
    for (int i = (int)(nunber11 - 1); i > 0; i--)
       { nunber11 *= i;
    }
    Console.Write("N! is {0} and it ends ", nunber11);
    
    do
    {
        nunber11 /= 10;
        zeroes++;
    } while (nunber11 % 10 == 0);
    
    Console.WriteLine("with {0} zeroes.", zeroes);




// 12. Write a program that converts a given number from decimal to binary
// notation (numeral system).


 Console.Write("Enter Decimal Number: ");
    int Decimal = Int32.Parse(Console.ReadLine());    
    string Binary = Convert.ToString(Decimal, 2);
    Console.WriteLine("Result is {0}", Binary);



// 13. Write a program that converts a given number from binary to decimal
// notation.


                    Console.Write("Enter binary number: ");
    string Binumber = (Console.ReadLine());
    string BitoDecimal = Convert.ToString(Convert.ToInt32(Binumber, 2), 10);
    Console.WriteLine("Result is {0}", BitoDecimal);



// 14. Write a program that converts a given number from decimal to
// hexadecimal notation.



Console.Write("Enter decimal number: ");
    int decimalnum = Int32.Parse(Console.ReadLine());
    string HexaDecimal = Convert.ToString(decimalnum, 16);
    Console.WriteLine("Result is {0}", HexaDecimal);


// 15. Write a program that converts a given number from hexadecimal to
// decimal notation.



Console.Write("Enter hexadecimal number: ");
  string hexaDecimal = (Console.ReadLine());
    string HexatoDecimal = Convert.ToString(Convert.ToInt32(hexaDecimal, 16), 10);
    Console.WriteLine("Result is {0}", HexatoDecimal);






// 16. Write a program that by a given integer N prints the numbers from 1 to N
// in random order.


            Random rnd = new Random();
            int temp16, randomNumber;
            Console.Write("Enter number: ");
            int n16 = Int32.Parse(Console.ReadLine());
            int[] arr = new int[n16];            

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }

            foreach (int i in arr)
            {                
                randomNumber = rnd.Next(0, n16);
                temp16 = arr[i];
                arr[i] = arr[randomNumber];
                arr[randomNumber] = temp16;                
            }

            foreach (int i in arr) Console.WriteLine(arr[i]);


// 17. Write a program that given two numbers finds their greatest common
// divisor (GCD) and their least common multiple (LCM). You may use
// the formula LCM(a, b) = |a*b| / GCD(a, b).













// 18. * Write a program that for a given number n, outputs a matrix in the form of a spiral:
// Example for n=4:

// 1
// 2
// 3
// 412
// 13
// 14
// 5
// 11
// 16
// 15
// 6
// 10
// 9
// 8
// 7


        Console.Write("Enter N: ");
            int number18 = Int32.Parse(Console.ReadLine());            
            int[,] matrix = new int[number18, number18];
            int row = 0, col = 0, direction = 0;

            for (int i = 1; i <= number18 * number18; i++)
            {
                switch(direction)
                {
                    case 0:
                            if (col > number18 - 1 || matrix[row, col] != 0)
                            {
                                direction = 1;
                                col--;
                                row++;
                            }
                            break;
                    case 1:
                            if (row > number18 - 1 || matrix[row, col] != 0)
                            {
                                direction = 2;
                                row--;
                                col--;
                            }
                            break;
                    case 2:
                            if (col < 0 || matrix[row, col] != 0)
                            {
                                direction = 3;
                                col++;
                                row--;
                            }
                            break;
                    case 3:
                            if (row < 0 || matrix[row, col] != 0)
                            {
                                direction = 0;
                                row++;
                                col++;
                            }
                            break;
                }

                matrix[row, col] = i;                

                switch(direction)
                {
                    case 0: col++; break;
                    case 1: row++; break;
                    case 2: col--; break;
                    case 3: row--; break;
                }
            }
            for (int i = 0; i < number18; i++)
            {
                for (int j = 0; j < number18; j++)
                {
                    if (matrix[i, j] < 10) Console.Write("{0}  ", matrix[i, j]);
                    else Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }

