using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Porcentagem

{
	static void Main(string[] args)
	{
        // variáveis:
        double num, P;

        Console.WriteLine("Digite um valor e será calculada a porcentagem de 10% desse valor: ");
        num = double.Parse(Console.ReadLine());

        // calculo: 
        P = (10.0 / 100) * num;

        // imprimir no console:
        Console.WriteLine("10% de " + num + " e: " + P + "%");
        Console.ReadKey();
    }
}
