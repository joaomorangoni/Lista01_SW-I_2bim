using System;

class Animal {
    public string Nome { get; set; }
    public string Especie { get; set; }
    public int Idade { get; set; }

    public Animal(string nome, string especie, int idade) {
        Nome = nome;
        Especie = especie;
        Idade = idade;
    }

    public string EmitirSom() {
        switch (Especie.ToLower()) {
            case "cachorro":
                return "Au Au!";
            case "gato":
                return "Miau!";
            case "passaro":
                return "Piu Piu!";
            default:
                return "O som do animal é indefinido.";
        }
    }
}