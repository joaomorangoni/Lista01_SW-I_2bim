using System;

class Program {
    static List<Produto> produtos = new List<Produto>();

    static void Main(string[] args) {
        InicializarProdutos();

        ExibirTodosProdutos();
        ConsultarProdutoPorCodigo(2);
    }

    static void InicializarProdutos() {
        produtos.Add(new Produto("Camiseta", 29.99, 50));
        produtos.Add(new Produto("Calça", 49.99, 30));
        produtos.Add(new Produto("Sapato", 79.99, 20));
    }

    static void ExibirTodosProdutos() {
        Console.WriteLine("Lista de Produtos:");
        foreach (var produto in produtos) {
            Console.WriteLine($"Nome: {produto.Nome}, Preço: {produto.Preco}, Quantidade em Estoque: {produto.QuantidadeEmEstoque}");
        }
    }

    static void ConsultarProdutoPorCodigo(int codigo) {
        Produto produtoEncontrado = null;
        foreach (var produto in produtos) {
            // Supondo que o código de cada produto é o seu índice na lista + 1
            if (codigo == produtos.IndexOf(produto) + 1) {
                produtoEncontrado = produto;
                break;
            }
        }
        if (produtoEncontrado != null) {
            Console.WriteLine($"Produto encontrado: {produtoEncontrado.Nome}");
        } else {
            Console.WriteLine("Produto não encontrado.");
        }
    }
}