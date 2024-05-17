using System;

class Livro {
    private string titulo;
    public string Titulo {
        get { return titulo; }
        set {
            if (!string.IsNullOrEmpty(value)) {
                titulo = value;
            } else {
                Console.WriteLine("Erro: Título do livro não pode ser vazio.");
            }
        }
    }
    private string autor;
    public string Autor {
        get { return autor; }
        set {
            if (!string.IsNullOrEmpty(value)) {
                autor = value;
            } else {
                Console.WriteLine("Erro: Autor do livro não pode ser vazio.");
            }
        }
    }

    public Livro(string titulo, string autor) {
        Titulo = titulo;
        Autor = autor;
    }
}