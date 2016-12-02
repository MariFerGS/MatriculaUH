using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace MatriculaUH
{
    public partial class ListadoCarreras : Form
    {
        Carreras manipulardatos = new Carreras();//instancia de la clase
        String idcarrera;//variable de la cedula
        public ListadoCarreras()
        {
            InitializeComponent();
        }

        private void ListadoCarreras_Load(object sender, EventArgs e)
        {
            Carreras objeto = new Carreras();
            objeto.actualizargrid(this.dataGridView1, "select*from Carrera");//nombre de la tabla de la data
        }

        private void tx_escribir_carrera_KeyUp(object sender, KeyEventArgs e)
        {
            manipulardatos.actualizargrid(this.dataGridView1, "select*from Carrera where nombre like '" + tx_escribir_carrera.Text + "%';");
        }
    }
}
