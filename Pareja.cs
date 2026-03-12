using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    public class Pareja<T1, T2>
    {
        public T1? Valor1 { get; set; }

        public T2? Valor2 { get; set; }

        public Pareja(T1? str, T2? integer)
        {
            Valor1 = str;
            Valor2 = integer;
        }

        public override string ToString() => "First value = {0}, second value = {1}";
        

    }
}
