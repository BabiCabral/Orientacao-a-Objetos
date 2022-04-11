using System;

class Pessoa
{
    //Atributos
    public double peso, altura;


    //Métodos
    public double calculo()
    {
         return peso / (altura*altura);
    }
        
    public string situacao(double imc)
    {
        string retorno; 

        if(imc < 18.5)
        {
            retorno = "Abaixo do peso";
        }
        else if(imc < 25)
        {
            retorno = "Peso normal";
        }
        else if(imc < 30)
        {
            retorno = "Acima do peso";
        }
        else if(imc < 35)
        {
            retorno = "com Obesidade I";
        }
        else if(imc < 40)
        {
            retorno = "com Obesidade II";
        }
        else
        {
            retorno = "com Obesidade III";
        }

        return retorno;
    }
    
    public void mensagem()
    {
        double obterCalculo = calculo();
        string obterSituacao = situacao(obterCalculo);
        Console.WriteLine($"Seu IMC é {obterCalculo}. Você está {obterSituacao}.");
    }
}