using System;

class Program {
    static void Main(string[] args) {
        
        Produto produto1 = new Produto("Camiseta", 29.99, 50);

        Console.WriteLine("Produto: " + produto1.Nome);
        Console.WriteLine("Preço: " + produto1.Preco);
        Console.WriteLine("Quantidade em estoque: " + produto1.QuantidadeEmEstoque);

        produto1.AdicionarItem(10);
        Console.WriteLine("Quantidade em estoque após adição: " + produto1.QuantidadeEmEstoque);

        produto1.RemoverItem(5);
        Console.WriteLine("Quantidade em estoque após remoção: " + produto1.QuantidadeEmEstoque);

        produto1.RemoverItem(100);
    }
}
