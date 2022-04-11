using System;

abstract class Padrao      // ´Pra classe abstract eu posso ter métodos obrigatórios ou métodos opcionais
{

    // Obrigatório (pode ser publico ou protegido)
    public abstract void taxaEmprestimo(double valor);

    // Opcional
    public void calculoPoupanca(double valor, double taxa)
    {
        Console.WriteLine($"Ganhos obtidos pela poupança R${valor*taxa}");
    }

}