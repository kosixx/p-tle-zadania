
//zad 1
int liczba_dzielnikow = 0;

for (int i = 1; i <= 100; i++)
{
    for (int j = 1; j <= i; j++)
    {
        if (i % j == 0)
        {
            liczba_dzielnikow++;
        }

    }
    if (liczba_dzielnikow == 2)
    {
        Console.WriteLine(i);
        liczba_dzielnikow = 0;
    }
    else
    {
        liczba_dzielnikow = 0;
    }

}

//zad 2
int i = 0;
do
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
    i++;
}
while (i <= 1000);

//zad 3 

Console.Write("Podaj liczbę elementów ciągu Fibonacciego : ");
int liczbaElementow = int.Parse(Console.ReadLine());
int a = 0;
int b = 1;
int c;
for (int i = 0; i < liczbaElementow; i++)
{
    if (i <= 1)
    {
        c = i;
    }
    else
    {
        c = a + b;
        a = b;
        b = c;

    }
    Console.WriteLine(c);

}

//zad 4

Console.WriteLine("Enter number");
int number = int.Parse(Console.ReadLine());
int zero = 0;

for (int i = 0; i < number; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write($"{zero + 1}" + " ");
        zero++;
        if (zero == number)
        {
            break;
        }

    }
    if (zero == number)
    {
        break;
    }
    Console.WriteLine();
}

//zad 5

for (int i = 1; i <= 20; i++)
{
    Console.WriteLine(i * i * i);
}

// zad 6 
double suma = 0;

for (double i = 0; i < 20; i++)
{
    suma += 1 / (i + 1);

}
Console.WriteLine(suma);

//zad 7




Console.WriteLine("ENTER lenght of traignle");
int lenght = int.Parse(Console.ReadLine());
if (lenght % 2 == 0)
{
    for (int i = 1; i <= lenght / 2; i++)
    {
        for (int j = i; j < lenght / 2; j++)
        {
            Console.Write(" ");
        }
        for (int j = 1; j <= i; j++)
        {
            Console.Write("*");
        }
        for (int j = 1; j <= i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
    for (int i = 1; i <= lenght / 2; i++)
    {
        for (int j = 1; j < i; j++)
        {
            Console.Write(" ");
        }
        for (int j = i; j <= lenght / 2; j++)
        {
            Console.Write("*");
        }
        for (int j = i; j <= lenght / 2; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}
else
{
    for (int i = 1; i < lenght / 2 + 1; i++)
    {
        for (int j = i; j < lenght / 2 + 1; j++)
        {
            Console.Write(" ");
        }
        for (int j = 1; j <= i; j++)
        {
            Console.Write("*");
        }
        for (int j = 1; j < i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
    for (int i = 1; i <= lenght / 2 + 1; i++)
    {
        for (int j = 1; j < i; j++)
        {
            Console.Write(" ");
        }
        for (int j = i; j <= lenght / 2 + 1; j++)
        {
            Console.Write("*");
        }
        for (int j = i; j < lenght / 2 + 1; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }

}

//zad 8  
Console.WriteLine("Enter the word");
string word = Console.ReadLine();

for (int i = word.Length - 1; i >= 0; i--)
{
    Console.Write(word[i]);
}

//zad 10


Console.WriteLine("Enter first number");
double a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter first number");
double b = int.Parse(Console.ReadLine());

Console.WriteLine($"NWW = {a * b / (NWD(a, b))}");

static double NWD(double a, double b)

{
    while (a != b)
    {
        if (a > b)
        {
            a = a - b;
        }
        else
        {
            b = b - a;
        }
    }
    return a;
}




