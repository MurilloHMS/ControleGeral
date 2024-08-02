using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhoraControl.Model
{
    internal class DadosCheckList
    {
        public int ID { get; set; }
        public int ID_Veiculo { get; set; }
        public int ID_Item { get; set; }
        public int ID_NotaFiscal { get; set; }
        public int KmRodados { get; set; }
        public DateTime Data {  get; set; }
        public int ID_Concessionaria { get; set; }
        public string Observacoes { get; set; }
    }
}
