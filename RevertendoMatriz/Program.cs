int[,] matrizOriginal = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
int[,] matrizInvertida = new int[matrizOriginal.GetLength(0), matrizOriginal.GetLength(1)];

// copia os valores da original pra invertida, invertendo a ordem dos valores
for (int i = 0; i < matrizOriginal.GetLength(0); i++)
{
    for (int j = 0; j < matrizOriginal.GetLength(1); j++)
    {
        matrizInvertida[matrizOriginal.GetLength(0) - 1 - i, matrizOriginal.GetLength(1) - 1 - j] = matrizOriginal[i, j];
    }
}

// imprime a matriz original
Console.WriteLine("Matriz Original:");
for (int i = 0; i < matrizOriginal.GetLength(0); i++)
{
    for (int j = 0; j < matrizOriginal.GetLength(1); j++)
    {
        Console.Write(matrizOriginal[i, j] + " ");
    }
    
}

// imprime a matriz invertida
Console.WriteLine("Matriz Invertida:");
for (int i = 0; i < matrizInvertida.GetLength(0); i++)
{
    for (int j = 0; j < matrizInvertida.GetLength(1); j++)
    {
        Console.Write(matrizInvertida[i, j] + " ");
    }

}

