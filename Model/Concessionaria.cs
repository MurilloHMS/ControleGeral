﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhoraControl.Model
{
    public class Concessionaria : Entidade
    { 
        public int ID {  get; set; }
        public string CNPJ { get; set; }
        public string IE {  get; set; }
    }
}
