using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;

namespace KhoraControl.Model
{
    public class Produtos
    {
        public int ID { get; set; }
        public int ID_NFe { get; set; }
        public int ID_Veiculo { get; set; }
        public string NumeroNFe { get; set; }
        public string CodigoProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public int Quantidade {  get; set; }
        public double ValorUnitario { get; set; }
        public double ValorTotal { get; set; }
    }
}
