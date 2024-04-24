int tamanhoLinha = 3, tamanhoColuna = 3;
int[,] matriz1 = new int[tamanhoLinha, tamanhoColuna];
int[,] matriz2 = new int[tamanhoLinha, tamanhoColuna];
float[,] matrizResultante = new float[tamanhoLinha, tamanhoColuna];

for (int linha = 0; linha < tamanhoLinha; linha++)
{
    for (int coluna = 0; coluna < tamanhoColuna; coluna++)
    {
        matriz1[linha, coluna] = new Random().Next(1, 11);
        matriz2[linha, coluna] = new Random().Next(1, 11);
    }
}

Console.WriteLine("\nSoma das matrizes: \n");
for (int linha = 0; linha < tamanhoLinha; linha++)
{
    for (int coluna = 0; coluna < tamanhoColuna; coluna++)
    {
        matrizResultante[linha, coluna] = matriz1[linha, coluna] + matriz2[linha, coluna];
        Console.Write($"{matriz1[linha, coluna]:00} ");
    }

    if (linha == tamanhoLinha / 2)
    {
        Console.Write("  +  ");
    }
    else
    {
        Console.Write("     ");
    }

    for (int coluna = 0; coluna < tamanhoColuna; coluna++)
    {
        Console.Write($"{matriz2[linha, coluna]:00} ");
    }

    if (linha == tamanhoLinha / 2)
    {
        Console.Write("  =  ");
    }
    else
    {
        Console.Write("     ");
    }

    for (int coluna = 0; coluna < tamanhoColuna; coluna++)
    {
        Console.Write($"{matrizResultante[linha, coluna]:00} ");
    }

    Console.WriteLine();
}

Console.WriteLine("\nSubtração das matrizes: \n");
for (int linha = 0; linha < tamanhoLinha; linha++)
{
    for (int coluna = 0; coluna < tamanhoColuna; coluna++)
    {
        matrizResultante[linha, coluna] = matriz1[linha, coluna] - matriz2[linha, coluna];
        Console.Write($"{matriz1[linha, coluna]:00} ");
    }

    if (linha == tamanhoLinha / 2)
    {
        Console.Write("  -  ");
    }
    else
    {
        Console.Write("     ");
    }

    for (int coluna = 0; coluna < tamanhoColuna; coluna++)
    {
        Console.Write($"{matriz2[linha, coluna]:00} ");
    }

    if (linha == tamanhoLinha / 2)
    {
        Console.Write("  =  ");
    }
    else
    {
        Console.Write("     ");
    }

    for (int coluna = 0; coluna < tamanhoColuna; coluna++)
    {
        Console.Write($"{matrizResultante[linha, coluna]:00} ");
    }

    Console.WriteLine();
}

Console.WriteLine("\nMultiplicação das matrizes: \n");
for (int linha = 0; linha < tamanhoLinha; linha++)
{
    for (int coluna = 0; coluna < tamanhoColuna; coluna++)
    {
        matrizResultante[linha, coluna] = matriz1[linha, coluna] * matriz2[linha, coluna];
        Console.Write($"{matriz1[linha, coluna]:00} ");
    }

    if (linha == tamanhoLinha / 2)
    {
        Console.Write("  *  ");
    }
    else
    {
        Console.Write("     ");
    }

    for (int coluna = 0; coluna < tamanhoColuna; coluna++)
    {
        Console.Write($"{matriz2[linha, coluna]:00} ");
    }

    if (linha == tamanhoLinha / 2)
    {
        Console.Write("  =  ");
    }
    else
    {
        Console.Write("     ");
    }

    for (int coluna = 0; coluna < tamanhoColuna; coluna++)
    {
        Console.Write($"{matrizResultante[linha, coluna]:00} ");
    }

    Console.WriteLine();
}

Console.WriteLine("\nDivisão das matrizes: \n");
for (int linha = 0; linha < tamanhoLinha; linha++)
{
    for (int coluna = 0; coluna < tamanhoColuna; coluna++)
    {
        matrizResultante[linha, coluna] = matriz1[linha, coluna] / matriz2[linha, coluna];
        Console.Write($"{matriz1[linha, coluna]:00} ");
    }

    if (linha == tamanhoLinha / 2)
    {
        Console.Write("  /  ");
    }
    else
    {
        Console.Write("     ");
    }

    for (int coluna = 0; coluna < tamanhoColuna; coluna++)
    {
        Console.Write($"{matriz2[linha, coluna]:00} ");
    }

    if (linha == tamanhoLinha / 2)
    {
        Console.Write("  =  ");
    }
    else
    {
        Console.Write("     ");
    }

    for (int coluna = 0; coluna < tamanhoColuna; coluna++)
    {
        Console.Write($"{matrizResultante[linha, coluna]:00.0} ");
    }

    Console.WriteLine();
}