using KhoraControl.Setup.Database;
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

        public readonly DAL<Empresa> _dal;

        public Empresa()
        {
            _dal = new DAL<Empresa>();
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

        public IEnumerable<Empresa> ReturnAll()
        {
            return _dal.ObterRegistros();
        }

        public Empresa ReturnForID(int id)
        {
            return _dal.ObterRegistroPor(r => r.ID.Equals(id));
        }
    }
}
