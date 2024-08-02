using KhoraControl.Setup.Database;
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

        private readonly DAL<DadosCheckList> _dal;

        public DadosCheckList()
        {
            _dal = new DAL<DadosCheckList>();
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

        public IEnumerable<DadosCheckList> ReturnAll()
        {
            return _dal.ObterRegistros();
        }

        public DadosCheckList ReturnForID(int id)
        {
            return _dal.ObterRegistroPor(r => r.ID.Equals(id));
        }
    }
}
