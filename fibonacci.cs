using System;

public class Fibonacci
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Sequência de Fibonacci");
        int F1 = 0, F2 = 1, soma = 0;
        int termo;
        Console.WriteLine("Digite um número para representar a quatidade de termo da sequência Fibonacci:");
        termo = int.Parse(Console.ReadLine());
        
        // Calculando a sequencia com a quantidade de termo definida pelo usuário.
        for(int i = 0; i<= termo; i++)
        {
            soma = F1+F2;
            F2=F1;
            F1=soma;
           Console.WriteLine(+ soma);
        }