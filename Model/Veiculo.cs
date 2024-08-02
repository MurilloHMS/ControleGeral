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
        public int ID { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        public string Placa { get; set; }
        public int? KmRodados {  get; set; }
        public DateTime? DataDaCompra {  get; set; }
        public int? KmQuandoComprado { get; set; }
        public string Ano {  get; set; }
        public string Modelo { get; set; }
        public DateTime? DataUltimaRevisao { get; set; }
        public int? KmUltimaRevisao { get; set; }
        public DateTime? DataProximaRevisao { get; set; }
        public int? KmProximaRevisao{ get; set; }
        public int? ID_Concessionaria { get; set; }
        public string? Motorista { get; set; }
        public string? SugestaoConcessionaria { get; set; }
        public string? Observacoes {  get; set; }
        [Required]
        public string LocalSalvamentoDeDados { get; set; }
        public string? NotaFiscalDeCompra { get; set; }
        public int? ID_Empresa { get; set; }
        public string? TipoVeiculo { get; set; }


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
