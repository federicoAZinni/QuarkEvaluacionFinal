using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionFinal_FedericoZinni
{
    class Cotizacion
    {
        int numeroDeIdentificacion;
        string fechaYhora;
        string vendedorCode;
        Prenda prenda;
        int cantPrendas;
        float resultado;

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
