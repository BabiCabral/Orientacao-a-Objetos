using System;

class Aluno
{
    //Atributos
    public string nome;
    public double nota1, nota2;

    //Métodos

    //1 - Média
    public double media()
    {
        return (nota1+nota2)/2;
    }

    //2 - Situação
    public string situação(double media)
    {
        return media >= 7 ? "aprovada" : "reprovada";
    }

    // 3 - Mensagem
    public void mensagem()
    {
        //Obter a média
        double obterMedia = media();

        //Obter a situação
        string obterSituação = situação(obterMedia);

        //Mensagem
        Console.WriteLine($"{nome} está {obterSituação} com média {obterMedia}");
        
    }

}
