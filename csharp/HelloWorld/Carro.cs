using System;

namespace HelloWorld;

public class Carro
{
    public void Ligar()
    {
        Console.WriteLine("Carro LIGADO");
    }


    public void Desligar()
    {
        Console.WriteLine("Carro DESLIGADO");
    }
    
    private void Teste1()
    {
        Console.WriteLine("Teste 1");
    }

    
    internal void Teste2()
    {
        Console.WriteLine("Teste 2");
    }
}
