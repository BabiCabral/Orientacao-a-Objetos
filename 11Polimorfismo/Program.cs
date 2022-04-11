using System;

namespace _11Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar Estagiário
            Imposto objetoE = new Estagiario();    // meu objetoE vai ter acesso a minhas classe imposto.
            objetoE.valeAlimentação(1000);         //Se a classe Estagiario tiver algum método igual a um 
            objetoE.valeTransporte(1000);          //método da classe imposto, ele vai
            Console.WriteLine("--------------");   //sobreescrever o método que está na classe Imposto. E se 
                                                   //ele tiver métodos que a classe imposto 
                                                    //não tem, nos podemos usar em cima desse objeto.
            // Instanciar Gerente
            Imposto objetoG = new Gerente();
            objetoG.valeAlimentação(5000);    
            objetoG.valeTransporte(5000);   
            Console.WriteLine("--------------");

            // Instanciar Atendente
            Imposto objetoA = new Atendente();
            objetoA.valeAlimentação(2000);    
            objetoA.valeTransporte(2000);   
            Console.WriteLine("--------------");

        }
    }
}
