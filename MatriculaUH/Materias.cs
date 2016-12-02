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
    public partial class Materias : Form
    {
        Materia manipulardatos = new Materia();
        String codmateria;
        Boolean editar;
        public Materias()
        {
            InitializeComponent();
        }

        private void bn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Materias_Load(object sender, EventArgs e)
        {
            editar = false;
            Materia objeto = new Materia();
            objeto.actualizargrid(this.dataGridView1, "select*from Materia");//nombre de la tabla de la data
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
                String query = "update Materia set codmateria=" + tx_codigo.Text + ", nombre='" + tx_materia.Text + "',cupo=" + tx_cupo.Text + "'where codmateria=" + codmateria + ";";
                //llmar al metdo
                manipulardatos.ejecutarsql(query);
                //actualizar
                manipulardatos.actualizargrid(this.dataGridView1, "select*from Materia");
                //desconectar
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
                String query = "insert into Materia(codmateria,nombre,cupo)values(" + tx_codigo.Text + ",'" + tx_materia.Text + "'," + tx_cupo.Text + ");";
                //ejecutar la query
                manipulardatos.ejecutarsql(query);
                //actualizamos el data
                manipulardatos.actualizargrid(this.dataGridView1, "select*from Materia");
                //desconectar
                manipulardatos.desconectar();
                //limpiar los textbox
                limpiartext();


            }
        }
        public void limpiartext()
        {
           tx_codigo.Clear();
            tx_cupo.Clear();
            tx_materia.Clear();
        



        }

        private void bn_eliminar_Click(object sender, EventArgs e)
        {
            //capturar la cedula
          codmateria = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //preguntar si realmente quiere eliminar
            var resultado = MessageBox.Show("¿Desea realmente eliminar el registro?", "Confirme el borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                //vamos a eliminar
                //conectar a la base de datos
                manipulardatos.conectar();
                //armar sentencia de borrado
                String query = "delete from Materia where codmateria= '" + codmateria + "';";
                //ejecutar la query
                manipulardatos.ejecutarsql(query);
                //actualizar el data
                manipulardatos.actualizargrid(this.dataGridView1, "select*from Materia;");
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

