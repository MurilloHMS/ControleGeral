﻿using KhoraControl.Model.Validation;
using KhoraControl.Setup.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace KhoraControl.Model
{
    public class Concessionaria : Entidade
    {
        
        public string? CNPJ { get; set; }
        public string? IE {  get; set; }

        private readonly DAL<Concessionaria> _dal;
        public Concessionaria()
        {
            _dal = new DAL<Concessionaria>();   
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

        public IEnumerable<Concessionaria> ReturnAll()
        {
            return _dal.ObterRegistros();
        }

        public Concessionaria ReturnForID(int id)
        {
            return _dal.ObterRegistroPor(r => r.ID.Equals(id));
        }

        public Concessionaria ReturnForName(string name)
        {
            return _dal.ObterRegistroPor(r => r.Nome.Equals(name));    
        }
    }
}
