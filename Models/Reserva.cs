using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioHospedagemHotel.Models
{
    public class Reserva
    {

        public List<Pessoa> listaDeHospede = new List<Pessoa>();
        public Suite Suite;

        public int DiasReservados { get; set;}

        public DateTime DataEntrada { get; set; }

        public DateTime DataSaida { get; set; }


        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            foreach (var pessoa in hospedes)
            {
                listaDeHospede.Add(pessoa);
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            if( suite.Capacidade >= listaDeHospede.Count())
            {
                Suite = suite;
            }
            else
            {
                throw new Exception("Não pode ser cadastrados mais hospedes do que a capacidade maxima da suite.");
            }
        }

        public int ObterQuantidadeHospedes()
        {
            return listaDeHospede.Count;
        }

        public void CadastrarEntradaESaida(string entrada, string saida)
        {
            
                if( Convert.ToDateTime(entrada) < Convert.ToDateTime(saida))
                {
                    DataEntrada = Convert.ToDateTime(entrada);
                    DataSaida = Convert.ToDateTime(saida);
                }
                else
                {
                    throw new Exception("A data de entrada não pode ser maior que a data de saida.");
                }

            
            
        }

        public int CalculoData ()
        {
            
                TimeSpan calculoDias =  DataSaida - DataEntrada;
                int dias = calculoDias.Days;
                return dias;
               
        }

        public decimal CalcularValorDiaria()
        {
            DiasReservados = CalculoData();

            if(DiasReservados < 10)
         {
            return DiasReservados * Suite.ValorDiaria;
         }
            else
         {
           decimal percentual = Suite.ValorDiaria * DiasReservados / 10;
           decimal result = DiasReservados * Suite.ValorDiaria;
           return result - percentual ;
            
         }
        }
    }
}