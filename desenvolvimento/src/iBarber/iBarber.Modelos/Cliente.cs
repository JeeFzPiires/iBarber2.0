using System;
using System.Collections.Generic;
using System.Text;

namespace iBarber.Modelos
{
    public class Cliente
    {
        public int ClienteID { get; set; }

        public string Nome { get; set; }

        public string Telefone { get; set; }

        public string Logradouro { get; set; }

        public string Numero { get; set; }

        public string Bairro { get; set; }

        public string CEP { get; set; }

        public string Cidade { get; set; }
    }
}
