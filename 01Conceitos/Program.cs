﻿using System;

namespace Conceitos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar um objeto (criar alguma coisa a partir do molde/classe)
            Pessoa obj = new Pessoa();
            obj.nome = "Ralf";
            obj.idade = 30;
            obj.mensagem();
        }
    }
}
