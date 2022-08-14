int numero;
int divisores = 1;

Console.Write("Escreva um número : ");
numero = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < numero; i++)
{
    if (numero % i == 0 && numero % numero == 0)
        divisores++;
}
if (divisores == 2)
{
    Console.WriteLine("Esse número é primo");
}
else
{
    Console.WriteLine("Esse número não é primo");
}