// 1. Convert the numbers 151, 35, 43, 251, 1023 and 1024 to the binary numeral system.
Console.WriteLine("-----------------------------Chapter 8,  Solution 1----------------------");
Console.Write("Coversion of 151 to Binary is: ");
    int Decimal1 = 151;
string Binary1 = Convert.ToString(Decimal1, 2);
Console.WriteLine("Result is {0}", Binary1);
Console.Write("Coversion of 35 to Binary is: ");
    int Decimal2 = 35;
string Binary2 = Convert.ToString(Decimal2, 2);
Console.WriteLine("Result is {0}", Binary2);
Console.Write("Coversion of 43 to Binary is: ");
    int Decimal3 = 43;
string Binary3 = Convert.ToString(Decimal3, 2);
Console.WriteLine("Result is {0}", Binary3);
Console.Write("Coversion of 251 to Binary is: ");
    int Decimal4 = 251;
string Binary4 = Convert.ToString(Decimal4, 2);
Console.WriteLine("Result is {0}", Binary4);
Console.Write("Coversion of 1023 to Binary is: ");
    int Decimal5 = 1023;
string Binary5 = Convert.ToString(Decimal5, 2);
Console.WriteLine("Result is {0}", Binary5);
Console.Write("Coversion of 1024 to Binary is: ");
    int Decimal6 = 1024;
string Binary6 = Convert.ToString(Decimal6, 2);
Console.WriteLine("Result is {0}", Binary6);
Console.WriteLine(" ");

// 2. Convert the number 1111010110011110(2) to hexadecimal and decimal numeral systems.
Console.WriteLine("-----------------------------Chapter 8,  Solution 2----------------------");
Console.Write("Conversion of 1111010110011110(2) to Hexadecimal is: ");
string BinaryToHexa1 = "1111010110011110";
string HexaResult1 = Convert.ToString(Convert.ToInt32(BinaryToHexa1, 2), 16);
Console.WriteLine("Result is {0}", HexaResult1);

Console.Write("Conversion of 1111010110011110(2) to Decimal is: ");
string binaryToDecimal1 = Convert.ToString(Convert.ToInt32(BinaryToHexa1, 2), 10);
Console.WriteLine("Result is {0}", binaryToDecimal1);

Console.WriteLine(" ");



// 3. Convert the hexadecimal numbers FA, 2A3E, FFFF, 5A0E9 to binary and decimal numeral systems.
Console.WriteLine("-----------------------------Chapter 8,  Solution 3----------------------");
Console.Write("Conversion of FA to Binary is: ");
string HexaToBinary1 = "FA";
string BinaryResult1 = Convert.ToString(Convert.ToInt32(HexaToBinary1, 16), 2);
Console.WriteLine("Result is {0}", BinaryResult1);
Console.Write("Conversion of FA to decimal is: ");
string HexatoDecimal1 = Convert.ToString(Convert.ToInt32(HexaToBinary1, 16), 10);
Console.WriteLine("Result is {0}", HexatoDecimal1);
Console.WriteLine(" ");

Console.Write("Conversion of 2A3E to Binary is: ");
string HexaToBinary2 = "2A3E";
string BinaryResult2 = Convert.ToString(Convert.ToInt32(HexaToBinary2, 16), 2);
Console.WriteLine("Result is {0}", BinaryResult2);
Console.Write("Conversion of 2A3E to decimal is: ");
string HexatoDecimal2 = Convert.ToString(Convert.ToInt32(HexaToBinary2, 16), 10);
Console.WriteLine("Result is {0}", HexatoDecimal2);
Console.WriteLine(" ");

Console.Write("Conversion of FFFF to Binary is: ");
string HexaToBinary3 = "FFFF";
string BinaryResult3 = Convert.ToString(Convert.ToInt32(HexaToBinary3, 16), 2);
Console.WriteLine("Result is {0}", BinaryResult3);
Console.Write("Conversion of FFFF to decimal is: ");
string HexatoDecimal3 = Convert.ToString(Convert.ToInt32(HexaToBinary3, 16), 10);
Console.WriteLine("Result is {0}", HexatoDecimal3);
Console.WriteLine(" ");

Console.Write("Conversion of 5A0E9 to Binary is: ");
string HexaToBinary4 = "5A0E9";
string BinaryResult4 = Convert.ToString(Convert.ToInt32(HexaToBinary4, 16), 2);
Console.WriteLine("Result is {0}", BinaryResult4);
Console.Write("Conversion of 5A0E9 to decimal is: ");
string HexatoDecimal4 = Convert.ToString(Convert.ToInt32(HexaToBinary4, 16), 10);
Console.WriteLine("Result is {0}", HexatoDecimal4);
Console.WriteLine(" ");




// 4. Write a program that converts a decimal number to binary one.
Console.WriteLine("-----------------------------Chapter 8,  Solution 4----------------------");
Console.Write("Enter Decimal Number: ");
    int Decimal = Int32.Parse(Console.ReadLine());
string Binary = Convert.ToString(Decimal, 2);
Console.WriteLine("Result is {0}", Binary);



// 5. Write a program that converts a binary number to decimal one.
Console.WriteLine("-----------------------------Chapter 8,  Solution 5----------------------");
Console.Write("Enter binary number: ");
string binaryNumber = (Console.ReadLine());
string binaryToDecimal = Convert.ToString(Convert.ToInt32(binaryNumber, 2), 10);
Console.WriteLine("Result is {0}", binaryToDecimal);

