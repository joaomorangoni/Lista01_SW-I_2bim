using System;

class Produto {
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int QuantidadeEmEstoque { get; private set; }

    public Produto(string nome, double preco, int quantidadeEmEstoque) {
        Nome = nome;
        Preco = preco;
        QuantidadeEmEstoque = quantidadeEmEstoque;
    }

    public void AdicionarItem(int quantidade) {
        QuantidadeEmEstoque += quantidade;
    }

    public void RemoverItem(int quantidade) {
        if (quantidade <= QuantidadeEmEstoque) {
            QuantidadeEmEstoque -= quantidade;
        } else {
            Console.WriteLine("Erro: Não há itens suficientes em estoque.");
        }
    }
}