// loop for

for (int i = 1; i <=10; i++)
{
    Console.WriteLine(i);
}

// loop de soma
int soma = 0;
for (int i = 1; i <= 100; i++)
{
    soma += i;
}

Console.WriteLine($"O valor da soma dos números de 1 a 100 é: {soma}");

// loop infinito
/*
for(; ; )
{
    Console.WriteLine("Loop infinito");
}
*/

//loop while

int contador = 1;

while (contador <= 5)
{
    Console.WriteLine(contador);
    contador++;
}

// loop do while (faça enquanto)

int novoContador = 2;
do
{
    Console.WriteLine(novoContador);
    novoContador++;
} while (novoContador <= 5);

// loop while
/*
while(true)
{
    Console.WriteLine("Esse loop é infinito");
}
*/

// loop foreach

List<string> nomes = new List<string> { "Ana", "Carlos", "João", "Maria" };

// Usando foreach para percorrer a lista

foreach (string nome in nomes)
{
    Console.WriteLine(nome); // Imprime cada nome na tela
}

// Usando foreach para percorrer lista de números

int[] numeros = {1, 2, 3, 4, 5};

foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}