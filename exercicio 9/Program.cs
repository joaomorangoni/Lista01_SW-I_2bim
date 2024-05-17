using System;

class Program {
    static void Main(string[] args) {
        Livro livro = new Livro("O Senhor dos Anéis", "J.R.R. Tolkien");

        Console.WriteLine("Título do Livro: " + livro.Titulo);
        Console.WriteLine("Autor do Livro: " + livro.Autor);
    }
}