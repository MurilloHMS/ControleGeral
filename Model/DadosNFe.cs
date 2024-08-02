using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace KhoraControl.Model
{
    public class DadosNFe
    {
        public int ID {  get; set; }
        public int ID_Veiculo { get; set; }
        public string ChaveDeAcesso { get; set; }
        public string NumNFe { get; set; }
        public string Serie {  get; set; }
        public string RazaoSocialRemetente { get; set; }
        public string CNPJRemetente { get; set; }
        public string RazaoSocialDestinatario { get; set; }
        public string CNPJDestinatario { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataRevisao { get; set; }
        public string NaturezaOperacao { get; set; }
        public double ValorTotalProdutos { get; set; }
        public double ValorTotalNotaFiscal { get; set; }
    }
}
