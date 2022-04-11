using System;

namespace ExercíciosPráticos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar objeto da classe Aluno
            Aluno a = new Aluno();
            a.nome  = "Bárbara";
            a.nota1 = 8;
            a.nota2 = 10;
            a.mensagem();
        }
    }
}
