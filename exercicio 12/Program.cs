using System;

class Program {
    static void Main(string[] args) {
        Agenda agenda = new Agenda();
        int opcao;

        do {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Adicionar Pessoa");
            Console.WriteLine("2. Remover Pessoa");
            Console.WriteLine("3. Buscar Pessoa");
            Console.WriteLine("4. Imprimir Agenda");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");

            if (!int.TryParse(Console.ReadLine(), out opcao)) {
                Console.WriteLine("Opção inválida. Tente novamente.");
                continue;
            }

            switch (opcao) {
                case 1:
                    Console.Write("Nome da pessoa: ");
                    string nome = Console.ReadLine();
                    Console.Write("Idade da pessoa: ");
                    int idade = int.Parse(Console.ReadLine());
                    Console.Write("Altura da pessoa: ");
                    float altura = float.Parse(Console.ReadLine());
                    agenda.ArmazenaPessoa(nome, idade, altura);
                    break;
                case 2:
                    Console.Write("Nome da pessoa que deseja remover: ");
                    string nomeRemover = Console.ReadLine();
                    agenda.RemovePessoa(nomeRemover);
                    break;
                case 3:
                    Console.Write("Nome da pessoa que deseja buscar: ");
                    string nomeBuscar = Console.ReadLine();
                    Pessoa pessoaEncontrada = agenda.BuscaPessoa(nomeBuscar);
                    if (pessoaEncontrada != null) {
                        Console.WriteLine($"Pessoa encontrada: {pessoaEncontrada.Nome}, Idade: {pessoaEncontrada.Idade}, Altura: {pessoaEncontrada.Altura}");
                    } else {
                        Console.WriteLine("Pessoa não encontrada.");
                    }
                    break;
                case 4:
                    agenda.ImprimeAgenda();
                    break;
                case 0:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        } while (opcao != 0);
    }
}