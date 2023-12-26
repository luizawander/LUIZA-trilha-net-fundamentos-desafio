using System.Diagnostics;

namespace DesafioFundamentos.Models;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
public class Estacionamento
   {
    private decimal PrecoInicial = 5;
    private decimal PrecoPorHora = 0;
    private List<string> veiculos = new List<string>();

    public Estacionamento(decimal PrecoInicial, decimal PrecoPorHora)
    {
        this.PrecoInicial = PrecoInicial;
        this.PrecoPorHora= PrecoPorHora;    
    }
    public void AdicionarVeiculo()
    {
        Console.WriteLine("Digite a placa do veiculo para estacionar: ");
        string placa = Console.ReadLine();
        veiculos.Add(placa);
    }
    public void RemoverVeiculo()
    {
        Console.WriteLine("Digite a placa do veiculo para remove: ");
        string placa = Console.ReadLine();

        if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
        {

            decimal horas = 0;
            decimal ValorTotal = 0;

            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
            horas = Console.Read();

            ValorTotal = (PrecoPorHora * horas) + PrecoInicial;

            Console.WriteLine($"Veículo com placa {placa} removido com sucesso. O preco a se pagar é {ValorTotal}");
        }
        else
        {
            Console.WriteLine($"Veículo com placa {placa} não encontrado no estacionamento.");
        }
    }
    public void ListarVeiculos()
    {
        if (veiculos.Any())
        {
            for (int contador = 0; contador < veiculos.Count;);
            Console.WriteLine($"Os veículos estacionados são: {veiculos} ");
        }
        else
        {
            Console.WriteLine("Não há veículos estacionados.");
        }
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}