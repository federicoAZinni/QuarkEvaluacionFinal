using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionFinal_FedericoZinni
{
    public struct Cotizacion
    {
        public int numeroDeIdentificacion;
        public string fechaYhora;
        public string vendedorCode;
        public Prenda prenda;
        public int cantPrendas;
        public float resultado;

        public Cotizacion(int _numeroDeIdentificacion, string _fechaYhora, string _vendedorCode, Prenda _prenda, int _cantPrendas, float _resultado)
        {
            numeroDeIdentificacion = _numeroDeIdentificacion;
            fechaYhora = _fechaYhora;
            vendedorCode = _vendedorCode;
            prenda = _prenda;
            cantPrendas = _cantPrendas;
            resultado = _resultado;
        }
    }
}
