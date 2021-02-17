using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioBanco
{
    public class Endereco
    {
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Localidade { get; set; }


        public override string ToString()
        {
            return ("Logradouro: " + Logradouro + "\nNumero: " + Numero + "\nLocalidade: " + Localidade);
        }
    }
}
