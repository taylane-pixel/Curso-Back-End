using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1 - Exiba um programa que some, multiplique, subtraia e exiba o resto da divisão de dois números


public class Calculos
{
    public static void Main(string[] args)
    {
        /* criando as variáves*/
        int num1, num2;
        string valor;

        Console.WriteLine("Bem-vindo a calculadora. Vamos começar?");
        Console.WriteLine("Digite um número:");
        valor = Console.ReadLine();
        num1 = int.Parse(valor);

        Console.WriteLine("Digite outro número:");
        valor = Console.ReadLine();
        num2 = int.Parse(valor);

        // Calculos

        int soma = num1 + num2;
        Console.WriteLine("Soma: " + soma);

        int divisao = num1 / num2;
        Console.WriteLine("Divisão: " + divisao);

        int resto = num1 % num2;
        Console.WriteLine("Resto: " + resto);

        int multiplicacao = num1 * num2;
        Console.WriteLine("Multiplicação: " + multiplicacao);

        int subtracao = num1 - num2;
        Console.WriteLine("Subtração: " + subtracao);

        Console.WriteLine("Fim do programa. Tchau!");
        Console.ReadKey();
    }
}