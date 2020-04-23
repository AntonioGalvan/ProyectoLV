using presentacion.Data;
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
    public partial class frmConsejos : Form
    {
        public frmConsejos()
        {
            InitializeComponent();
        }

        private void btnCierre_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Dispose();
        }

        private void frmConsejos_Load(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                adviceBindingSource.DataSource = dataContext.Advices.ToList();
            }
            Advice advice = adviceBindingSource.Current as Advice;
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            pnlAgregarConsejo.Visible = true;
            adviceBindingSource.Add(new Advice());
            adviceBindingSource.MoveLast();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
