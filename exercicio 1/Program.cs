using System;

class Program {
    static void Main(string[] args) {
        // Exemplo de uso da classe Produto
        Produto produto1 = new Produto("Camiseta", 29.99, 50);

        Console.WriteLine("Produto: " + produto1.Nome);
        Console.WriteLine("Preço: " + produto1.Preco);
        Console.WriteLine("Quantidade em estoque: " + produto1.QuantidadeEmEstoque);

        // Adicionando 10 itens ao estoque
        produto1.AdicionarItem(10);
        Console.WriteLine("Quantidade em estoque após adição: " + produto1.QuantidadeEmEstoque);

        // Removendo 5 itens do estoque
        produto1.RemoverItem(5);
        Console.WriteLine("Quantidade em estoque após remoção: " + produto1.QuantidadeEmEstoque);

        // Tentando remover mais itens do que o disponível em estoque
        produto1.RemoverItem(100);
    }
}
