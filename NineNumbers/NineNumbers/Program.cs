using System;

Console.WriteLine("Witaj w programie szukajacym statystyk dla 9 liczb");
Console.WriteLine();

List<float> numbers = new List<float>();

for (int i = 1; i <= 9; i++)
{
    Console.WriteLine($"Podaj liczbę {i}:");
    string input = Console.ReadLine();
    if (float.TryParse(input, out float number))
    {
        numbers.Add(number);
    }
    else
    {
        Console.WriteLine("To nie jest poprawna liczba. Podaj liczbę jeszcze raz.");
        i--;
    }
}

Console.WriteLine();

float suma = numbers.Sum();
float max = numbers.Max();
float min = numbers.Min();
float average = numbers.Average();
Console.WriteLine($"Suma podanych liczb: {suma}");
Console.WriteLine($"Największa liczba: {max}");
Console.WriteLine($"Najmniejsza liczba: {min}");
Console.WriteLine($"Średnia: {average:N2}");