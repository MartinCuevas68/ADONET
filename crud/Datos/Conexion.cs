using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace crud.Datos
{
    public class Conexion
    {

        protected SqlConnection cnn;

        protected void Conectar()
        {
            try
            {
                cnn = new  SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Samuel\source\repos\crud\crud\App_Data\crud.mdf;Integrated Security=True");
                cnn.Open();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        
        }

        protected void Desconectar()
        {
            try
            {
                cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Samuel\source\repos\crud\crud\App_Data\crud.mdf;Integrated Security=True");
                cnn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

        }

    }
}