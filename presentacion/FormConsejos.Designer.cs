namespace presentacion
{
    partial class frmConsejos
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
            this.components = new System.ComponentModel.Container();
            this.btnCierre = new System.Windows.Forms.Button();
            this.pnlConsejos = new MetroFramework.Controls.MetroPanel();
            this.frmConsejosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.frmConsejosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCierre
            // 
            this.btnCierre.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCierre.Location = new System.Drawing.Point(592, 450);
            this.btnCierre.Margin = new System.Windows.Forms.Padding(2);
            this.btnCierre.Name = "btnCierre";
            this.btnCierre.Size = new System.Drawing.Size(56, 19);
            this.btnCierre.TabIndex = 3;
            this.btnCierre.Text = "Salir";
            this.btnCierre.UseVisualStyleBackColor = true;
            this.btnCierre.Click += new System.EventHandler(this.btnCierre_Click);
            // 
            // pnlConsejos
            // 
            this.pnlConsejos.HorizontalScrollbarBarColor = true;
            this.pnlConsejos.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlConsejos.HorizontalScrollbarSize = 10;
            this.pnlConsejos.Location = new System.Drawing.Point(6, 9);
            this.pnlConsejos.Name = "pnlConsejos";
            this.pnlConsejos.Size = new System.Drawing.Size(641, 441);
            this.pnlConsejos.TabIndex = 4;
            this.pnlConsejos.VerticalScrollbarBarColor = true;
            this.pnlConsejos.VerticalScrollbarHighlightOnWheel = false;
            this.pnlConsejos.VerticalScrollbarSize = 10;
            // 
            // frmConsejosBindingSource
            // 
            this.frmConsejosBindingSource.DataSource = typeof(presentacion.frmConsejos);
            // 
            // frmConsejos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(659, 480);
            this.Controls.Add(this.pnlConsejos);
            this.Controls.Add(this.btnCierre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsejos";
            this.Text = "FormConsejos";
            ((System.ComponentModel.ISupportInitialize)(this.frmConsejosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCierre;
        private MetroFramework.Controls.MetroPanel pnlConsejos;
        private System.Windows.Forms.BindingSource frmConsejosBindingSource;
    }
}