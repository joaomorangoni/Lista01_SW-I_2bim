using System;

class Program {
    static void Main(string[] args) {
        Carro carro = new Carro("Fusca", 1980);

        Console.WriteLine("Modelo do Carro: " + carro.Modelo);
        Console.WriteLine("Ano do Carro: " + carro.Ano);
        Console.WriteLine("Velocidade do Carro: " + carro.Velocidade);

        carro.Acelerar();
        Console.WriteLine("Velocidade após acelerar: " + carro.Velocidade);

        carro.Frear();
        Console.WriteLine("Velocidade após frear: " + carro.Velocidade);

        // Tentar frear novamente para mostrar que a velocidade não fica negativa
        carro.Frear();
        Console.WriteLine("Velocidade após frear novamente: " + carro.Velocidade);
    }
}