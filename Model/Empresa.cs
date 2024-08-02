using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhoraControl.Model
{
    internal class Empresa : Entidade
    {
        public int ID { get; set; }
        public string CNPJ { get; set; }
        public string IE {  get; set; }

    }
}
