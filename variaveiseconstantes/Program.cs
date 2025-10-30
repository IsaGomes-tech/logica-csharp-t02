//Variáveis
char letra = 'A';
string nome = "João";
float temperatura = 36.5f;
double salario = 12245.67;
bool estaChovendo = true;

//Alterando as variáveis
letra = 'B';
nome = "Maria";
temperatura = 37.5f;
salario = 15000.67;
estaChovendo = false;

const char simbolo = '$';
const string saudacao = "Bem vindo ao C#";
const float pi = 3.14159f;
const double altura = 1.75;
const bool ehVerdade = false;
const int numero = 14;

//Exibindo valores originais
Console.WriteLine("Valores originais");
Console.WriteLine($"Letra: {letra}");
Console.WriteLine($"Nome: {nome}");
Console.WriteLine($"Temperatura: {temperatura}");
Console.WriteLine($"Salário: {salario}");

// Exibindo os valores por concatenação
Console.WriteLine("\nConstantes");
Console.WriteLine("Símbolo:" + simbolo);
Console.WriteLine("Saudação:" + saudacao);
Console.WriteLine("PI:" + pi);
Console.WriteLine("Altura:" + altura);
Console.WriteLine("É verdade?:" + ehVerdade);
Console.WriteLine("Número:" + numero);