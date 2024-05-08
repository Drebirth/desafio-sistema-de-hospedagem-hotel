using DesafioHospedagemHotel.Models;
//teste git
Pessoa p1 = new Pessoa("Daniel", "Silva");
Pessoa p2 = new Pessoa("Sandra", "Alves");
Pessoa p3 = new Pessoa("Laura", "Helena");

List<Pessoa> Hospedes = new List<Pessoa>();
Hospedes.Add(p1);
Hospedes.Add(p2);   
Hospedes.Add(p3);

// Instancia a Suite
Suite suite = new Suite("Presidencial", 4, 75.15M);

// Instanciando a Reserva
Reserva reserva = new Reserva();
reserva.CadastrarEntradaESaida("07/05/2024","08/05/2024");
reserva.CadastrarHospedes(Hospedes);
reserva.CadastrarSuite(suite);


Console.WriteLine("Informações da reserva: ");
Console.WriteLine($"Tipo da Suite: {suite.TipoSuite}\nCapacidade: {suite.Capacidade}\nValor da diaria: {suite.ValorDiaria:C}");
Console.WriteLine($"Quantidade de hospedes {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Tempo hospedado: Entre {reserva.DataEntrada.ToShortDateString()} e {reserva.DataSaida.ToShortDateString()}");
Console.WriteLine($"O valor ao final dos  {reserva.CalculoData()} dias reservados ficou {reserva.CalcularValorDiaria():C}");
