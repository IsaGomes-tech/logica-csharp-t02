// Condicional if 
string nome = "Ana";
if (nome == "Ana") 
{
    Console.WriteLine("Olá, Ana!");
}

string texto = "";

if (string.IsNullOrEmpty(texto))
{
    Console.WriteLine("A string está vazia");
}

// Condicional if/else

int idade = 16;

if (idade >= 18)
{
    Console.WriteLine("Você é maior de idade");
}
else
{
    Console.WriteLine("Você é menor de idade");
}

int numero = 7;

if (numero % 2 == 0)
{
    Console.WriteLine("O número é par");
}
else
{
    Console.WriteLine("O número é ímpar");
}

// Condicional elseif

double nota = 6.5;

if (nota >= 9.0)
{
    Console.WriteLine("Você obteve uma excelente nota! Aprovado com distinção.");
}
else if (nota >= 7.0)
{
    Console.WriteLine("Você foi aprovado");
}
else if (nota >= 5.0)
{
    Console.WriteLine("Você está em recuperação");
}
else if (nota >= 3.0)
{
    Console.WriteLine("Você está em risco de reprovação");
}
else
{
    Console.WriteLine("Você está reprovado");
}

// Condicional switch

double pontuacao = 8.5;
int faixaNota = (int)Math.Floor(pontuacao);

switch(faixaNota)
{
    case 10:
       Console.WriteLine("Você obteve uma excelente nota! Aprovado com distinção.");
        break;
    case 9:
    case 8:
       Console.WriteLine("Você foi aprovado");
        break;
    case 7:
    case 6:
       Console.WriteLine("Você está em recuperação");
        break;
    case 5:
    case 4:
    case 3:
        Console.WriteLine("Você está em risco de reprovação");
        break;
    default:
        Console.WriteLine("Você está reprovado");
        break;
}


