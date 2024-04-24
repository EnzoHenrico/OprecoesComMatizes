int tamanhoLinha = 3, tamanhoColuna = 3;
float[,] matriz1 = new float[tamanhoLinha, tamanhoColuna];
float[,] matriz2 = new float[tamanhoLinha, tamanhoColuna];
float[,] matrizResultante = new float[tamanhoLinha, tamanhoColuna];

void imprimirMatriz(float[,] matriz, string nomeDaOperacao = "")
{
    Console.WriteLine($"{nomeDaOperacao}\n");
    for (int linha = 0; linha < tamanhoLinha; linha++)
    {
        for (int coluna = 0; coluna < tamanhoColuna; coluna++)
        {
            Console.Write($"{matriz[linha, coluna]:00} ");
        }
    }
}

for (int linha = 0; linha < tamanhoLinha; linha++)
{
    for (int coluna = 0; coluna < tamanhoColuna; coluna++)
    {
        matriz1[linha, coluna] = new Random().Next(0, 11);
        matriz2[linha, coluna] = new Random().Next(0, 11);
    }
}

// Matrizes originais
imprimirMatriz(matriz1, "Valores originais:");
imprimirMatriz(matriz2);

// Soma
for (int linha = 0; linha < tamanhoLinha; linha++)
{
    for (int coluna = 0; coluna < tamanhoColuna; coluna++)
    {
        matrizResultante[linha, coluna] = matriz1[linha, coluna] + matriz2[linha, coluna];
    }
    Console.WriteLine();
}
imprimirMatriz(matrizResultante, "Soma das matrizes: ");

// Subtração
for (int linha = 0; linha < tamanhoLinha; linha++)
{
    {
        for (int coluna = 0; coluna < tamanhoColuna; coluna++)
            matrizResultante[linha, coluna] = matriz1[linha, coluna] - matriz2[linha, coluna];
    }
    Console.WriteLine();
}
imprimirMatriz(matrizResultante, "Subtração das matrizes: ");

// Multiplicação
for (int linha = 0; linha < tamanhoLinha; linha++)
{
    for (int coluna = 0; coluna < tamanhoColuna; coluna++)
    {
        matrizResultante[linha, coluna] = matriz1[linha, coluna] * matriz2[linha, coluna];
    }
    Console.WriteLine();
}
imprimirMatriz(matrizResultante, "Multiplicação das matrizes: ");

// Divisão
for (int linha = 0; linha < tamanhoLinha; linha++)
{
    for (int coluna = 0; coluna < tamanhoColuna; coluna++)
    {
        if (matriz2[linha, coluna] != 0)
        {
            matrizResultante[linha, coluna] = matriz1[linha, coluna] / matriz2[linha, coluna];
        }
        else
        {
            matrizResultante[linha, coluna] = float.NaN;
        }
    }
    Console.WriteLine();
}
imprimirMatriz(matrizResultante, "Divisão das matrizes: ");

// Interação final
Console.WriteLine();
Console.ReadLine();