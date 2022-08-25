using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbearia
{
    internal class Barbeiro : BaseModel
    {
        public string Sobrenome { get; set; }
        public string Nome { get; set; }
        public double Peso { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome} Sobrenome: {Sobrenome} Peso {Peso}";
        }
    }
}
