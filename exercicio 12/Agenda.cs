using System;

class Pessoa {
    public string Nome { get; set; }
    public int Idade { get; set; }
    public float Altura { get; set; }

    public Pessoa(string nome, int idade, float altura) {
        Nome = nome;
        Idade = idade;
        Altura = altura;
    }
}

class Agenda {
    private List<Pessoa> pessoas;

    public Agenda() {
        pessoas = new List<Pessoa>();
    }

    public void ArmazenaPessoa(string nome, int idade, float altura) {
        pessoas.Add(new Pessoa(nome, idade, altura));
    }

    public void RemovePessoa(string nome) {
        Pessoa pessoa = BuscaPessoa(nome);
        if (pessoa != null) {
            pessoas.Remove(pessoa);
            Console.WriteLine("Pessoa removida com sucesso.");
        } else {
            Console.WriteLine("Pessoa não encontrada.");
        }
    }

    public Pessoa BuscaPessoa(string nome) {
        foreach (var pessoa in pessoas) {
            if (pessoa.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase)) {
                return pessoa;
            }
        }
        return null;
    }

    public void ImprimeAgenda() {
        Console.WriteLine("Agenda:");
        foreach (var pessoa in pessoas) {
            Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}, Altura: {pessoa.Altura}");
        }
    }
}