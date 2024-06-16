// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;
bool continuar = true;

while (continuar)
{
Calculadora calc = new();
Console.WriteLine("Digite um método de operação:+,-,*,/");
string? valor = Console.ReadLine();
Console.WriteLine("Digite o primeiro número");
int n1 = Convert.ToInt32( Console.ReadLine());
Console.WriteLine("Digite o segundo número");
int n2 = Convert.ToInt32(Console.ReadLine());

if (valor == "+") 
{
    int resultado = calc.Somar(n1,n2);
    Console.WriteLine($"O resultado da soma é: {resultado}");
}
else if ( valor == "-")
{
    int resultado = calc.Subtrair(n1, n2);
    Console.WriteLine($"O resultado da subtração é {resultado}");
}
else if (valor == "*")
{
    int resultado = calc.Multiplicar(n1, n2);
    Console.WriteLine($"O resultado da Multiplicação é {resultado}");
}
else if (valor == "/")
{
    if (n2 != 0)
    {
        int resultado = calc.Dividir(n1, n2);
        Console.WriteLine($"O resultado da divisão é: {resultado}");
    }
    else 
    {
        Console.WriteLine("Erro: Divisão por zero não é permitida.");
    }
    
}
else
{
    
        Console.WriteLine("Operação inválida");
    
}

    Console.WriteLine("Deseja realizar mais operações? [S/N]");
    string? resposta = Console.ReadLine();
    if (resposta?.ToUpper() != "S")
    {
        continuar = false;
    }
}







public class Calculadora
{
    
    public int Somar(int n1, int n2)
    {
        return n1 + n2;
    }
    public int Subtrair(int n1, int n2)
    {
        return n1 - n2;
    }
    public int Dividir(int n1, int n2)
    {
        return n1 / n2;
    }
    public int Multiplicar(int n1, int n2)
    {
        return n1 * n2;
    }

    
}
