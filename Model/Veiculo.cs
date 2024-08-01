using KhoraControl.Setup.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhoraControl.Model
{
    public class Veiculo
    {
        [Key]
        private int ID { get; set; }
        [Required]
        private string Marca { get; set; }
        [Required]
        private string Placa { get; set; }
        private int? KmRodados {  get; set; }
        public DateTime? DataDaCompra {  get; set; }
        private int? KmQuandoComprado { get; set; }
        private string Ano {  get; set; }
        private string Modelo { get; set; }
        private DateTime? DataUltimaRevisao { get; set; }
        private int? KmUltimaRevisao { get; set; }
        private DateTime? DataProximaRevisao { get; set; }
        private int? KmProximaRevisao{ get; set; }
        private int? ID_Concessionaria { get; set; }
        private string? Motorista { get; set; }
        private string? SugestaoConcessionaria { get; set; }
        private string? Observacoes {  get; set; }

        private readonly DAL<Veiculo> _dal;

        public Veiculo()
        {
            _dal = new DAL<Veiculo>();
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

        public IEnumerable<Veiculo> GetAll()
        {
            return _dal.ObterRegistros();
        }
    }
}
