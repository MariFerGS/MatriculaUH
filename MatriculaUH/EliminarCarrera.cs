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
    public partial class EliminarCarrera : Form
    {
       Carreras manipulardatos = new Carreras();//instancia de la clase
        String idcarrera;//variable de la cedula
        public EliminarCarrera()
        {
            InitializeComponent();
        }

        private void EliminarCarrera_Load(object sender, EventArgs e)
        {
            Carreras objeto = new Carreras();
            objeto.actualizargrid(this.dataGridView1, "select*from Carrera");//nombre de la tabla de la data

        }

        private void tx_escribir_carrera_KeyUp(object sender, KeyEventArgs e)
        {
            manipulardatos.actualizargrid(this.dataGridView1, "select*from Carrera where idcarrera like '" + tx_escribir_carrera.Text + "%';");
        }

        private void bn_eliminar_Click(object sender, EventArgs e)
        {
            //capturar la cedula
            idcarrera = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //preguntar si realmente quiere eliminar
            var resultado = MessageBox.Show("¿Desea realmente eliminar el registro?", "Confirme el borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                //vamos a eliminar
                //conectar a la base de datos
                manipulardatos.conectar();
                //armar sentencia de borrado
                String query = "delete from Carrera where idcarrera= '" + idcarrera + "';";
                //ejecutar la query
                manipulardatos.ejecutarsql(query);
                //actualizar el data
                manipulardatos.actualizargrid(this.dataGridView1, "select*from Carrera;");
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

