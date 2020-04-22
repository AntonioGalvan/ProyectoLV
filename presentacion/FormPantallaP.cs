using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace presentacion
{
    public partial class frmPantallaP : Form
    {
        public frmPantallaP()
        {
            InitializeComponent();
        }

        private void btnCierre_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Dispose();
        }
        private void AbrirFormP(object formabrir)
        {
            if (this.pnlContenedor.Controls.Count > 0)
                this.pnlContenedor.Controls.RemoveAt(0);
            Form fp = formabrir as Form;
            fp.TopLevel = false;
            fp.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(fp);
            this.pnlContenedor.Tag = fp;
            fp.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormP(new frmInicio());
            Button btnInicio = (Button)sender;
            btnInicio.BackColor = Color.White;
            btnBitacora.BackColor = Color.FromArgb(130, 242, 107);
            btnMiProgreso.BackColor = Color.FromArgb(130, 242, 107);
            btnAcerca.BackColor = Color.FromArgb(130, 242, 107);
            btnCuestionario.BackColor = Color.FromArgb(130, 242, 107);
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            AbrirFormP(new FormBitacora());
            Button btnBitacora = (Button)sender;
            btnBitacora.BackColor = Color.White;
            btnInicio.BackColor = Color.FromArgb(130, 242, 107);
            btnMiProgreso.BackColor = Color.FromArgb(130, 242, 107);
            btnAcerca.BackColor = Color.FromArgb(130, 242, 107);
            btnCuestionario.BackColor = Color.FromArgb(130, 242, 107);
        }

        private void btnMiProgreso_Click(object sender, EventArgs e)
        {
            AbrirFormP(new frmMiProgreso());
            btnMiProgreso.BackColor = Color.White;
            btnInicio.BackColor = Color.FromArgb(130, 242, 107);
            btnBitacora.BackColor = Color.FromArgb(130, 242, 107);
            btnAcerca.BackColor = Color.FromArgb(130, 242, 107);
            btnCuestionario.BackColor = Color.FromArgb(130, 242, 107);
        }

        private void btnAcerca_Click(object sender, EventArgs e)
        {
            AbrirFormP(new FormAcerca());
            btnAcerca.BackColor = Color.White;
            btnInicio.BackColor = Color.FromArgb(130, 242, 107);
            btnBitacora.BackColor = Color.FromArgb(130, 242, 107);
            btnMiProgreso.BackColor = Color.FromArgb(130, 242, 107);
            btnCuestionario.BackColor = Color.FromArgb(130, 242, 107);
        }

        private void btnCuestionario_Click(object sender, EventArgs e)
        {
            AbrirFormP(new frmExistente());
            btnCuestionario.BackColor = Color.White;
            btnInicio.BackColor = Color.FromArgb(130, 242, 107);
            btnBitacora.BackColor = Color.FromArgb(130, 242, 107);
            btnAcerca.BackColor = Color.FromArgb(130, 242, 107);
            btnMiProgreso.BackColor = Color.FromArgb(130, 242, 107);
        }

        private void frmPantallaP_Load(object sender, EventArgs e)
        {
            AbrirFormP(new frmInicio());
        }

        private void lblConsejo_Click(object sender, EventArgs e)
        {
            var randomNumber = new Random().Next(0, 5);
            switch (randomNumber)
            {
                case 0: lblConsejo.Text = "Usa bicicleta o Camión";
                    break;
                case 1:
                    lblConsejo.Text = "Compra productos sin plástico";
                    break;
                case 2:
                    lblConsejo.Text = "Usa calentador solar.";
                    break;
                case 3:
                    lblConsejo.Text = "No desperdicies energía";
                    break;
                case 4:
                    lblConsejo.Text = "Usa ollas a presión";
                    break;
                case 5:
                    lblConsejo.Text = "Báñate en menos tiempo";
                    break;
            }
        }
    }
}
