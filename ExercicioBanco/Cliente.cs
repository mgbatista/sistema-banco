﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioBanco
{
    public class Cliente
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }


        public override string ToString()
        {
            return ("CPF: " + Cpf + "\nNome: " + Nome);
        }
    }
}
