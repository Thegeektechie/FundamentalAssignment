// 1. Declare several variables by selecting for each one of them the most appropriate of the types sbyte, byte, short, ushort, int, uint, long and ulong in order to assign them the following values: 52,130; -115; 4825932; 97; -10000; 20000; 224; 970,700,000; 112; -44; -1,000,000; 1990; 123456789123456789.
using System.Security.Cryptography;

Console.WriteLine("-----------------------------Chapter 2,  Solution 1----------------------");
        ushort number1 = 52130;
        sbyte number2 = -115;
        uint number3 = 4825932;
        byte number4 = 97;
        short number5 = -10000;
        short number6 = 20000;
        byte number7 = 224;
        uint number8 = 970700000;
        sbyte number9 = 112;
        sbyte number10 = -44;
        int number11 = -1000000;
        ushort number12 = 1992;
        long number13 = 123456789123456789;
        Console.WriteLine("ushort: " + number1 + ", sbyte: " + number2 + ", uint: " + number3 + ", byte: " + number4 + ", short: " + number5 + ", short: " + number6 + ", byte: " + number7 + ", uint: " + number8 + ", sbyte: " + number9 + ", sbyte: " + number10 + ", int: " + number11 + ", ushort: " + number12 + ", long: " + number13);


// 2. Which of the following values can be assigned to variables of type float, double and decimal: 5, -5.01, 34.567839023; 12.345; 8923.1234857; 3456.091124875956542151256683467?
Console.WriteLine("-----------------------------Chapter 2,  Solution 2----------------------");
        double numberOne = 34.567839023;
        float numberTwo = 12.345f;
        double numberThree = 8923.1234857;
        decimal numberFour = 3456.091124875956542151256683467m;  
        Console.WriteLine("Double: " + numberOne + ", Float: " + numberTwo + ", Double: " + numberThree + ", Decimal: " + numberFour);  

// 3. Write a program, which compares correctly two real numbers with accuracy at least 0.000001.
Console.WriteLine("-----------------------------Chapter 2,  Solution 3----------------------");
 decimal one = 5.25745243896m;
        decimal two = 9.8544531763m;
        one += two;
        Console.WriteLine(one.ToString("#.######"));


// 4. Initialize a variable of type int with a value of 256 in hexadecimal format (256 is 100 in a numeral system with base 16).
Console.WriteLine("-----------------------------Chapter 2,  Solution 4----------------------");
   int number = 0x100;
    Console.WriteLine(number);

 
// 5. Declare a variable of type char and assign it as a value the character, which has Unicode code, 72 (use the Windows calculator in order to find hexadecimal representation of 72).
Console.WriteLine("-----------------------------Chapter 2,  Solution 5----------------------");
int characterCheck = 0x10;
Console.WriteLine(characterCheck);

// 6. Declare a variable isMale of type bool and assign a value to it depending on your gender.
Console.WriteLine("-----------------------------Chapter 2,  Solution 6----------------------");
bool isMale = true;
Console.WriteLine(isMale);

// 7. Declare two variables of type string with values "Hello" and "World". Declare a variable of type object. Assign the value obtained of concatenation of the two string variables (add space if necessary) to this variable. Print the variable of type object.
Console.WriteLine("-----------------------------Chapter 2,  Solution 7----------------------");
        string str1 = "Hello";
        string str2 = "World";
        object obj = str1 + " " + str2;
        Console.WriteLine(obj);

// 8. Declare two variables of type string and give them values "Hello" and "World". Assign the value obtained by the concatenation of the two variables of type string (do not miss the space in the middle) to a variable of type object. Declare a third variable of type string and initialize it with the value of the variable of type object (you should use type casting).
Console.WriteLine("-----------------------------Chapter 2,  Solution 8----------------------");
       string firstStr = "Hello";
        string secondStr = "World";
        object strCombo = firstStr + " " + secondStr;
        string thirdStr = strCombo.ToString();
        Console.WriteLine(thirdStr);
 
// 9. Declare two variables of type string and assign them a value “The "use" of quotations causes difficulties.” (without the outer quotes). In one of the variables use quoted string and in the other do not use it.
    Console.WriteLine("-----------------------------Chapter 2,  Solution 9----------------------");
