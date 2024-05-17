using System;

class Program {
    static void Main(string[] args) {
        Fabricante fabricante = new Fabricante("Acme Inc.", "123 Main St", "Big City");
        Produto produto = new Produto("Gadget", fabricante, 29.99);

        Console.WriteLine("Produto: " + produto.Nome);
        Console.WriteLine("Fabricante: " + produto.Fabricante.Nome);
        Console.WriteLine("Preço: " + produto.Preco);
    }
}