Desafio proposto pela DIO, para ser criado um sistema de hospedagem de hotel utilizando POO, onde tinhamos que criar três classes, como pessoa, suite e reserva.

Classe ##Pessoa
Atributos: Nome, sobrenome

Classe ##Suite
Atributos: TipoSuite, Capacidade, ValorDiaria

Classe ##Reserva
Atributos: ListaDeHospedes, DiasReservados, DataEntrada, DataSaida

Métodos:
CadastrarHospedes()
Cadastra Pessoa numa lista.

CadastratSuite()
Cadastra uma suite com todas as informações como tipoSuite,Capacidade e valorDiaria.

ObterQuantidadeHospedes()
Retornar a quantidade de hospedes 

CadastrarEntradaESaida()
Efetua uma validação de data para a data de saida não ser menor do que a data de entrada.

CalculoData()
Efetua uma subtração com as Datas informada.

CalcularValorDiaria()
Calcula o valor da diária em cima da quantidade de dias reservados,
caso a reserva seja maior ou igual a 10 dias, o valor da diária sofre um desconto
de 10%.
