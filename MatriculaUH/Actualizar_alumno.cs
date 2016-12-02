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
    public partial class Actualizar_alumno : Form
    {
        Alumnonew manipulardatos = new Alumnonew();//instancia de la clase
        String cedula;//variable de la cedula
        Boolean editar;
        public Actualizar_alumno()
        {
            InitializeComponent();
            tx_apellido.Enabled = false;
            tx_cedula.Enabled = false;
            tx_nombre.Enabled = false;
        }

        private void Actualizar_alumno_Load(object sender, EventArgs e)
        {
            editar = false;
            Alumnonew objeto = new Alumnonew();
            objeto.actualizargrid(this.dataGridView, "select*from Alumno");//nombre de la tabla de la data
        }

        private void bn_guardar_Click(object sender, EventArgs e)
        {
            //el boton guarda en la BD
            if (editar)
            {
                manipulardatos.conectar();


                String query = "update Alumno set nombre='" + tx_nombre.Text + "', apellido='" + tx_apellido.Text + "' where cedula=" + cedula + ";";
                //llmar al metdo
                manipulardatos.ejecutarsql(query);
                //actualizar el data y la base
                manipulardatos.actualizargrid(this.dataGridView, "select*from Alumno");
                //desconectar l BD
                manipulardatos.desconectar();
                //limpiar texts
                this.limpiartext();
                //cambiar el estado de la bandera
                editar = false;

            }
            else
            {
                //conectar la base de datos
                manipulardatos.conectar();
                //armar variable tipo cadena"query"
                String query = "insert into Alumno(cedula,nombre,apellido)values(" + tx_cedula.Text + ",'" + tx_nombre.Text + "','" + tx_apellido.Text + "');";
                //ejecutar la query
                manipulardatos.ejecutarsql(query);
                //actualizamos el data
                manipulardatos.actualizargrid(this.dataGridView, "select*from Alumno");
                //desconectamos la bd
                manipulardatos.desconectar();
                //limpiar los textbox
                limpiartext();


            }
        }
        public void limpiartext()
        {//metodo que limpia los textbox

            tx_apellido.Clear();
            tx_cedula.Clear();
            tx_escribir_nombre.Clear();
            tx_nombre.Clear();



        }

        private void tx_escribir_nombre_KeyUp(object sender, KeyEventArgs e)
        {
            manipulardatos.actualizargrid(this.dataGridView, "select*from Alumno where Nombre like '" + tx_escribir_nombre.Text + "%';");
        }

        private void bn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bn_actualizar_Click(object sender, EventArgs e)
        {
            editar = true;
            tx_apellido.Enabled = true;
            tx_nombre.Enabled = true;
            tx_cedula.Enabled = false;
            //capturar datos de la base y ponerlos en los textbox conforme a los campos del data
            cedula = this.dataGridView.CurrentRow.Cells[0].Value.ToString();
            tx_nombre.Text = this.dataGridView.CurrentRow.Cells[1].Value.ToString();
            tx_apellido.Text = this.dataGridView.CurrentRow.Cells[2].Value.ToString();
           
        }
    }
}
