using System;

class Tarefa {
    public string Descricao { get; set; }
    public DateTime DataVencimento { get; set; }

    public Tarefa(string descricao, DateTime dataVencimento) {
        Descricao = descricao;
        DataVencimento = dataVencimento;
    }
}

class GerenciadorDeTarefas {
    private List<Tarefa> tarefas;

    public GerenciadorDeTarefas() {
        tarefas = new List<Tarefa>();
    }

    public void AdicionarTarefa(string descricao, DateTime dataVencimento) {
        tarefas.Add(new Tarefa(descricao, dataVencimento));
    }

    public void RemoverTarefa(string descricao) {
        Tarefa tarefa = BuscarTarefa(descricao);
        if (tarefa != null) {
            tarefas.Remove(tarefa);
            Console.WriteLine("Tarefa removida com sucesso.");
        } else {
            Console.WriteLine("Tarefa não encontrada.");
        }
    }

    public Tarefa BuscarTarefa(string descricao) {
        foreach (var tarefa in tarefas) {
            if (tarefa.Descricao.Equals(descricao, StringComparison.OrdinalIgnoreCase)) {
                return tarefa;
            }
        }
        return null;
    }

    public void ListarTarefas() {
        Console.WriteLine("Lista de Tarefas:");
        foreach (var tarefa in tarefas) {
            Console.WriteLine($"Descrição: {tarefa.Descricao}, Data de Vencimento: {tarefa.DataVencimento.ToShortDateString()}");
        }
    }

    public bool TarefaDeveSerExecutadaHoje(Tarefa tarefa) {
        return tarefa.DataVencimento.Date == DateTime.Today;
    }
}