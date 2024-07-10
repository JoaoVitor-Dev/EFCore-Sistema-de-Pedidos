// See https://aka.ms/new-console-template for more information
using EFCoreSistemaDePedidos.Domain;
using EFCoreSistemaDePedidos.Data;
using EFCoreSistemaDePedidos.Data.Configurations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando sistema de pedidos com EF Core");

        InserirDados();
    }
    public static void InserirDados()
    {
        var produto = new Produto
        {
            Descricao = "Produto Teste",
            CodigoBarras = "1234567891231",
            Valor = 10m,
            TipoProduto = EFCoreSistemaDePedidos.ValueObjects.TipoProduto.MercadoriaParaRevenda,
            Ativo = true
        };

        using var db = new EFCoreSistemaDePedidos.Data.ApplicationContext();

        db.Set<Produto>().Add(produto);

        var registros = db.SaveChanges();

        Console.WriteLine($"Total Registro(s):  {registros}");

    }
}

