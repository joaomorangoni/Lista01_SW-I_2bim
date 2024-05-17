using System;

class Program {
    static void Main(string[] args) {
        RegistroDeCompras registro = new RegistroDeCompras();

        registro.AdicionarCompra(new DateTime(2024, 5, 16), "Camiseta", 29.99);
        registro.AdicionarCompra(new DateTime(2024, 5, 17), "Calça", 49.99);
        registro.AdicionarCompra(new DateTime(2024, 5, 18), "Sapato", 79.99);

        registro.ListarCompras();
    }
}