using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluacionFinal_FedericoZinni
{
    public partial class Cotizador : Form
    {
        Tienda tienda;
        Vendedor vendedor;

        public Cotizador()
        {
            InitializeComponent();
            tienda = new Tienda("Osada", "calle falsa 321");
            vendedor = new Vendedor("fede", "zinni", "456132", tienda);

            tienda.AgregarCamisa(Manga.mangaCorta, Cuello.cuelloMao, 100);
            tienda.AgregarCamisa(Manga.mangaCorta, Cuello.cuelloMao,100, true);
            tienda.AgregarCamisa(Manga.mangaCorta, Cuello.cuelloComun, 150);
            tienda.AgregarCamisa(Manga.mangaCorta, Cuello.cuelloComun, 150,true);

            tienda.AgregarCamisa(Manga.mangaLarga, Cuello.cuelloMao, 75);
            tienda.AgregarCamisa(Manga.mangaLarga, Cuello.cuelloMao, 75,true);
            tienda.AgregarCamisa(Manga.mangaLarga, Cuello.cuelloComun, 175);
            tienda.AgregarCamisa(Manga.mangaLarga, Cuello.cuelloComun, 175,true);

            tienda.AgregarPantalon(TipoPantalon.Chupin, 750);
            tienda.AgregarPantalon(TipoPantalon.Chupin, 750,true);
            tienda.AgregarPantalon(TipoPantalon.Comun, 250);
            tienda.AgregarPantalon(TipoPantalon.Comun, 250,true);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nombreTienda.Text = tienda.nombre;
            direcTienda.Text = tienda.direccion;
            vendedorNombreApellido.Text = vendedor.nombre;
            vendedorCode.Text = vendedor.vendedorCode;
        }

        private void historialCotizaciones_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            vendedor.MostrarHistorialCotizaciones();
        }

        private void cotizarButton_Click(object sender, EventArgs e)
        {
            #region ErrorCatcher
            try
            {
                float _precioUni = float.Parse(precioUni.Text);
            }
            catch (System.FormatException)
            {
                PopUp error = new PopUp("El campo de Precio por unidad solo acepta numeros");
                return;
            }
            try
            {
                int _cantidadPrendas = int.Parse(cantidadPrendas.Text);
            }
            catch (System.FormatException)
            {
                PopUp error = new PopUp("El campo de Cantidad de unidades solo acepta numeros");
                return;
            }
            #endregion

            int cantStocks = 0;
            resultCotizacion.Text = vendedor.Cotizar(camisa.Checked, pantalon.Checked, mangoCorta.Checked, cuelloMao.Checked, premium.Checked, chupin.Checked, float.Parse(precioUni.Text), int.Parse(cantidadPrendas.Text), ref cantStocks).ToString();
            cantStock.Text = cantStocks.ToString();
        }
    }
}
