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
    public partial class Eliminar_Alumno : Form
    {
        Alumnonew manipulardatos = new Alumnonew();//instancia de la clase
        String cedula;//variable de la cedula
        public Eliminar_Alumno()
        {
            InitializeComponent();
        }

        private void Eliminar_Alumno_Load(object sender, EventArgs e)
        {
            Alumnonew objeto = new Alumnonew();
            objeto.actualizargrid(this.dataGridView, "select*from Alumno");//nombre de la tabla de la data
        }

        private void tx_escribir_nombre_KeyUp(object sender, KeyEventArgs e)
        {
            manipulardatos.actualizargrid(this.dataGridView, "select*from Alumno where Nombre like '" + tx_escribir_nombre.Text + "%';");
        }

        private void bn_eliminar_Click(object sender, EventArgs e)
        {
            //capturar la cedula
            cedula = this.dataGridView.CurrentRow.Cells[0].Value.ToString();
            //preguntar si realmente quiere eliminar
            var resultado = MessageBox.Show("¿Desea realmente eliminar el registro?", "Confirme el borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                //vamos a eliminar
                //conectar a la base de datos
                manipulardatos.conectar();
                //armar sentencia de borrado
                String query = "delete from Alumno where cedula= '" + cedula + "';";
                //ejecutar la query
                manipulardatos.ejecutarsql(query);
                //actualizar el data
                manipulardatos.actualizargrid(this.dataGridView, "select*from Alumno;");
                //desconectar la base
                manipulardatos.desconectar();
            }
            //no confirmo el borrado
            else
            {
                return;

            }
        }
    }
}
 
