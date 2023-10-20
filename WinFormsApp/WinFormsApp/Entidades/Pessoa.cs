using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Entidades
{
    public class Pessoa
    {
        public int id { get; set; }
        public string nome { get; set; } = string.Empty;
        public string cidade { get; set; } =string.Empty;
        public DateTime nascimento { get; set;}
        
    }
}
