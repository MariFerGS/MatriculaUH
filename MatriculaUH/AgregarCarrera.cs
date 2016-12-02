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
    public partial class AgregarCarrera : Form
    {
        Carreras manipulardatos = new Carreras();
        String idcarrera;
        Boolean editar;
        public AgregarCarrera()
        {
            InitializeComponent();
            tx_id.Enabled = true;
        }

        private void AgregarCarrera_Load(object sender, EventArgs e)
        {
            editar = false;
           Carreras objeto = new Carreras();
            objeto.actualizargrid(this.dataGridView1, "select*from Carrera");//nombre de la tabla de la data
        }

        private void bn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bn_guardar_Click(object sender, EventArgs e)
        {
            //este boton tiene dos funciones, guardar en la base de datos o actualizar en la base de datos
            if (editar)
            {
                manipulardatos.conectar();
                //si es int solo doble comilla
                //la cedula no se toca
                //codigo captura la cedula
                String query = "update Carrera set nombre='" + tx_carrera.Text + "' where idcarrera=" + idcarrera + ";";
                //llmar al metdo
                manipulardatos.ejecutarsql(query);
                //actualizar
                manipulardatos.actualizargrid(this.dataGridView1, "select*from Carrera");
                //desconectar
                manipulardatos.desconectar();
                //limpiar texts
                this.limpiartext();
                //cambiar el estado de la bandera
                editar = false;
                tx_id.Enabled = true;
            }
            else
            {
                //conectar la base de datos
                manipulardatos.conectar();
                //armar variable tipo cadena"query"
                String query = "insert into Carrera(nombre,idcarrera)values('" + tx_carrera.Text + "'," + tx_id.Text + ");";
                //ejecutar la query
                manipulardatos.ejecutarsql(query);
                //actualizamos el data
                manipulardatos.actualizargrid(this.dataGridView1, "select*from Carrera");
                //desconectar
                manipulardatos.desconectar();
                //limpiar los textbox
                limpiartext();
            }

            }
             public void limpiartext()
        {
            tx_id.Clear();
            tx_carrera.Clear();
         


        }

        private void bn_actualizar_Click(object sender, EventArgs e)
        {
            editar = true;
            tx_id.Enabled = false;
            //capturar datos de la base y ponerlos en los textbox conforme a los campos del data
            idcarrera = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tx_carrera.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
      
        }

        private void tx_escribir_carrera_KeyUp(object sender, KeyEventArgs e)
        {
            manipulardatos.actualizargrid(this.dataGridView1, "select*from Carrera where nombre like '" + tx_escribir_carrera.Text + "%';");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Materias frm = new Materias(); //objeto creado
            
            frm.Show(); //muestra formulario de materias alumno
        }
    }
    }
    

