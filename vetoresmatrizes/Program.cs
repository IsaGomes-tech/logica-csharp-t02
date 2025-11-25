// Declarando dois vetores
int[] numeros = { 7, 2, 3, 34, 5 }; // vetor de inteiros
string[] nomes = { "Ana", "João", "Maria", "Carlos" }; // vetor de strings

// Exibindo os elementos do vetor de números com loop for
Console.WriteLine("Vetor de números usando (for):");
for(int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}

// Exibindo os elementos de vetor de nomes com loop foreach
Console.WriteLine("\nVetor de Nomes usando (foreach):");
foreach (var nome in nomes)
{
    Console.WriteLine(nome);

}

// Ordenação do vetor de números
Array.Sort(numeros);
Console.WriteLine("\nVetor de Números Ordenados:");
foreach(var n in numeros)
{
    Console.WriteLine(n);
}

int valorProcurado = 5;
int posicaoSequencial = PesquisaSequencial(numeros, valorProcurado);
if (posicaoSequencial != -1)
{
    Console.WriteLine($"\nPesquisa Sequencial: valor {valorProcurado} encontrado na posição {posicaoSequencial}.");
}
else
{
    Console.WriteLine($"\nPesquisa Sequencial: valor {valorProcurado} não encontado");
}

static int PesquisaSequencial(int[] vetor, int valor)
{
    for (int i = 0; i < vetor.Length; i++)
    {
        if (vetor[i] == valor)
            return i;
    }
    return -1;
}

// Ordenar antes da pesquisa binária
Array.Sort(numeros);

//Pesquisa Binária
int posicarBinaria = Array.BinarySearch(numeros, valorProcurado);
if(posicarBinaria >= 0)
{
    Console.WriteLine($"Pesquisa Bínária: Valor {valorProcurado} encontrado na posicao {posicarBinaria}");
}
else
{
    Console.WriteLine($"Pesquisa Bínária: Valor {valorProcurado} não encontrado");
}

//Declaração e manipulação de uma matriz 3x2
int[,] matriz = new int[3, 2]
{
       { 1, 2 },
       { 3, 4 },
       { 5, 6 }
};

Console.WriteLine("\nExibindo a Matriz 3x2:");
for (int i = 0; i < 3; i++)
{
    for(int j = 0; j < 2; j++)
    {
        Console.Write(matriz[i, j] + "\t");
    }
    Console.WriteLine();
}

//Manupulação: somando 10 a cada elemneto
Console.WriteLine("\nMatriz após adicionar 10 a cada elemento:");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 2; j++)
    {
        matriz[i, j] += 10;
        Console.Write(matriz[i, j] + "\t");
    }
    Console.WriteLine();
}