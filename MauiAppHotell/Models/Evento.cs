using System;

namespace MauiAppHotell.Models
{
    public class Evento
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int NumeroParticipantes { get; set; }
        public string Local { get; set; }
        public decimal CustoPorParticipante { get; set; }
        // Duração como TimeSpan
        public TimeSpan Duracao => DataTermino - DataInicio;

        // Duração em dias (com +1 para incluir o dia final)
        public int DuracaoEmDias => Duracao.Days + 1;

        // Custo total
        public decimal CustoTotal => NumeroParticipantes * CustoPorParticipante;

    }
}

