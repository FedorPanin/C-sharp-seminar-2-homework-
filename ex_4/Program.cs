for (int i = 1; i < 101; i++)
{
    string n = Convert.ToString(i), f = "Fizz", b = "Buzz", fb = "FizzBuzz";
    if ((i % 3 == 0) && (i % 5 == 0)) 
        n = fb;
    else if (i % 3 == 0)
        n = f; 
    else if (i % 5 == 0)
        n = b;
    Console.Write($"{n} ");
}

// FizzBuzz 