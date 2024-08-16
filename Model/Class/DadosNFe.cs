using KhoraControl.Setup.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace KhoraControl.Model
{
    public class DadosNFe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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

        private readonly DAL<DadosNFe> _dal;

        public DadosNFe()
        {
            _dal = new DAL<DadosNFe>();
        }

        public void Insert()
        {
            _dal.AdicionarRegistro(this);
        }

        public void Update()
        {
            _dal.AtualizarRegistro(this);
        }

        public void Delete()
        {
            _dal.DeletaRegistro(this);
        }

        public IEnumerable<DadosNFe> ReturnAll()
        {
            return _dal.ObterRegistros();
        }

        public DadosNFe ReturnForID(int id)
        {
            return _dal.ObterRegistroPor(r => r.ID.Equals(id));
        }

        public IEnumerable<DadosNFe> ReturnForIDVeiculo(int id)
        {
            return _dal.ObterListaPor(r => r.ID_Veiculo.Equals(id));
        }
    }
}
