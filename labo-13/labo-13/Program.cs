Random random = new Random();

int[,] numbers = new int[3, 5];
for (int col = 0; col < numbers.GetLength(1); col++)
{
    numbers[0, col] = random.Next(1, 10);
}

Console.WriteLine($"Geef {numbers.GetLength(1)} getallen voor het opvullen van de tweede rij!");
for (int col = 0; col < numbers.GetLength(1); col++)
{
    Console.Write($"Geef getal {col + 1}: ");
    numbers[1, col] = int.Parse(Console.ReadLine());
}
Console.WriteLine();

for (int col = 0; col < numbers.GetLength(1); col++)
{
    numbers[2, col] = numbers[0, col] + numbers[1, col];
}


for (int row = 0; row < numbers.GetLength(0); row++)
{
    Console.Write($"Rij {row} ==>\t");
    for (int col = 0; col < numbers.GetLength(1); col++)
    {
        Console.Write($"{numbers[row, col]}\t");
    }
    Console.WriteLine();
}

Console.Write("Druk op een toets ");
Console.ReadKey();