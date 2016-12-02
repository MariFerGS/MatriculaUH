using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace MatriculaUH
{
    class Matricula
    {
        //variable de la conexion
        SqlConnection miconexion;
        //metodo de conexion
        public void conectar()
        {

            //instancia el objeto de conexion
            //miconexion = new SqlConnection("Data Source=MAFER;Initial Catalog=MatriUH;Integrated Security=True");
            miconexion = new SqlConnection("Data Source=.;Initial Catalog=MatriUH;Integrated Security=True");
            miconexion.Open();
        }
        //metodo de desconectar al cerrar
        public void desconectar()
        {
            miconexion.Close();
        }

        //metodo para ejecutar
        public void ejecutarsql(String query)
        {
            //objeto de la conexion
            SqlCommand micomando = new SqlCommand(query, miconexion);
            //ejecutamos la consulta SQL

            int filasafectadas = micomando.ExecuteNonQuery();
            //regresa un valor que nos da el numero de filas afectadas
            if (filasafectadas > 0)
            {//si se cambia algo da el mensaje de que se realizó exitosamente
                MessageBox.Show("Operación realizada exitosamente", " Base de datos modificada", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {


            }

        }
        public void actualizargrid(DataGridView dg, String query)
        {//metodo para actualizar el data
            //conectar a la base de datos
            this.conectar();


            //creamos la dataset para actualizar la BD
            System.Data.DataSet midataset = new System.Data.DataSet();

            //intermediario entre la base de datos original y la dataset
            SqlDataAdapter dataadapter = new SqlDataAdapter(query, miconexion);
            //llena el dataset

            dataadapter.Fill(midataset, "Matricula");
            //se asignas propiedades al data
            dg.DataSource = midataset;
            dg.DataMember = "Matricula";
            //se desconecta la base
            this.desconectar();//con el this se llama

        }
    }
}

