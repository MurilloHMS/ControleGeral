using KhoraControl.Model.Validation;
using KhoraControl.Setup.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhoraControl.Model
{
    public class CheckList : ValidaObjeto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required] 
        public string Descricao { get; set; }


        private readonly DAL<CheckList> _dal;
        public CheckList() 
        {
            _dal = new DAL<CheckList>();
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

        public IEnumerable<CheckList> ReturnAll()
        {
            return _dal.ObterRegistros();
        }

        public CheckList ReturnForID(int id)
        {
            return _dal.ObterRegistroPor(r => r.Id.Equals(id));
        }
    }
}
