using System;

class Produto {
    private string nome;
    public string Nome {
        get { return nome; }
        set {
            if (!string.IsNullOrEmpty(value)) {
                nome = value;
            } else {
                Console.WriteLine("Erro: Nome do produto não pode ser vazio.");
            }
        }
    }
    public Fabricante Fabricante { get; set; }
    private double preco;
    public double Preco {
        get { return preco; }
        set {
            if (value >= 0) {
                preco = value;
            } else {
                Console.WriteLine("Erro: O preço do produto deve ser positivo.");
            }
        }
    }

    public Produto(string nome, Fabricante fabricante, double preco) {
        Nome = nome;
        Fabricante = fabricante;
        Preco = preco;
    }
}