

using presentacion.Data;
using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace presentacion
{
    public partial class frmExperto : MetroFramework.Forms.MetroForm
    {
        public frmExperto()
        {
            InitializeComponent();
        }

        private void frmExperto_Load(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                expertBindingSource.DataSource =
                    dataContext.Experts.ToList();
            }
            pnlInformacion.Enabled = false;
            Expert expert = expertBindingSource.Current as Expert;
            if (expert != null && expert.ImageUrl != null)
                pctFotografia.Image = Image.FromFile(expert.ImageUrl);
            else
                pctFotografia.Image = null;
        }

        private void btnAgregar_Click(object sender, System.EventArgs e)
        {
            pnlInformacion.Enabled = true;
            pctFotografia.Image = null;
            expertBindingSource.Add(new Expert());
            expertBindingSource.MoveLast();
            txtNombre.Focus();
        }

        private void lblGradoEstudiantil_Click(object sender, System.EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, System.EventArgs e)
        {
            using (OpenFileDialog ofd= 
                new OpenFileDialog()
                {
                    Filter = "archivos GIF|*.gif|archivos JPEG|*.jpg|archivos PNG|*.png"
                })
            {
                if (ofd.ShowDialog()==DialogResult.OK)
                {
                    pctFotografia.Image = Image.FromFile(ofd.FileName);
                    Expert expert =
                        expertBindingSource.Current as Expert;
                    if (expert != null)
                        expert.ImageUrl = ofd.FileName;
                }    
            }
        }

        private void btnEditar_Click(object sender, System.EventArgs e)
        {
            pnlInformacion.Enabled = true;
            txtNombre.Focus();
            Expert expert =
                        expertBindingSource.Current as Expert;
        }

        private void btnEliminar_Click(object sender, System.EventArgs e)
        {
            if(MetroFramework.MetroMessageBox.Show(this, "¿Quieres eliminarlo", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.OK)
            {
                using (DataContext dataContext= new DataContext())
                {
                    Expert expert =
                        expertBindingSource.Current as Expert;
                    if (expert!=null)
                    {
                        if (dataContext.Entry<Expert>(expert).State == EntityState.Detached)
                            dataContext.Set<Expert>().Attach(expert);
                        dataContext.Entry<Expert>(expert).State = EntityState.Deleted;
                        dataContext.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Empleado eliminado");
                        expertBindingSource.RemoveCurrent();
                        pctFotografia.Image = null;
                        pnlInformacion.Enabled = false;
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            pnlInformacion.Enabled = false;
            expertBindingSource.ResetBindings(false);
            frmExperto_Load(sender, e);
        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                Expert expert =
                        expertBindingSource.Current as Expert;
                if (expert != null)
                {
                    if (dataContext.Entry<Expert>(expert).State == EntityState.Detached)
                        dataContext.Set<Expert>().Attach(expert);
                    if (expert.Id == 0)
                        dataContext.Entry<Expert>(expert).State = EntityState.Added;
                    else
                        dataContext.Entry<Expert>(expert).State = EntityState.Modified;
                        dataContext.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Empleado guardado");
                        grdDatos.Refresh();
                        pnlInformacion.Enabled = false;
                }
            }

        }

        private void grdDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Expert expert = expertBindingSource.Current as Expert;
            if (expert != null && expert.ImageUrl != null)
                pctFotografia.Image = Image.FromFile(expert.ImageUrl);
            else
                pctFotografia = null;
        }
    }
}
