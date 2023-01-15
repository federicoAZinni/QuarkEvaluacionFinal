
namespace EvaluacionFinal_FedericoZinni
{
    partial class PopUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ErrorPopUp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ErrorPopUp
            // 
            this.ErrorPopUp.AutoSize = true;
            this.ErrorPopUp.Location = new System.Drawing.Point(167, 97);
            this.ErrorPopUp.Name = "ErrorPopUp";
            this.ErrorPopUp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ErrorPopUp.Size = new System.Drawing.Size(72, 13);
            this.ErrorPopUp.TabIndex = 0;
            this.ErrorPopUp.Text = "MessageError";
            this.ErrorPopUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(434, 211);
            this.Controls.Add(this.ErrorPopUp);
            this.Name = "PopUp";
            this.Text = "PopUp";
            this.Load += new System.EventHandler(this.PopUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ErrorPopUp;
    }
}