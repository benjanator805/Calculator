using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;

{


    
    
    
    Console.WriteLine("Enter Number Here");
    
    int num1 = int.Parse(Console.ReadLine());
    int num2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter Operator Here");
    string operation = Console.ReadLine();


    if (operation == "+")
    {
        int sum = num1 + num2;
        Console.WriteLine(sum);

    }



    else if (operation == "-")
    {
        int difference = num1 - num2;
        Console.WriteLine(difference);
    }

    else if (operation == "*")
    {
        int product = num1 * num2;
        Console.WriteLine(product);
    }

    else if (operation == "/")
    {
        if (num2 == 0)
        {
            Console.WriteLine("Nice try but you know something going into zero is undefined");
        }
        
        int quotient = num1 / num2;
        Console.WriteLine(quotient);
    }

    else if (operation == "%")
    {
        int percent = num1 % num2;
        Console.WriteLine(percent);
    }

    






    

    

}
