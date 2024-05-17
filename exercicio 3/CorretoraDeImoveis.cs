using System;

class Imovel {
    public string Endereco { get; set; }
    public double Preco { get; set; }
    public string Tipo { get; set; }

    public Imovel(string endereco, double preco, string tipo) {
        Endereco = endereco;
        Preco = preco;
        Tipo = tipo;
    }
}

class CorretoraDeImoveis {
    private List<Imovel> imoveis;

    public CorretoraDeImoveis() {
        imoveis = new List<Imovel>();
    }

    public void InserirImovel(string endereco, double preco, string tipo) {
        imoveis.Add(new Imovel(endereco, preco, tipo));
    }

    public void AlterarPreco(string endereco, double novoPreco) {
        foreach (var imovel in imoveis) {
            if (imovel.Endereco == endereco) {
                imovel.Preco = novoPreco;
                return;
            }
        }
        Console.WriteLine("Imóvel não encontrado.");
    }

    public void ListarImoveis() {
        Console.WriteLine("Lista de Imóveis Disponíveis:");
        foreach (var imovel in imoveis) {
            Console.WriteLine($"Endereço: {imovel.Endereco}, Preço: {imovel.Preco}, Tipo: {imovel.Tipo}");
        }
    }

    public double CalcularValorMedio() {
        if (imoveis.Count == 0) return 0;

        double somaPrecos = 0;
        foreach (var imovel in imoveis) {
            somaPrecos += imovel.Preco;
        }
        return somaPrecos / imoveis.Count;
    }

    public void MostrarMenu() {
        int opcao;
        do {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Inserir Imóvel");
            Console.WriteLine("2. Alterar Preço do Imóvel");
            Console.WriteLine("3. Listar Imóveis");
            Console.WriteLine("4. Calcular Valor Médio");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");
            
            if (!int.TryParse(Console.ReadLine(), out opcao)) {
                Console.WriteLine("Opção inválida. Tente novamente.");
                continue;
            }

            switch (opcao) {
                case 1:
                    Console.Write("Digite o endereço do imóvel: ");
                    string endereco = Console.ReadLine();
                    Console.Write("Digite o preço do imóvel: ");
                    double preco = double.Parse(Console.ReadLine());
                    Console.Write("Digite o tipo do imóvel: ");
                    string tipo = Console.ReadLine();
                    InserirImovel(endereco, preco, tipo);
                    break;
                case 2:
                    Console.Write("Digite o endereço do imóvel que deseja alterar o preço: ");
                    string enderecoAlterar = Console.ReadLine();
                    Console.Write("Digite o novo preço: ");
                    double novoPreco = double.Parse(Console.ReadLine());
                    AlterarPreco(enderecoAlterar, novoPreco);
                    break;
                case 3:
                    ListarImoveis();
                    break;
                case 4:
                    double valorMedio = CalcularValorMedio();
                    Console.WriteLine($"Valor Médio dos Imóveis: {valorMedio}");
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