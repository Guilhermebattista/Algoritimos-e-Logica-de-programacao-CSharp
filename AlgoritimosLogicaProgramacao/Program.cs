using System;

namespace AlgoritmosLogicaProgramacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double altura = 1.6558959589498499;
            int idade = 21;
            string nome = "Guilherme";

            Console.WriteLine(altura.ToString("F2"));
            Console.WriteLine(altura.ToString("F3"));
            Console.WriteLine("A idade do funcionario é :" + idade + " E sua altura é: " + altura);
        }
    }
}