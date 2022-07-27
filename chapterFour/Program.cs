// 1. Write a program that reads from the console three numbers of type int and prints their sum.
Console.WriteLine("-----------------------------Chapter 4,  Solution 1----------------------");
   Console.Write("First Number: ");
    int firstInput = Int32.Parse(Console.ReadLine());
    Console.Write("Second number: ");
    int secondInput = Int32.Parse(Console.ReadLine());
    Console.Write("Third number: ");
    int thirdInput = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Result is {0}", firstInput + secondInput + thirdInput);

// 2. Write a program that reads from the console the radius "r" of a circle and prints its perimeter and area.
Console.WriteLine("-----------------------------Chapter 4,  Solution 2----------------------");
   Console.Write("Enter radius: ");
    int r = Int32.Parse(Console.ReadLine());
    Console.WriteLine("P is {0} and S is {1}", 2 * Math.PI * r, Math.PI * r * r);

// 3. A given company has name, address, phone number, fax number, web site and manager. The manager has name, surname and phone number. Write a program that reads information about the company and its manager and then prints it on the console.
Console.WriteLine("-----------------------------Chapter 4,  Solution 3----------------------");

Console.Write("Enter company name: ");
            string compName = Console.ReadLine();
            Console.Write("Enter company address: ");
            string compAddr = Console.ReadLine();
            Console.Write("Enter company phone number: ");
            long compPhone = Convert.ToInt64(Console.ReadLine());
            Console.Write("Enter company fax: ");
            string compFax = Console.ReadLine();
            Console.Write("Enter company website: ");
            string compSite = Console.ReadLine();
            Console.Write("Enter company manager: ");
            string compManager = Console.ReadLine();
            Console.Write("Enter manager first name: ");
            string managerFName = Console.ReadLine();
            Console.Write("Enter manager last name: ");
            string managerLName = Console.ReadLine();
            Console.Write("Enter manager phone: ");
            string managerPhone = Console.ReadLine();

            Console.WriteLine("Firm: Name - {0}, Address - {1}, Number - {2}, Fax - {3}, Website - {4}, Manager - {5}", compName, compAddr, compPhone, compFax, compSite, compManager);
            Console.WriteLine("Manager: Name - {0} {1}, Phone - {2}", managerFName, managerLName, managerPhone);

// 4. Write a program that prints three numbers in three virtual columns on the console. Each column should have a width of 10 characters and the numbers should be left aligned. The first number should be an integer in hexadecimal; the second should be fractional positive; and the third – a negative fraction. The last two numbers have to be rounded to the second decimal place.
Console.WriteLine("-----------------------------Chapter 4,  Solution 4 ----------------------");
    // int hexNum = 2015;
    // Console.WriteLine("|0x{0,-8:X|", hexNum);
    // double fractNum = -1.856;
    // Console.WriteLine("|0,-10:f2}|", fractNum);

// 5. Write a program that reads from the console two integer numbers (int) and prints how many numbers between them exist, such that the remainder of their division by 5 is 0. Example: in the range (14, 25) there are 3 such numbers: 15, 20 and 25.
Console.WriteLine("-----------------------------Chapter 4,  Solution 5----------------------");
    int counter = 0;
    
    Console.Write("Enter first number: ");
    int a = Int32.Parse(Console.ReadLine());
    Console.Write("Enter second number: ");
    int b = Int32.Parse(Console.ReadLine());
    
    for (int i = a; i <= b; i++)
    {
        if (i % 5 == 0) counter++;
    }
    
    Console.WriteLine("{0} numbers found.", counter);


// 6. Write a program that reads two numbers from the console and prints the greater of them. Solve the problem without using conditional statements.
Console.WriteLine("-----------------------------Chapter 4,  Solution 6----------------------");
    Console.Write("Enter first number: ");
    int firstNum = Int32.Parse(Console.ReadLine());
    Console.Write("Enter second number: ");
    int secondNum = Int32.Parse(Console.ReadLine());
    
    Console.WriteLine("{0} >= {1}", Math.Max(firstNum, secondNum), Math.Min(firstNum, secondNum));


