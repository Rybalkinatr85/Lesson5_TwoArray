// Вывод двумерного массива

string[,] table = new string[2, 3];
table[1, 2] = "слово";
for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 3; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}
