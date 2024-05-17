using System;

class RegistroDeCompras {
    private List<(DateTime data, string produto, double valor)> compras;

    public RegistroDeCompras() {
        compras = new List<(DateTime, string, double)>();
    }

    public void AdicionarCompra(DateTime data, string produto, double valor) {
        compras.Add((data, produto, valor));
    }

    public void ListarCompras() {
        Console.WriteLine("Registro de Compras:");
        foreach (var compra in compras) {
            Console.WriteLine($"Data: {compra.data}, Produto: {compra.produto}, Valor: {compra.valor}");
        }
    }
}