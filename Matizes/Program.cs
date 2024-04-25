int tamanhoLinha = 0, tamanhoColuna = 0, opcaoDoUsuario = 0;

Console.WriteLine("Operação entre duas matrizes: \n");

void solicitarTamanhoDasMatrizes()
{
    do
    {
        Console.Write("Selecione quantidade de linhas das matrizes: ");
        tamanhoLinha = int.Parse(Console.ReadLine());
        Console.Write("Selecione quantidade de colunas das matrizes: ");
        tamanhoColuna = int.Parse(Console.ReadLine());

        if (tamanhoColuna < 1 || tamanhoLinha < 1)
        {
            Console.WriteLine("Os valores devem ser maiores que 0. Tente novamente.\n");
        } 
        else
        {
            Console.Clear();
        }

    } while (tamanhoColuna < 1 || tamanhoLinha < 1);
}

void menu()
{
    // Interação inicial
    solicitarTamanhoDasMatrizes();

    float[,] matriz1 = gerarMatrizAleatoria(tamanhoLinha, tamanhoColuna);
    float[,] matriz2 = gerarMatrizAleatoria(tamanhoLinha, tamanhoColuna);

    // Matrizes iniciais
    imprimirMatriz(matriz1, "Matriz 1:");
    imprimirMatriz(matriz2, "Matriz 2:");

    do
    {
        Console.WriteLine("\nSelecione a opção desejada: \n");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        Console.WriteLine("5 - Gerar novos valores");

        opcaoDoUsuario = int.Parse(Console.ReadLine());
        Console.Clear();
        imprimirMatriz(matriz1, "Matriz 1:");
        imprimirMatriz(matriz2, "Matriz 2:");

        switch (opcaoDoUsuario)
        {
            case 1:
                imprimirMatriz(calcularMatrizes(matriz1, matriz2, "soma"), "Resultado da soma: ");
                break;
            case 2:
                imprimirMatriz(calcularMatrizes(matriz1, matriz2, "subtracao"), "Resultado da subtração: ");
                break;
            case 3:
                imprimirMatriz(calcularMatrizes(matriz1, matriz2, "multiplicacao"), "Resultado da multiplicação: ");
                break;
            case 4:
                imprimirMatriz(calcularMatrizes(matriz1, matriz2, "divisao"), "Resultado da divisão: ");
                break;
            case 5:
                Console.Write("\nManter mesmos tamanhos? (s)Sim / (n)Não : ");
                char input = char.Parse(Console.ReadLine());
                if (input == 'n' || input == 'N')
                {
                    solicitarTamanhoDasMatrizes();
                }

                Console.Clear();
                matriz1 = gerarMatrizAleatoria(tamanhoLinha, tamanhoColuna);
                matriz2 = gerarMatrizAleatoria(tamanhoLinha, tamanhoColuna);
                
                imprimirMatriz(matriz1, "Matriz 1:");
                imprimirMatriz(matriz2, "Matriz 2:");
                Console.WriteLine("\nValores alterados!\n");
                break;
            default:
                Console.WriteLine("Opção inválida.\n");
                break;
        }

        if (opcaoDoUsuario != 5)
        {
            Console.Write("\nVoltar ao menu de opções? (s)Sim / (n)Não : ");
            char input = char.Parse(Console.ReadLine());
            if (input == 's' || input == 'S')
            {
                opcaoDoUsuario = 0;
                Console.Clear();
                imprimirMatriz(matriz1, "Matriz 1:");
                imprimirMatriz(matriz2, "Matriz 2:");
            }
        }
    } while (opcaoDoUsuario > 4 || opcaoDoUsuario < 1);

}

float[,] gerarMatrizAleatoria(int tamanhoLinha, int tamanhoColuna)
{
    float[,] matriz = new float[tamanhoLinha, tamanhoColuna];
    for (int linha = 0; linha < tamanhoLinha; linha++)
    {
        for (int coluna = 0; coluna < tamanhoColuna; coluna++)
        {
            matriz[linha, coluna] = new Random().Next(0, 11);
        }
    }
    return matriz;
}

float[,] calcularMatrizes(float[,] matriz1, float[,] matriz2, string operacao)
{
    float[,] resultante = new float[tamanhoLinha, tamanhoColuna];
    for (int linha = 0; linha < tamanhoLinha; linha++)
    {
        for (int coluna = 0; coluna < tamanhoColuna; coluna++)
        {
            switch (operacao)
            {
                case "soma":
                    resultante[linha, coluna] = matriz1[linha, coluna] + matriz2[linha, coluna];
                    break;
                case "subtracao":
                    resultante[linha, coluna] = matriz1[linha, coluna] - matriz2[linha, coluna];
                    break;
                case "multiplicacao":
                    resultante[linha, coluna] = matriz1[linha, coluna] * matriz2[linha, coluna];
                    break;
                case "divisao":
                    if (matriz2[linha, coluna] != 0)
                    {
                        resultante[linha, coluna] = matriz1[linha, coluna] / matriz2[linha, coluna];
                    }
                    else
                    {
                        resultante[linha, coluna] = float.NaN;
                    }
                    break;
            }
        }
    }
    return resultante;
}

void imprimirMatriz(float[,] matriz, string nomeDaOperacao = "")
{
    Console.WriteLine($"\n{nomeDaOperacao}");
    for (int linha = 0; linha < tamanhoLinha; linha++)
    {
        for (int coluna = 0; coluna < tamanhoColuna; coluna++)
        {
            Console.Write($"{matriz[linha, coluna]:00} ");
        }
        Console.WriteLine();
    }
}

// Chamar menu para disparar funcionalidades
menu();