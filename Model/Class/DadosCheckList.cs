using KhoraControl.Model.Validation;
using KhoraControl.Setup.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace KhoraControl.Model
{
    public class DadosCheckList : ValidaObjeto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public int ID_Veiculo { get; set; }
        public int? ID_NotaFiscal { get; set; }
        public int? KmRodados { get; set; }
        [Required]
        public DateTime Data {  get; set; }
        [Required]
        public int ID_Concessionaria { get; set; }
        public string? Observacoes { get; set; }
        [Required]
        public double ValorRevisao { get; set; }
        public string ChecklistJson { get; set; }

        [NotMapped]
        public List<string> ChecklistItems
        {
            get => JsonSerializer.Deserialize<List<string>>(ChecklistJson) ?? new List<string>();
            set => ChecklistJson = JsonSerializer.Serialize(value);
        }

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
