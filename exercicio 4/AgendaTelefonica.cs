using System;

class AgendaTelefonica {
    private List<Contato> contatos;

    public AgendaTelefonica() {
        contatos = new List<Contato>();
    }

    public void AdicionarContato(string nome, string telefone, string email) {
        contatos.Add(new Contato(nome, telefone, email));
    }

    public void RemoverContato(string nome) {
        Contato contato = BuscarContato(nome);
        if (contato != null) {
            contatos.Remove(contato);
            Console.WriteLine("Contato removido com sucesso.");
        } else {
            Console.WriteLine("Contato não encontrado.");
        }
    }

    public Contato BuscarContato(string nome) {
        foreach (var contato in contatos) {
            if (contato.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase)) {
                return contato;
            }
        }
        return null;
    }

    public void MostrarTodosContatos() {
        Console.WriteLine("Lista de Contatos:");
        foreach (var contato in contatos) {
            Console.WriteLine($"Nome: {contato.Nome}, Telefone: {contato.Telefone}, Email: {contato.Email}");
        }
    }
}