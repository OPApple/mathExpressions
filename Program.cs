const double pi = 3.1415926535; 

int sign(double x)
{
    if (x < 0)
    {
        return -1;
    }
    else
    {
        return 1;
    }
}


double pow(double x, int exponent)
{
    double output = 1;
    for (int i = 0; i < exponent; i++)
    {
        output *= x;
    }
    return output;
}

long factorial(long x)
{
    long output = 1;
    for (int i = 1; i <= x; i++)
    {
        output *= i;
    }
    return output;

}



decimal sin(double x)
{
    while (x > 2*pi || x < -2 * pi)
    {
        x -= sign(x)*2*pi;
    }
    decimal output = 0;
    for (int i = 0; i <= 9; i++)
    {
        if (i % 2 == 0)
        {
            output += (decimal)pow(x, (2 * i) + 1) / factorial(2 * i + 1);
            //Console.WriteLine(output + " right now");
        }

        else
        {
            output -= (decimal)pow(x, (2 * i) + 1) / factorial(2 * i + 1);
            //Console.WriteLine(output + " right now");
        }

    }
    return output;
}

decimal cos(double x)
{
    while (x > 2 * pi || x < -2 * pi)
    {
        x -= sign(x) * 2 * pi;
    }
    decimal output = 0;
    for (int i = 0; i <= 9; i++)
    {
        if (i % 2 == 0)
        {
            output += (decimal)pow(x, (2 * i)) / factorial(2 * i);
            //Console.WriteLine(output + " right now");
        }

        else
        {
            output -= (decimal)pow(x, (2 * i)) / factorial(2 * i);
            //Console.WriteLine(output + " right now");
        }

    }
    return output;
}

decimal tan(double x)
{
    return sin(x) / cos(x);
}

Console.WriteLine(tan(3));