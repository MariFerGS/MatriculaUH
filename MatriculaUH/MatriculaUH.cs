using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatriculaUH
{
    public partial class MatriculaUH : Form
    {
        private int childFormNumber = 0;

        public MatriculaUH()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

     

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           NuevoAlumno frm = new NuevoAlumno(); //objeto creado
            frm.MdiParent = this;//llama al formulario 
            frm.Show(); //muestra formulario de nuevo alumno
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Actualizar_alumno actualizar = new Actualizar_alumno();//objeto
            actualizar.MdiParent = this;//llama al formulario 
            actualizar.Show(); //muestra formulario de actualizar alumno

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Eliminar_Alumno elimina = new Eliminar_Alumno();//objeto creado
            elimina.MdiParent = this;//llama al formulario 
            elimina.Show(); //muestra formulario de eliminar alumno
        }

        private void nuevaMatrículaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaMatricula nueva = new NuevaMatricula();
            nueva.MdiParent = this;
            nueva.Show();
        }

        private void consultaMatriculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaMatricula consulta = new ConsultaMatricula();
            consulta.MdiParent = this;
            consulta.Show();
        }

        private void agregarCarrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarCarrera carrera = new AgregarCarrera();
            carrera.MdiParent = this;
            carrera.Show();
        }

        private void eliminarCarrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarCarrera eliminar = new EliminarCarrera();
            eliminar.MdiParent = this;
            eliminar.Show();
        }

        private void listaCarrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoCarreras lista = new ListadoCarreras();
            lista.MdiParent = this;
            lista.Show();
        }
    }
}
