using System;

class Pessoa
{

    // Atributos
    protected string nome;
    protected int idade;

    //método
    protected void mensagemPessoa()
    {
        Console.WriteLine($"nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
    }
}