// 6. Write a program that converts a decimal number to hexadecimal one.
Console.WriteLine("-----------------------------Chapter 8,  Solution 6----------------------");

Console.Write("Enter decimal number: ");
    int decimalnum = Int32.Parse(Console.ReadLine());
string HexaDecimal = Convert.ToString(decimalnum, 16);
Console.WriteLine("Result is {0}", HexaDecimal);


// 7. Write a program that converts a hexadecimal number to decimal one.
Console.WriteLine("-----------------------------Chapter 8,  Solution 7----------------------");

Console.Write("Enter hexadecimal number: ");
string hexaDecimal = (Console.ReadLine());
string HexatoDecimal = Convert.ToString(Convert.ToInt32(hexaDecimal, 16), 10);
Console.WriteLine("Result is {0}", HexatoDecimal);



// 8. Write a program that converts a hexadecimal number to binary one.
Console.WriteLine("-----------------------------Chapter 8,  Solution 8----------------------");

Console.Write("Enter HexaDecimal Number: ");
string HexaToBinary = (Console.ReadLine());
string BinaryResult = Convert.ToString(Convert.ToInt32(HexaToBinary, 16), 2);
Console.WriteLine("Result is {0}", BinaryResult);



// 9. Write a program that converts a binary number to hexadecimal one.
Console.WriteLine("-----------------------------Chapter 8,  Solution 9----------------------");

Console.Write("Enter Binary Number: ");
string BinaryToHexa = (Console.ReadLine());
string HexaResult = Convert.ToString(Convert.ToInt32(BinaryToHexa, 2), 16);
Console.WriteLine("Result is {0}", HexaResult);




// 10. Write a program that converts a binary number to decimal using the Horner scheme.
Console.WriteLine("-----------------------------Chapter 8,  Solution 10----------------------");

    int deci = 0;

            Console.Write("Enter binary number: ");
            string binary = Console.ReadLine();
            int length = binary.Length;
            int power = length - 1;

            for (int i = 0; i < length; i++)
            {
                deci += (int)(int.Parse(binary[i].ToString()) * Math.Pow(2, power));
                power--;
            }

            Console.WriteLine("Result is {0}.", deci);



// 11. Write a program that converts Roman digits to Arabic ones.
Console.WriteLine("-----------------------------Chapter 8,  Solution 11----------------------");
int result = 0;
Console.Write("Enter Roman number: ");
String s = Console.ReadLine();
string[] chars = s.Select(c => c.ToString()).ToArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == "m" || chars[i] == "M") result += 1000;
                if (chars[i] == "d" || chars[i] == "D") result += 500;
                if (chars[i] == "c" || chars[i] == "C")
                {
        result += 100;
                    if (i < chars.Length - 1)
                    {
                        if (chars[i + 1] == "d" || chars[i + 1] == "D") result -= 200;
                        if (chars[i + 1] == "m" || chars[i + 1] == "M") result -= 200;
                    }
                }
                if (chars[i] == "l" || chars[i] == "L") result += 50;
                if (chars[i] == "x" || chars[i] == "X")
                {
        result += 10;
                    if (i < chars.Length - 1)
                    {
                        if (chars[i + 1] == "l" || chars[i + 1] == "L") result -= 20;
                        if (chars[i + 1] == "c" || chars[i + 1] == "C") result -= 20;
                    }
                }
                if (chars[i] == "v" || chars[i] == "V") result += 5;
                if (chars[i] == "i" || chars[i] == "I")
                {
        result++;
                    if (i < chars.Length - 1)
                    {
                        if (chars[i + 1] == "v" || chars[i + 1] == "V") result -= 2;
                        if (chars[i + 1] == "x" || chars[i + 1] == "X") result -= 2;
                    }
                }
            }

Console.WriteLine("Arabic number is " + result);




// 12. Write a program that converts Arabic digits to Roman ones.
Console.WriteLine("-----------------------------Chapter 8,  Solution 12----------------------");

















// 13. Write a program that by given N, S, D (2 ≤ S, D ≤ 16) converts the number N from an S-based numeral system to a D based numeral system.
Console.WriteLine("-----------------------------Chapter 8,  Solution 13----------------------");

int S, D;

Console.Write("Enter N: ");
string N = Console.ReadLine();
            
            do
            {
    Console.Write("Enter S (S == 2, 8, 10 or 16): ");
    S = Int32.Parse(Console.ReadLine());
            } while (S != 2 && S != 8 && S != 10 && S != 16);

            do
            {
    Console.Write("Enter D (D == 2, 8, 10 or 16): ");
                D = Int32.Parse(Console.ReadLine());
            } while (D != 2 && D != 8 && D != 10 && D != 16);

            N = Convert.ToString(Convert.ToInt32(N, S), D);

Console.WriteLine($"Result is {N}.");




// 14. Try adding up 50,000,000 times the number 0.000001. Use a loop and addition (not direct multiplication). Try it with float and double and after that with decimal. Do you notice the huge difference in the results and speed of calculation? Explain what happens.
Console.WriteLine("-----------------------------Chapter 8,  Solution 14----------------------");














// 15. * Write a program that prints the value of the mantissa, the sign of the mantissa and exponent in float numbers (32-bit numbers with a floating-point according to the IEEE 754 standard). Example: for the number -27.25 should be printed: sign = 1, exponent = 10000011, mantissa = 10110100000000000000000.
Console.WriteLine("-----------------------------Chapter 8,  Solution 15----------------------");



