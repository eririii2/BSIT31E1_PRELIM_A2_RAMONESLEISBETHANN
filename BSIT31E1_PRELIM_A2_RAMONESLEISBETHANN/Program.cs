while (true)
{
    Console.WriteLine("Enter number ( exit to quit )");
    string input = Console.ReadLine();

    if (input.ToLower() == "exit")
    {
        break;
    }

    Console.WriteLine("Enter number ( exit to quit )");
    string input2 = Console.ReadLine();

    if (input2.ToLower() == "exit")
    {
        break;
    }

    Console.WriteLine("Enter Operator: +, -, *, /");
    string selection = Console.ReadLine();
    int a = int.Parse(input);
    int b = int.Parse(input2);

    if (selection == "+")
    {
        int total = a + b;
        Console.WriteLine(total);
    }

    else if (selection == "-")
    {
        int total = a - b;
        Console.WriteLine(total);
    }

    else if (selection == "*")
    {
        int total = a * b;
        Console.WriteLine(total);
    }
    else if (selection == "/")
    {
        int total = a / b;
        Console.WriteLine(total);
    }

    else
    {
        Console.WriteLine("Invalid");
    }
}