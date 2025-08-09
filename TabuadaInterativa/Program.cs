using System;

namespace Program
{
    class TabuadaInterativa
    {
       public void Main(string[] args)
        {
            // Limpa o console para uma melhor visualização
            Console.Clear();

            // Invoca o método
            GerarTabuada();
        }

        static void GerarTabuada()
        {
            // Solicita ao usuário o número para a tabuada
            Console.WriteLine($"Vamos gerar uma tabuada para você!");
            Console.WriteLine($"Digite um número: ");

            // Lê o número digitado pelo usuário
            int numero = int.Parse(Console.ReadLine());

            // Exibe a tabuada do número informado
            Console.WriteLine($"Tabuada do número {numero}");

            // Gere a tabuada do número informado pelo usuário e o resultado
            for (int i = 0; i <= 10; i++)
            {
                int resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");
            }

            return;
        }
    }
}
