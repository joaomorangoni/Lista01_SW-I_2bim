using System;

class Program {
    static void Main(string[] args) {
        Animal animal1 = new Animal("Rex", "Cachorro", 5);
        Animal animal2 = new Animal("Whiskers", "Gato", 3);

        Console.WriteLine("Nome do Animal: " + animal1.Nome);
        Console.WriteLine("Espécie do Animal: " + animal1.Especie);
        Console.WriteLine("Idade do Animal: " + animal1.Idade);

        Console.WriteLine("Som do Animal: " + animal1.EmitirSom());

        Console.WriteLine();

        Console.WriteLine("Nome do Animal: " + animal2.Nome);
        Console.WriteLine("Espécie do Animal: " + animal2.Especie);
        Console.WriteLine("Idade do Animal: " + animal2.Idade);

        Console.WriteLine("Som do Animal: " + animal2.EmitirSom());
    }
}