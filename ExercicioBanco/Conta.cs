using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioBanco
{
    public class Conta
    {
        public string Agencia { get; set; }
        public string NumConta { get; set; }
        public float Saldo { get; set; }
        public float Valor { get; set; }

        

        public override string ToString()
        {
            return ("Agência: " + Agencia + "\nNúmero da Conta: " + NumConta + "\nSaldo: " + Saldo);
        }


    }
}
