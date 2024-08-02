using KhoraControl.Setup.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhoraControl.Model
{
    public class Empresa : Entidade
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string CNPJ { get; set; }
        [Required]
        public string IE {  get; set; }

        private readonly DAL<Empresa> _dal;

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
