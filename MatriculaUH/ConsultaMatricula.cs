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
    public partial class ConsultaMatricula : Form
    {
        Matricula manipulardatos = new Matricula();//instancia de la clase
        String idalumno;//variable de la cedula
        Boolean consulta;
        public ConsultaMatricula()
        {
            InitializeComponent();
            consulta = false;
        }

        private void ConsultaMatricula_Load(object sender, EventArgs e)
        {
            Matricula objeto = new Matricula();
            objeto.actualizargrid(this.dataGridView, "select*from Matricula");//nombre de la tabla de la data
        }



      

        private void tx_escribir_id_KeyUp(object sender, KeyEventArgs e)
        {
            manipulardatos.actualizargrid(this.dataGridView, "select*from Matricula where idalumno like '" + tx_escribir_id.Text + "%';");
        }
    }
}

    


