using System;
using System.Collections.Generic;
using System.Text;

namespace iBarber.Modelos
{
    public class Agendamento
    {
        public int AgendamentoID { get; set; }

        public DateTime DataHoraInicio { get; set; }

        public DateTime DataHoraFinal { get; set; }

        public string ComentarioAvaliacao { get; set; }

        public int EstrelaAvaliacao { get; set; }

        public int BarbeariaID { get; set; }

        public int BarbeiroID { get; set; }

        public int ClienteID { get; set; }

        public Barbearia Barbearia { get; set; }

        public Barbeiro Barbeiro { get; set; }

        public Cliente Cliente { get; set; }
    }
}
