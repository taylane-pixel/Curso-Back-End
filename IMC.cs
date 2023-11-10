public class IMC
{
    static void Main(string[] args)
    {
        // Solicitar ao usuário peso e altura

        Console.WriteLine("Digite seu peso em Kg: ");
        double peso = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite sua altura em metros:");
        double altura = Convert.ToDouble(Console.ReadLine());

        // Calcularo IMC

        double imc = peso / altura + (altura * altura);

        // Mostrar resultado

        Console.WriteLine("Seu IMC é: " + imc);
        Console.ReadKey();

    }
}
