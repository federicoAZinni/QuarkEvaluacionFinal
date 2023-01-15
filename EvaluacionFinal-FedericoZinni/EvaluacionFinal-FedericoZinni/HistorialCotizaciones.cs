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
     partial class HistorialCotizaciones : Form
    {
        Vendedor ven;
        public HistorialCotizaciones(Vendedor _ven)
        {
            InitializeComponent();
            ven = _ven;
        }

        private void HistorialCotizaciones_Load(object sender, EventArgs e)
        {
            Label lb = new Label();
            lb.AutoSize = true;
            lb.Top = 20;
            lb.Left = 20;

            foreach (Cotizacion cotizacion in ven.histCotizaciones)
            {
                lb.Text += "-------------------------------" +
                    "\r\nN° de identificacion : " + cotizacion.numeroDeIdentificacion.ToString() +
                    "\r\nFecha y hora : " + cotizacion.fechaYhora +
                    "\r\nCódigo de vendedor : " + cotizacion.vendedorCode +
                    "\r\nPrenda Cotizada : " + cotizacion.prenda.ToString() +
                    "\r\nCantidad prendas : " + cotizacion.cantPrendas.ToString() +
                    "\r\nResultado : " + cotizacion.resultado.ToString() +
                    "\r\n-------------------------------";
            }

            this.Controls.Add(lb);
        }
    }
}
