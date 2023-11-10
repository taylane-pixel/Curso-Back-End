using System;

public class Media
{
    public static void Main(string[] args)
    {
        // Declarando variaves
        
        double notaPortugues , notaHistoria, notaMatematica;
        double media = 0;
    
        Console.WriteLine("Digite a nota de das seguintes materias para calcular a media");

      // Aluno entra com a nota das materias
      
        Console.WriteLine("Digite a nota de Portugues:");
        notaPortugues = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a nota de Historia");
        notaHistoria = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a nota de Matematica");
        notaMatematica = Convert.ToDouble(Console.ReadLine());
        

        // Calculando a media
         media = (notaPortugues + notaHistoria + notaMatematica) / 3;
         Console.WriteLine("Media" + media);
         if(media >= 7)
         {
             Console.Write("APROVADO");
         }else {
             Console.WriteLine("REPROVADO");
         }


            
    
       }
  }
