using System;
using System.Collections.Generic;
using System.Text;

namespace iBarber.Modelos
{
    public class Cidade
    {
        public string CidadeID { get; set; }
        public string Nome { get; set; }
        public string UF { get; set; }
        public Estado Estado { get; set; }
    }
}
