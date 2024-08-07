bool runProgram = true;
while (runProgram == true)


{
    // main
    Console.WriteLine("Welcome to the Exponent Power Table.");
    Console.WriteLine("");
    Console.Write("Please enter an integer between 1 and 1290: ");
    int num = int.Parse(Console.ReadLine());
    if(num < 1 || num > 1290)
    {
        Console.WriteLine("Invalid");
    }
    else 
    {
        Console.WriteLine("Numbers\t\tSquared\t\tCubed");
        Console.WriteLine("=======\t\t=======\t\t=====");
        Console.WriteLine("");
        for (int i = 1; i <= num; i++)
        
        Console.WriteLine($" {i,6} \t {i * i,6} \t  {i * i * i,3}");
        
        }

    while (true)
    {
        Console.WriteLine("Would you like to continue? y/n");
        string loopChoice = Console.ReadLine();
        if (loopChoice == "y")
        {
            break;

        }
        else if (loopChoice == "n")
        {
            runProgram = false;
            break;
        }
        else
        {
            Console.WriteLine("invalid");
        }
    }
}