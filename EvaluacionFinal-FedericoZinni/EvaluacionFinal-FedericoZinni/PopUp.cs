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
    public partial class PopUp : Form
    {
        string message;
        public PopUp(string _message)
        {
            InitializeComponent();
            message = _message;
            this.ShowDialog();
        }

        private void PopUp_Load(object sender, EventArgs e)
        {
            ErrorPopUp.Text = message;
        }
    }
}
