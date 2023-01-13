using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionFinal_FedericoZinni
{
    class Tienda
    {
        public string nombre;
        public string direccion;
        public List<Camisa> camisas = new List<Camisa>();
        public List<Pantalon> pantalones = new List<Pantalon>();


        public Tienda(string _nombre, string _direccion)
        {
            nombre = _nombre;
            direccion = _direccion;
        }

        #region Agregar Prendas
        public void AgregarCamisa(Manga manga, Cuello cuello, int cant,bool premium=false)
        {
            Camisa camisa = new Camisa();
            camisa.cuello = cuello;
            camisa.manga = manga;
            camisa.cantStock = cant;
            camisa.premium = premium;
            camisas.Add(camisa);
        }
        public void AgregarPantalon(TipoPantalon tipoPantalon, int cant, bool premium = false)
        {
            Pantalon pantalon = new Pantalon();
            pantalon.tipoPantalon = tipoPantalon;
            pantalon.premium = premium;
            pantalon.cantStock = cant;
            pantalones.Add(pantalon);
        }
        #endregion

        #region Buscar Prendas
        public Camisa BuscadorPrenda(Camisa prenda)
        {
            foreach (var item in camisas)
            {
                if (prenda.cuello == item.cuello && prenda.manga == item.manga && prenda.premium == item.premium) return item;
            }
            return null;
        }
        public Pantalon BuscadorPrenda(Pantalon prenda)
        {
            foreach (var item in pantalones)
            {
                if (prenda.tipoPantalon == item.tipoPantalon && prenda.premium == item.premium) return item;
            }
            return null;
        }
        #endregion
    }
}
