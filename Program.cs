using System;
using System.IO;

namespace PJT_11_Outubro
{
    class Program
    {
        static void Main(string[] args)
        {   
            int sair = 1;
            bool ConverteuSair = false;
            string[] perguntas = File.ReadAllLines(@"perguntas.txt");
            string[] respostas = new string[perguntas.Length];

            StreamWriter respostasSaida = new StreamWriter("respostas.csv", true);

            for (int i=0; i < perguntas.Length; i++)

            {

            respostasSaida.Write(perguntas[i]);
            respostasSaida.Write("; ");

            }

            respostasSaida.WriteLine();

            do{

            for (int i=0; i < perguntas.Length; i++)
            {
                Console.WriteLine(perguntas[i]);
                respostas[i] = Console.ReadLine();
                respostasSaida.Write(respostas[i]);
                respostasSaida.Write("; ");

            }

            respostasSaida.WriteLine();
            Console.WriteLine("\nDigite 1 para inserir novo cadastro ou aperte qualquer tecla+Enter para finalizar.");
            ConverteuSair = int.TryParse(Console.ReadLine(), out sair);
            Console.WriteLine();


            }while (sair == 1);

            Console.WriteLine("Cadastro Finalizado!");

            respostasSaida.Close();
        }
    }
}
