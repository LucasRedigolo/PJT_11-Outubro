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
            string[] Perguntas = File.ReadAllLines(@"perguntas.txt");
            string[] Respostas = new string[Perguntas.Length];

            StreamWriter RespostasSaida = new StreamWriter("respostas.csv", true);
            FileInfo Arquivo = new FileInfo("respostas.csv");

            if (Arquivo.Length == 0)
            {
                for (int i=0; i < Perguntas.Length; i++)
                {
                RespostasSaida.Write(Perguntas[i]);
                RespostasSaida.Write("; ");
                }

                RespostasSaida.WriteLine();
            }
            

            do{

            for (int i=0; i < Perguntas.Length; i++)
            {
                Console.WriteLine(Perguntas[i]);
                Respostas[i] = Console.ReadLine();
                RespostasSaida.Write(Respostas[i]);
                RespostasSaida.Write("; ");
            }

            RespostasSaida.WriteLine();
            Console.WriteLine("\nDigite 1 para inserir novo cadastro ou aperte qualquer tecla+Enter para finalizar.");
            ConverteuSair = int.TryParse(Console.ReadLine(), out sair);
            Console.WriteLine();

            }while (sair == 1);

            Console.WriteLine("Cadastro Finalizado!");
            RespostasSaida.Close();
        }
    }
}
