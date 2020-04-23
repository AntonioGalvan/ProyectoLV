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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCierre = new System.Windows.Forms.Button();
            this.pnlConsejos0 = new MetroFramework.Controls.MetroPanel();
            this.grdConsejos = new MetroFramework.Controls.MetroGrid();
            this.text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlConsejos1 = new MetroFramework.Controls.MetroPanel();
            this.lblEncabezado = new MetroFramework.Controls.MetroLabel();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblConsejo = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnAgregarNuevo = new MetroFramework.Controls.MetroButton();
            this.pnlAgregarConsejo = new MetroFramework.Controls.MetroPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.pnlConsejos0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsejos)).BeginInit();
            this.pnlConsejos1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adviceBindingSource)).BeginInit();
            this.pnlAgregarConsejo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCierre
            // 
            this.btnCierre.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCierre.Location = new System.Drawing.Point(585, 450);
            this.btnCierre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCierre.Name = "btnCierre";
            this.btnCierre.Size = new System.Drawing.Size(56, 19);
            this.btnCierre.TabIndex = 3;
            this.btnCierre.Text = "Salir";
            this.btnCierre.UseVisualStyleBackColor = true;
            this.btnCierre.Click += new System.EventHandler(this.btnCierre_Click);
            // 
            // pnlConsejos0
            // 
            this.pnlConsejos0.Controls.Add(this.pnlConsejos1);
            this.pnlConsejos0.Controls.Add(this.btnCierre);
            this.pnlConsejos0.HorizontalScrollbarBarColor = true;
            this.pnlConsejos0.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlConsejos0.HorizontalScrollbarSize = 10;
            this.pnlConsejos0.Location = new System.Drawing.Point(1, 1);
            this.pnlConsejos0.Name = "pnlConsejos0";
            this.pnlConsejos0.Size = new System.Drawing.Size(659, 480);
            this.pnlConsejos0.TabIndex = 4;
            this.pnlConsejos0.VerticalScrollbarBarColor = true;
            this.pnlConsejos0.VerticalScrollbarHighlightOnWheel = false;
            this.pnlConsejos0.VerticalScrollbarSize = 10;
            // 
            // grdConsejos
            // 
            this.grdConsejos.AllowUserToResizeRows = false;
            this.grdConsejos.AutoGenerateColumns = false;
            this.grdConsejos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdConsejos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdConsejos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdConsejos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdConsejos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdConsejos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdConsejos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.text,
            this.profileDataGridViewTextBoxColumn});
            this.grdConsejos.DataSource = this.adviceBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdConsejos.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdConsejos.EnableHeadersVisualStyles = false;
            this.grdConsejos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdConsejos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdConsejos.Location = new System.Drawing.Point(676, 12);
            this.grdConsejos.Name = "grdConsejos";
            this.grdConsejos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdConsejos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdConsejos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdConsejos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdConsejos.Size = new System.Drawing.Size(444, 223);
            this.grdConsejos.TabIndex = 2;
            this.grdConsejos.Visible = false;
            // 
            // text
            // 
            this.text.DataPropertyName = "text";
            this.text.HeaderText = "text";
            this.text.Name = "text";
            // 
            // pnlConsejos1
            // 
            this.pnlConsejos1.Controls.Add(this.pnlAgregarConsejo);
            this.pnlConsejos1.Controls.Add(this.btnAgregarNuevo);
            this.pnlConsejos1.Controls.Add(this.metroLabel1);
            this.pnlConsejos1.Controls.Add(this.lblConsejo);
            this.pnlConsejos1.Controls.Add(this.lblEncabezado);
            this.pnlConsejos1.HorizontalScrollbarBarColor = true;
            this.pnlConsejos1.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlConsejos1.HorizontalScrollbarSize = 10;
            this.pnlConsejos1.Location = new System.Drawing.Point(15, 14);
            this.pnlConsejos1.Name = "pnlConsejos1";
            this.pnlConsejos1.Size = new System.Drawing.Size(625, 422);
            this.pnlConsejos1.TabIndex = 4;
            this.pnlConsejos1.VerticalScrollbarBarColor = true;
            this.pnlConsejos1.VerticalScrollbarHighlightOnWheel = false;
            this.pnlConsejos1.VerticalScrollbarSize = 10;
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.AutoSize = true;
            this.lblEncabezado.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblEncabezado.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblEncabezado.Location = new System.Drawing.Point(34, 44);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(119, 25);
            this.lblEncabezado.TabIndex = 2;
            this.lblEncabezado.Text = "¿Sabías que?";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            // 
            // profileDataGridViewTextBoxColumn
            // 
            this.profileDataGridViewTextBoxColumn.DataPropertyName = "Profile";
            this.profileDataGridViewTextBoxColumn.HeaderText = "Profile";
            this.profileDataGridViewTextBoxColumn.Name = "profileDataGridViewTextBoxColumn";
            // 
            // adviceBindingSource
            // 
            this.adviceBindingSource.DataSource = typeof(presentacion.Data.Question);
            // 
            // lblConsejo
            // 
            this.lblConsejo.AutoSize = true;
            this.lblConsejo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblConsejo.Location = new System.Drawing.Point(45, 101);
            this.lblConsejo.MaximumSize = new System.Drawing.Size(100, 0);
            this.lblConsejo.Name = "lblConsejo";
            this.lblConsejo.Size = new System.Drawing.Size(73, 25);
            this.lblConsejo.TabIndex = 3;
            this.lblConsejo.Text = "Consejo";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(45, 256);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(325, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "¿Quieres agregar un consejo? Pulsa el siguiente botón";
            // 
            // btnAgregarNuevo
            // 
            this.btnAgregarNuevo.Location = new System.Drawing.Point(428, 256);
            this.btnAgregarNuevo.Name = "btnAgregarNuevo";
            this.btnAgregarNuevo.Size = new System.Drawing.Size(173, 23);
            this.btnAgregarNuevo.TabIndex = 5;
            this.btnAgregarNuevo.Text = "Agregar Nuevo Consejo";
            this.btnAgregarNuevo.UseSelectable = true;
            this.btnAgregarNuevo.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pnlAgregarConsejo
            // 
            this.pnlAgregarConsejo.Controls.Add(this.btnAgregar);
            this.pnlAgregarConsejo.Controls.Add(this.metroTextBox1);
            this.pnlAgregarConsejo.Controls.Add(this.metroLabel2);
            this.pnlAgregarConsejo.HorizontalScrollbarBarColor = true;
            this.pnlAgregarConsejo.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlAgregarConsejo.HorizontalScrollbarSize = 10;
            this.pnlAgregarConsejo.Location = new System.Drawing.Point(29, 279);
            this.pnlAgregarConsejo.Name = "pnlAgregarConsejo";
            this.pnlAgregarConsejo.Size = new System.Drawing.Size(572, 130);
            this.pnlAgregarConsejo.TabIndex = 6;
            this.pnlAgregarConsejo.VerticalScrollbarBarColor = true;
            this.pnlAgregarConsejo.VerticalScrollbarHighlightOnWheel = false;
            this.pnlAgregarConsejo.VerticalScrollbarSize = 10;
            this.pnlAgregarConsejo.Visible = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(26, 12);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(142, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Escribe tu consejo aquí";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(353, 2);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[] {
        "Consejo"};
            this.metroTextBox1.Location = new System.Drawing.Point(185, 12);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(371, 20);
            this.metroTextBox1.TabIndex = 3;
            this.metroTextBox1.Text = "Consejo";
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(104, 71);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar ";
            this.btnAgregar.UseSelectable = true;
            // 
            // frmConsejos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1130, 480);
            this.Controls.Add(this.pnlConsejos0);
            this.Controls.Add(this.grdConsejos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsejos";
            this.Text = "FormConsejos";
            this.Load += new System.EventHandler(this.frmConsejos_Load);
            this.pnlConsejos0.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdConsejos)).EndInit();
            this.pnlConsejos1.ResumeLayout(false);
            this.pnlConsejos1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adviceBindingSource)).EndInit();
            this.pnlAgregarConsejo.ResumeLayout(false);
            this.pnlAgregarConsejo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCierre;
        private MetroFramework.Controls.MetroPanel pnlConsejos0;
        private System.Windows.Forms.BindingSource adviceBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroGrid grdConsejos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn text;
        private System.Windows.Forms.DataGridViewTextBoxColumn profileDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroPanel pnlConsejos1;
        private MetroFramework.Controls.MetroLabel lblEncabezado;
        private MetroFramework.Controls.MetroPanel pnlAgregarConsejo;
        private MetroFramework.Controls.MetroButton btnAgregarNuevo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblConsejo;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}