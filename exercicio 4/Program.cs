using System;

class Program {
    static void Main(string[] args) {
        AgendaTelefonica agenda = new AgendaTelefonica();

        agenda.AdicionarContato("João", "123456789", "joao@email.com");
        agenda.AdicionarContato("Maria", "987654321", "maria@email.com");

        agenda.MostrarTodosContatos();

        agenda.RemoverContato("Maria");

        agenda.MostrarTodosContatos();
    }
}