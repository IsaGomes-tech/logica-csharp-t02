//Declarando constantes

const int valor1 = 10;
const int valor2 = 5;


int soma = valor1 + valor2; //soma
int subtracao = valor1 - valor2; //subtração
int multiplicacao = valor1 * valor2; //multiplicação
int divisao = valor1 / valor2; //divisão
int restoDivisao = valor1 % valor2; //resto da divisão
double potencia = Math.Pow(valor1, valor2);//potenciação

Console.WriteLine($"Soma: {valor1} + {valor2} = {soma}");
Console.WriteLine($"Subtração: {valor1} - {valor2} = {subtracao}");
Console.WriteLine($"Multiplicação: {valor1} * {valor2} = {multiplicacao}");
Console.WriteLine($"Divisão: {valor1} / {valor2} = {divisao}");
Console.WriteLine($"Resto da divisão de: {valor1} / {valor2} = {restoDivisao}");
Console.WriteLine($"Potenciação: {valor1} elevado a {valor2} = {potencia}");

//Cálculo Exemplo:1 (Sem parênteses)
int resultado1 = 3 + 5 * 2; // Multiplicação tem prioridade
int resultado2 = (3 + 5) * 2;

Console.WriteLine($"Resultado 1 (sem paênteses): 3 + 5 * 2 = {resultado1}");
Console.WriteLine($"Resultado 2 (com paênteses): 3 + 5 * 2 = {resultado2}");

int resultado3 = 8 / 4 + 3;
double resultado4 = 8.0 / (4 + 3);

Console.WriteLine($"Resultado 1: 8 / 4 + 3 = {resultado3}");
Console.WriteLine($"Resultado 2: 8 / (4 + 3) = {resultado4}");