string firstInput = "\"The \"use\" of quotations causes difficulties.\"";
string secondInput = "The \"use\" of quotations causes difficulties.";
Console.WriteLine(firstInput);
Console.WriteLine(secondInput);

// 10. Write a program to print a figure in the shape of a heart by the sign "o".
Console.WriteLine("-----------------------------Chapter 2,  Solution 10----------------------");
        Console.WriteLine("  0        0 ");
        Console.WriteLine("0   0    0   0");
        Console.WriteLine(" 0   0  0   0");
        Console.WriteLine("  0   00   0");
        Console.WriteLine("   0      0 ");
        Console.WriteLine("    0    0  ");
        Console.WriteLine("     0  0   ");
        Console.WriteLine("      00   ");
       

// 11. Write a program that prints on the console isosceles triangle which sides consist of the copyright character "©".
Console.WriteLine("-----------------------------Chapter 2,  Solution 11----------------------");
        Console.WriteLine("    ©");
        Console.WriteLine("   © ©");
        Console.WriteLine("  ©   ©");
        Console.WriteLine(" ©     ©");
        Console.WriteLine("©©©©©©©©©");

// 12. A company dealing with marketing wants to keep a data record of its employees. Each record should have the following characteristic – first name, last name, age, gender (‘m’ or ‘f’) and unique employee number (27560000 to 27569999). Declare appropriate variables needed to maintain the information for an employee by using the appropriate data types and attribute names.
Console.WriteLine("-----------------------------Chapter 2,  Solution 12----------------------");

Random id = new Random();

 Console.Write("Enter your First name: ");
string firstName= Console.ReadLine();
Console.Write("Enter your Last Name: ");
        string lastName= Console.ReadLine();
 Console.Write("Enter your age: ");
        byte age = byte.Parse(Console.ReadLine());
Console.Write("Enter the first letter of your Gender: M or F: ");
        char gender = Convert.ToChar(Console.ReadLine());
        
        Console.WriteLine($"Your first name is {firstName}, Your last name is {lastName},  your age is {age} and your unique employee number {id.Next(27560000, 27569999)} ");







// 13. Declare two variables of type int. Assign to them values 5 and 10 respectively. Exchange (swap) their values and print them.

        int a = 2;
        int b = 3;
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine($"a:{0} b:{1}", a, b);

















// int one = int.Parse(num[0].ToString());// Console.WriteLine(" 2. Which of the following values can be assigned to variables of type float, double and decimal: 5, -5.01, 34.567839023; 12.345; 8923.1234857; 3456.091124875956542151256683467? ");
// // Console.WriteLine("3. Write a program, which compares correctly two real numbers with accuracy at least 0.000001.  ");
// // Console.WriteLine("4. Initialize a variable of type int with a value of 256 in hexadecimal format (256 is 100 in a numeral system with base 16).  ");
// // Console.WriteLine(" 6. Declare a variable isMale of type bool and assign a value to it depending on your gender. ");
// // // Console.WriteLine(" 7. Declare two variables of type string with values \"Hello\" and \"World\". Declare a variable of type object. Assign the value obtained of concatenation of the two string variables (add space if necessary) to this variable. Print the variable of type object. ");
// // Console.WriteLine("  ");
// // Console.WriteLine("  ");
// // Console.WriteLine("  ");
// // Console.WriteLine("  ");
// // Console.WriteLine("  ");
// Console.WriteLine("Enter four digits:  ");
// string num = Console.ReadLine();
// int one = int.Parse(num[0].ToString());
// int two = int.Parse(num[1].ToString());
// int three = int.Parse(num[2].ToString());
// int four = int.Parse(num[3].ToString());
// int total = one + two + three + four;
// Console.WriteLine("the sum of the four input is: " + total );
// Console.WriteLine("Write in reverse form: " + four + three + two + one);
// Console.WriteLine("Put the last digit in the first place: " + four + one + two + three);
// Console.WriteLine("Exchange the second number with the third number: " + one + three + two + four);