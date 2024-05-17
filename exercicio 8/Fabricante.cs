using System;

class Fabricante {
    private string nome;
    public string Nome {
        get { return nome; }
        set {
            if (!string.IsNullOrEmpty(value)) {
                nome = value;
            } else {
                Console.WriteLine("Erro: Nome do fabricante não pode ser vazio.");
            }
        }
    }
    public string Endereco { get; set; }
    public string Cidade { get; set; }

    public Fabricante(string nome, string endereco, string cidade) {
        Nome = nome;
        Endereco = endereco;
        Cidade = cidade;
    }
}