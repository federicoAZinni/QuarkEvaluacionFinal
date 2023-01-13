using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionFinal_FedericoZinni
{
    abstract class Prenda
    {
        public bool premium;
        public int precioUni;
        public int cantStock;
    }

    public enum TipodePrenda { Camisa, Pantalon }
}
