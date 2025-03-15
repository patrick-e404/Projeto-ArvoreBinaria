using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvoreApp
{
    public class Nodo
    {
        public Nodo Maior { get; set; }
        public Nodo Menor { get; set; }
        public string Valor { get; set; }
        public Nodo(string valor)
        {
            Valor = valor;
        }
        public override string ToString()
        {
            return Valor;
        }
    }
}
