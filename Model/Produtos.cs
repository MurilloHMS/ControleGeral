using KhoraControl.Setup.Database;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;

namespace KhoraControl.Model
{
    public class Produtos
    {
        [Key]
        public int ID { get; set; }
        public int ID_NFe { get; set; }
        public int ID_Veiculo { get; set; }
        public string NumeroNFe { get; set; }
        public string CodigoProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public int Quantidade {  get; set; }
        public double ValorUnitario { get; set; }
        public double ValorTotal { get; set; }

        private readonly DAL<Produtos> _dal;

        public Produtos()
        {
            _dal = new DAL<Produtos>();
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

        public IEnumerable<Produtos> ReturnAll()
        {
            return _dal.ObterRegistros();
        }

        public Produtos ReturnForID(int id)
        {
            return _dal.ObterRegistroPor(r => r.ID.Equals(id));
        }
    }
}
