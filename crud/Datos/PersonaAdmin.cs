using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace crud.Datos
{
    public class PersonaAdmin:Conexion
    {
        public IEnumerable<Models.PersonaModel> Consultar()
        {
            Conectar();
            List<Models.PersonaModel> lista = new List<Models.PersonaModel>();
            try {

                SqlCommand comando = new SqlCommand("procedure_select", cnn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read()) { 
                    {
                        Models.PersonaModel modelo = new Models.PersonaModel()
                        {

                            id = int.Parse(lector[0].ToString()),
                            Nombre = lector[1] + "",
                            apellido = lector[2] + "",
                            edad = int.Parse(lector[3].ToString()),
                            estatura = float.Parse(lector[4].ToString()),
                            peso = float.Parse(lector[5].ToString()),
                            IMC = float.Parse(lector[6].ToString()),
                            grupo = lector[7] + "",
                        };
                        lista.Add(modelo);

                    }
                
                }
                
            }
            catch (Exception e) {

                Console.WriteLine(e.StackTrace);

            }
            finally
            {
                Desconectar();
            }
            return lista;
        }
    }
}