// // 7. Write a program that reads five integer numbers and prints their sum. If an invalid number is entered the program should prompt the user to enter another number.
  Console.WriteLine("-----------------------------Chapter 4,  Solution 7----------------------");
 int total7 = 0;
   
    Console.Write("Enter five numbers : ");
    int numOfAppearance = 5;
    
    for (int i = 0; i < numOfAppearance; i++)
    {
        Console.Write("Enter {0} number: ", i + 1);
        total7 += Int32.Parse(Console.ReadLine());
        

    
    }

    Console.WriteLine("Sum of all numbers is {0}.", total7);





// 8. Write a program that reads five numbers from the console and prints the greatest of them.
Console.WriteLine("-----------------------------Chapter 4,  Solution 8----------------------");

        Console.WriteLine("Enter your First Input:");

int FirstInput = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your Second Input:");

int SecondInput = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your Third Input:");

int ThirdInput = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your Fourth Input:");

int FourthInput = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your Fifth Input:");

int FifthInput = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(".... Recorded");
Console.WriteLine("Your First Input is " + FirstInput + ", Your second input is " + SecondInput + ", Your Third input is " + ThirdInput + ", Your Fourth input is " + FourthInput + ", Your fifth input is " + FifthInput);

        int[] arrayNumbers = { FirstInput, SecondInput, ThirdInput, FourthInput, FifthInput};
        decimal arrayBiggest = arrayNumbers.Max();
 
        Console.WriteLine("The Largest of the input is " + arrayBiggest);




// 9. Write a program that reads an integer number n from the console. After that reads n numbers from the console and prints their sum.
Console.WriteLine("-----------------------------Chapter 4,  Solution 9----------------------");
 
        Console.WriteLine("Enter your First Input:");

int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your Second Input:");

int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your Third Input:");

int ThirdNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your First Input is " + firstNumber + ", Your second input is " + secondNumber + ", Your Third input is " + ThirdNumber );
int sum = firstNumber + secondNumber + ThirdNumber;
Console.WriteLine("The total sum of your input is " + sum);





// 10. Write a program that reads an integer number n from the console and prints all numbers in the range [1…n], each on a separate line.
Console.WriteLine("-----------------------------Chapter 4,  Solution 10----------------------");
   int total = 0;
    
    Console.Write("Enter numbers count: ");
    int length = Int32.Parse(Console.ReadLine());
    
    for (int i = 0; i < length; i++)
    {
        Console.Write("Enter {0} number: ", i + 1);
        total += Int32.Parse(Console.ReadLine());
    }
    
    Console.WriteLine("Sum of all numbers is {0}.", total);



// 11. Write a program that prints on the console the first 100 numbers in the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …
Console.WriteLine("-----------------------------Chapter 4,  Solution 11----------------------");
            Console.WriteLine("The Fibonacci sequence of 100 are : ");
         ulong fab = 100;
 
      
 
        ulong fab1 = 0;
        ulong fab2 = 1;
        Console.Write("{0} {1} ", fab1, fab2);
 
        for (ulong i2 = 2; i2 < fab; i2++)
        {
            ulong fab3 = fab1 + fab2;
            Console.Write("{0} ", fab3);
            fab1 = fab2;
            fab2 = fab3;
        }
        Console.WriteLine();






// 12. Write a program that calculates the sum (with precision of 0.001) of the following sequence: 1 + 1/2 - 1/3 + 1/4 - 1/5 + …
Console.WriteLine("-----------------------------Chapter 4,  Solution 12 ----------------------");
    int num1 = 0;
    int num2 = 1;
    int sum2 = 1;
    int count = 0;
    
    Console.WriteLine(num1);
    
    while(count < 100)
    {
        sum2 = num1 + num2;
        num1 = num2;
        num2 = sum2;
        Console.WriteLine(num2);
        count++;
    }