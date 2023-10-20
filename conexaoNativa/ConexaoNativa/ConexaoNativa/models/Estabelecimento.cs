using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexaoNativa.models
{
    public class Estabelecimento
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string logradouro { get; set;}
        public string bairro { get; set; }
        public string cidade { get; set; }
    }
}
