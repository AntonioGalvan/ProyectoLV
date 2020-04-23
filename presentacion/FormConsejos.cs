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
            Question advice = adviceBindingSource.Current as Question;
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            pnlAgregarConsejo.Visible = true;
            adviceBindingSource.Add(new Question());
            adviceBindingSource.MoveLast();
        }
    }
}
