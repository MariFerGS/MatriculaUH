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
    public partial class NuevaMatricula : Form
    {
        Matricula manipulardatos = new Matricula();
        String idmatricula;
        Boolean editar;
        public NuevaMatricula()
        {
            InitializeComponent();
            tx_idmatricula.Enabled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void NuevaMatricula_Load(object sender, EventArgs e)
        {
            editar = false;
            Matricula objeto = new Matricula();
            objeto.actualizargrid(this.dataGridView1, "select*from Matricula");//nombre de la tabla de la data
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
                String query = "update Matricula set idalumno=" + tx_idalumno.Text + ", idcarrera=" + tx_idcarrera.Text + ",idmateria=" + tx_idmateria.Text + ",fechamatricula='" + dt_fecha.Text + "'where idmatricula=" + idmatricula + ";";
                //llmar al metdo
                manipulardatos.ejecutarsql(query);
                //actualizar
                manipulardatos.actualizargrid(this.dataGridView1, "select*from Matricula");
                //desconectar
                manipulardatos.desconectar();
                //limpiar texts
                this.limpiartext();
                //cambiar el estado de la bandera
                editar = false;
                tx_idmatricula.Enabled = true;
            }
            else
            {
                //conectar la base de datos
                manipulardatos.conectar();
                //armar variable tipo cadena"query"
                String query = "insert into Matricula(idalumno,idcarrera,idmateria,idmatricula,fechamatricula)values(" + tx_idalumno.Text + "," + tx_idcarrera.Text + "," + tx_idmateria.Text + "," + tx_idmatricula.Text + ",'" + dt_fecha.Text + "');";
                //ejecutar la query
                manipulardatos.ejecutarsql(query);
                //actualizamos el data
                manipulardatos.actualizargrid(this.dataGridView1, "select*from Matricula");
                //desconectar
                manipulardatos.desconectar();
                //limpiar los textbox
                limpiartext();


            }
        }
        public void limpiartext()
        {
            tx_idmatricula.Clear();
            tx_idmateria.Clear();
            tx_idcarrera.Clear();
            tx_idalumno.Clear();



        }

       

        private void bn_eliminar_Click(object sender, EventArgs e)
        {
            //capturar la cedula
            idmatricula = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //preguntar si realmente quiere eliminar
            var resultado = MessageBox.Show("¿Desea realmente eliminar el registro?", "Confirme el borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                //vamos a eliminar
                //conectar a la base de datos
                manipulardatos.conectar();
                //armar sentencia de borrado
                String query = "delete from Matricula where idmatricula= '" + idmatricula + "';";
                //ejecutar la query
                manipulardatos.ejecutarsql(query);
                //actualizar el data
                manipulardatos.actualizargrid(this.dataGridView1, "select*from Matricula;");
                //desconectar la base
                manipulardatos.desconectar();
            }
            //no confirmo el borrado
            else
            {
                return;

            }
        }

        private void bn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    }


