
namespace EvaluacionFinal_FedericoZinni
{
    partial class Cotizador
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.nombreTienda = new System.Windows.Forms.Label();
            this.direcTienda = new System.Windows.Forms.Label();
            this.vendedorNombreApellido = new System.Windows.Forms.Label();
            this.vendedorCode = new System.Windows.Forms.Label();
            this.historialCotizaciones = new System.Windows.Forms.LinkLabel();
            this.Prenda = new System.Windows.Forms.Panel();
            this.chupin = new System.Windows.Forms.CheckBox();
            this.cuelloMao = new System.Windows.Forms.CheckBox();
            this.mangoCorta = new System.Windows.Forms.CheckBox();
            this.camisa = new System.Windows.Forms.RadioButton();
            this.pantalon = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cantStock = new System.Windows.Forms.Label();
            this.standar = new System.Windows.Forms.RadioButton();
            this.premium = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cantidadPrendas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cotizarButton = new System.Windows.Forms.Button();
            this.resultCotizacion = new System.Windows.Forms.Label();
            this.precioUni = new System.Windows.Forms.TextBox();
            this.Prenda.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Margin = new System.Windows.Forms.Padding(2);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(692, 53);
            this.title.TabIndex = 0;
            this.title.Text = "Cotizador Express";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nombreTienda
            // 
            this.nombreTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTienda.ForeColor = System.Drawing.Color.Black;
            this.nombreTienda.Location = new System.Drawing.Point(3, 19);
            this.nombreTienda.Name = "nombreTienda";
            this.nombreTienda.Size = new System.Drawing.Size(173, 17);
            this.nombreTienda.TabIndex = 1;
            this.nombreTienda.Text = "Nombre Tienda";
            // 
            // direcTienda
            // 
            this.direcTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direcTienda.ForeColor = System.Drawing.Color.Black;
            this.direcTienda.Location = new System.Drawing.Point(477, 19);
            this.direcTienda.Name = "direcTienda";
            this.direcTienda.Size = new System.Drawing.Size(171, 17);
            this.direcTienda.TabIndex = 2;
            this.direcTienda.Text = "Dirección de la tienda";
            // 
            // vendedorNombreApellido
            // 
            this.vendedorNombreApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendedorNombreApellido.ForeColor = System.Drawing.Color.Black;
            this.vendedorNombreApellido.Location = new System.Drawing.Point(29, 152);
            this.vendedorNombreApellido.Name = "vendedorNombreApellido";
            this.vendedorNombreApellido.Size = new System.Drawing.Size(248, 17);
            this.vendedorNombreApellido.TabIndex = 3;
            this.vendedorNombreApellido.Text = "Nombre y apellido del vendedor";
            // 
            // vendedorCode
            // 
            this.vendedorCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendedorCode.ForeColor = System.Drawing.Color.Black;
            this.vendedorCode.Location = new System.Drawing.Point(276, 152);
            this.vendedorCode.Name = "vendedorCode";
            this.vendedorCode.Size = new System.Drawing.Size(137, 17);
            this.vendedorCode.TabIndex = 4;
            this.vendedorCode.Text = "Código Vendedor";
            // 
            // historialCotizaciones
            // 
            this.historialCotizaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historialCotizaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.historialCotizaciones.Location = new System.Drawing.Point(502, 146);
            this.historialCotizaciones.Name = "historialCotizaciones";
            this.historialCotizaciones.Size = new System.Drawing.Size(169, 28);
            this.historialCotizaciones.TabIndex = 5;
            this.historialCotizaciones.TabStop = true;
            this.historialCotizaciones.Text = "Historial Cotizaciones";
            this.historialCotizaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.historialCotizaciones.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.historialCotizaciones_LinkClicked);
            // 
            // Prenda
            // 
            this.Prenda.AutoSize = true;
            this.Prenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Prenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Prenda.Controls.Add(this.chupin);
            this.Prenda.Controls.Add(this.cuelloMao);
            this.Prenda.Controls.Add(this.mangoCorta);
            this.Prenda.Controls.Add(this.camisa);
            this.Prenda.Controls.Add(this.pantalon);
            this.Prenda.ForeColor = System.Drawing.Color.Transparent;
            this.Prenda.Location = new System.Drawing.Point(25, 207);
            this.Prenda.Name = "Prenda";
            this.Prenda.Size = new System.Drawing.Size(651, 164);
            this.Prenda.TabIndex = 6;
            // 
            // chupin
            // 
            this.chupin.AutoSize = true;
            this.chupin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chupin.ForeColor = System.Drawing.Color.Black;
            this.chupin.Location = new System.Drawing.Point(253, 99);
            this.chupin.Name = "chupin";
            this.chupin.Size = new System.Drawing.Size(71, 21);
            this.chupin.TabIndex = 4;
            this.chupin.Text = "Chupín";
            this.chupin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chupin.UseVisualStyleBackColor = true;
            // 
            // cuelloMao
            // 
            this.cuelloMao.AutoSize = true;
            this.cuelloMao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuelloMao.ForeColor = System.Drawing.Color.Black;
            this.cuelloMao.Location = new System.Drawing.Point(479, 39);
            this.cuelloMao.Name = "cuelloMao";
            this.cuelloMao.Size = new System.Drawing.Size(97, 21);
            this.cuelloMao.TabIndex = 3;
            this.cuelloMao.Text = "Cuello Mao";
            this.cuelloMao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cuelloMao.UseVisualStyleBackColor = true;
            // 
            // mangoCorta
            // 
            this.mangoCorta.AutoSize = true;
            this.mangoCorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mangoCorta.ForeColor = System.Drawing.Color.Black;
            this.mangoCorta.Location = new System.Drawing.Point(253, 39);
            this.mangoCorta.Name = "mangoCorta";
            this.mangoCorta.Size = new System.Drawing.Size(108, 21);
            this.mangoCorta.TabIndex = 2;
            this.mangoCorta.Text = "Manga Corta";
            this.mangoCorta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mangoCorta.UseVisualStyleBackColor = true;
            // 
            // camisa
            // 
            this.camisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camisa.ForeColor = System.Drawing.Color.Black;
            this.camisa.Location = new System.Drawing.Point(36, 39);
            this.camisa.Name = "camisa";
            this.camisa.Size = new System.Drawing.Size(104, 24);
            this.camisa.TabIndex = 0;
            this.camisa.TabStop = true;
            this.camisa.Text = "Camisa";
            this.camisa.UseVisualStyleBackColor = true;
            // 
            // pantalon
            // 
            this.pantalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pantalon.ForeColor = System.Drawing.Color.Black;
            this.pantalon.Location = new System.Drawing.Point(36, 92);
            this.pantalon.Name = "pantalon";
            this.pantalon.Size = new System.Drawing.Size(84, 33);
            this.pantalon.TabIndex = 1;
            this.pantalon.TabStop = true;
            this.pantalon.Text = "Pantalón";
            this.pantalon.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(59, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Prenda";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.direcTienda);
            this.panel1.Controls.Add(this.nombreTienda);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(25, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 58);
            this.panel1.TabIndex = 8;
            // 
            // cantStock
            // 
            this.cantStock.AutoSize = true;
            this.cantStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantStock.ForeColor = System.Drawing.Color.Black;
            this.cantStock.Location = new System.Drawing.Point(21, 13);
            this.cantStock.Name = "cantStock";
            this.cantStock.Size = new System.Drawing.Size(210, 17);
            this.cantStock.TabIndex = 9;
            this.cantStock.Text = "Unidades de stock Disponibles :";
            // 
            // standar
            // 
            this.standar.AutoSize = true;
            this.standar.BackColor = System.Drawing.Color.Transparent;
            this.standar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standar.ForeColor = System.Drawing.Color.Black;
            this.standar.Location = new System.Drawing.Point(23, 18);
            this.standar.Name = "standar";
            this.standar.Size = new System.Drawing.Size(76, 21);
            this.standar.TabIndex = 10;
            this.standar.TabStop = true;
            this.standar.Text = "Standar";
            this.standar.UseVisualStyleBackColor = false;
            // 
            // premium
            // 
            this.premium.AutoSize = true;
            this.premium.BackColor = System.Drawing.Color.Transparent;
            this.premium.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.premium.ForeColor = System.Drawing.Color.Black;
            this.premium.Location = new System.Drawing.Point(149, 19);
            this.premium.Name = "premium";
            this.premium.Size = new System.Drawing.Size(81, 21);
            this.premium.TabIndex = 11;
            this.premium.TabStop = true;
            this.premium.Text = "Premium";
            this.premium.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cantStock);
            this.panel2.Location = new System.Drawing.Point(25, 385);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 45);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.standar);
            this.panel3.Controls.Add(this.premium);
            this.panel3.Location = new System.Drawing.Point(25, 447);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(252, 61);
            this.panel3.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.precioUni);
            this.panel4.Controls.Add(this.cantidadPrendas);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(303, 447);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(371, 61);
            this.panel4.TabIndex = 14;
            // 
            // cantidadPrendas
            // 
            this.cantidadPrendas.Location = new System.Drawing.Point(285, 19);
            this.cantidadPrendas.Multiline = true;
            this.cantidadPrendas.Name = "cantidadPrendas";
            this.cantidadPrendas.Size = new System.Drawing.Size(71, 21);
            this.cantidadPrendas.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(215, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Precio Unitario";
            // 
            // cotizarButton
            // 
            this.cotizarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cotizarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cotizarButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cotizarButton.FlatAppearance.BorderSize = 3;
            this.cotizarButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cotizarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cotizarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cotizarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cotizarButton.Location = new System.Drawing.Point(25, 541);
            this.cotizarButton.Name = "cotizarButton";
            this.cotizarButton.Size = new System.Drawing.Size(252, 98);
            this.cotizarButton.TabIndex = 15;
            this.cotizarButton.Text = "Cotizar";
            this.cotizarButton.UseVisualStyleBackColor = false;
            this.cotizarButton.Click += new System.EventHandler(this.cotizarButton_Click);
            // 
            // resultCotizacion
            // 
            this.resultCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultCotizacion.ForeColor = System.Drawing.Color.Black;
            this.resultCotizacion.Location = new System.Drawing.Point(303, 550);
            this.resultCotizacion.Name = "resultCotizacion";
            this.resultCotizacion.Size = new System.Drawing.Size(370, 88);
            this.resultCotizacion.TabIndex = 16;
            this.resultCotizacion.Text = "$_______________";
            this.resultCotizacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // precioUni
            // 
            this.precioUni.Location = new System.Drawing.Point(110, 19);
            this.precioUni.Name = "precioUni";
            this.precioUni.Size = new System.Drawing.Size(92, 20);
            this.precioUni.TabIndex = 3;
            // 
            // Cotizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 651);
            this.Controls.Add(this.resultCotizacion);
            this.Controls.Add(this.cotizarButton);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Prenda);
            this.Controls.Add(this.historialCotizaciones);
            this.Controls.Add(this.vendedorCode);
            this.Controls.Add(this.vendedorNombreApellido);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Cotizador";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Prenda.ResumeLayout(false);
            this.Prenda.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label nombreTienda;
        private System.Windows.Forms.Label direcTienda;
        private System.Windows.Forms.Label vendedorNombreApellido;
        private System.Windows.Forms.Label vendedorCode;
        private System.Windows.Forms.LinkLabel historialCotizaciones;
        private System.Windows.Forms.Panel Prenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chupin;
        private System.Windows.Forms.CheckBox cuelloMao;
        private System.Windows.Forms.CheckBox mangoCorta;
        private System.Windows.Forms.RadioButton camisa;
        private System.Windows.Forms.RadioButton pantalon;
        private System.Windows.Forms.Label cantStock;
        private System.Windows.Forms.RadioButton standar;
        private System.Windows.Forms.RadioButton premium;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cantidadPrendas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cotizarButton;
        private System.Windows.Forms.Label resultCotizacion;
        private System.Windows.Forms.TextBox precioUni;
    }
}

