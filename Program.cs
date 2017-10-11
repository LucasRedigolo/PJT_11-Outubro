using System;
using System.IO;

namespace PJT_11_Outubro
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] perguntas = File.ReadAllLines(@"perguntas.txt");
            string[] respostas = new string[perguntas.Length];

            StreamWriter respostasSaida = new StreamWriter("respostas.csv");

            for (int i=0; i < perguntas.Length; i++)
            {
                Console.WriteLine(perguntas[i]);
                respostas[i] = Console.ReadLine();
                respostasSaida.Write(respostas[i]);
                respostasSaida.Write("; ");
            }

            respostasSaida.Close();
        }
    }
}
