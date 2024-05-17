using System;

class Program {
    static void Main(string[] args) {
        GerenciadorDeTarefas gerenciador = new GerenciadorDeTarefas();

        gerenciador.AdicionarTarefa("Estudar para o exame", new DateTime(2024, 5, 16));
        gerenciador.AdicionarTarefa("Ir ao mercado", new DateTime(2024, 5, 17));

        gerenciador.ListarTarefas();

        Tarefa tarefa = gerenciador.BuscarTarefa("Estudar para o exame");
        if (tarefa != null && gerenciador.TarefaDeveSerExecutadaHoje(tarefa)) {
            Console.WriteLine("Tarefa deve ser executada hoje!");
        } else {
            Console.WriteLine("Tarefa não deve ser executada hoje.");
        }
    }
}