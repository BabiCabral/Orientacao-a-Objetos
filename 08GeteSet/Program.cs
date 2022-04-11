using System;

namespace _08GeteSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            p.Nome = "Bárbara";            // enviando uma informação (set)
            Console.WriteLine(p.Nome);    // obtendo/recebendo uma infomação (get)
        }
    }
}
