using System;

public class Media
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Calculando a media do aluno A.");
        
        double nota_Portugues, nota_Historia, nota_Matematica;
        double media;
        // Exibir no Console
              Console.Write("Entre com a nota de Portugues: ");
        nota_Portugues = Convert.ToDouble(Console.ReadLine());
        
          Console.Write("Entre com a nota de Historia: ");
        nota_Historia = Convert.ToDouble(Console.ReadLine());
        
         Console.Write("Entre com a nota de Matematica: ");
        nota_Matematica = Convert.ToDouble(Console.ReadLine());
        
        // Calculando a media:
        media = (nota_Portugues + nota_Historia + nota_Matematica) / 2;
        // Resultado
          Console.Write("A media do Aluno A e: " + media);
          Console.ReadKey();
        
        if (media >= 7)
        {
            Console.WriteLine("O Aluno A esta APROVADO!");
        }else
        {
            Console.WriteLine("O Aluno A esta REPROVADO!");
        }
        Console.ReadKey();

    }
}