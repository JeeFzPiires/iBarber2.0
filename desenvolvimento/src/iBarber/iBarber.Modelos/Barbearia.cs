using System;
using System.Collections.Generic;
using System.Text;

namespace iBarber.Modelos
{
    public class Barbearia
    {
        public int BarbeariaID { get; set; }

        public string Nome { get; set; }

        public int Telefone { get; set; }

        public string Logradouro { get; set; }

        public string Numero { get; set; }

        public int CEP { get; set; }

        public string Bairro { get; set; }

        public Cidade CidadeID { get; set; }

        public string CNPJ { get; set; }
    }
}
