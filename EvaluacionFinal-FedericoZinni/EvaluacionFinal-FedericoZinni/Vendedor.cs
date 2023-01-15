using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionFinal_FedericoZinni
{
       class Vendedor
    {
        public string nombre;
        public string apellido;
        public string vendedorCode;
        public Tienda tienda;
        public List<Cotizacion> histCotizaciones = new List<Cotizacion>();

        public Vendedor(string nombre, string apellido, string vendedorCode, Tienda tienda)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.vendedorCode = vendedorCode;
            this.tienda = tienda;
        }


        public float Cotizar(bool camisa,bool pantalon,bool mangaCorta,bool cuelloMao,bool premium,bool chupin, float precioUnit, int cant, ref int cantStock)
        {
            float precioCoti = precioUnit;

            if (camisa && pantalon)
            {
                //Error elegir uno
            }
            else if (camisa)
            {
                if (chupin) { /* error no se puede elegir camisa tipo chupin*/ return 0; }

                Camisa cam = new Camisa();
                cam.cuello = cuelloMao ? Cuello.cuelloMao : Cuello.cuelloComun;
                cam.manga = mangaCorta ? Manga.mangaCorta : Manga.mangaLarga;

                cam = tienda.BuscadorPrenda(cam);

                if (cant > cam.cantStock) { /*Error no hay tal cantidad*/ return 0; }

                cantStock = cam.cantStock;

                if (cam.manga == Manga.mangaCorta) precioCoti *=  0.90f;
                if (cam.cuello == Cuello.cuelloMao) precioCoti *=  1.03f;

                if (premium) precioCoti *= 1.30f;

                precioCoti *= cant;

                Cotizacion coti = new Cotizacion(histCotizaciones.Count, DateTime.Now.ToString(), vendedorCode, cam, cant,precioCoti);
                histCotizaciones.Add(coti);
            }
            else //pantalon
            {
                if (mangaCorta || cuelloMao) { /* error no se puede elegir pantalon tipo manga corta o cuello moa*/ return 0; }

                Pantalon pant = new Pantalon();
                pant.tipoPantalon = chupin ? TipoPantalon.Chupin : TipoPantalon.Comun;

                pant = tienda.BuscadorPrenda(pant);

                if (cant > pant.cantStock) { /*Error no hay tal cantidad*/ return 0; }

                cantStock = pant.cantStock;

                if (pant.tipoPantalon == TipoPantalon.Chupin) precioCoti = precioCoti * 0.88f;

                if (premium) precioCoti *= 1.30f;

                precioCoti *= cant;

                Cotizacion coti = new Cotizacion(histCotizaciones.Count, DateTime.Now.ToString(), vendedorCode, pant,cant, precioCoti);
                histCotizaciones.Add(coti);
            }

            return precioCoti;
        }


        public void MostrarHistorialCotizaciones()
        {
            HistorialCotizaciones histCoti = new HistorialCotizaciones(this);
            histCoti.ShowDialog();
        }

    }
}
