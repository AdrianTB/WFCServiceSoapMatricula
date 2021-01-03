using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

using System.Data.SqlClient;

namespace WFCServiceMatricula
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceMatricula : IServiceMatricula
    {

        SqlConnection cn = new SqlConnection("server=.; database=bd_Matricula; uid=sa; pwd=123456;");



        // FUNCION PARA LISTAR MATRICULAS
        public DataSet ListarMatriculas()
        {

            string storeProcedure = "sp_listar_matriculas";

            SqlDataAdapter adp = new SqlDataAdapter(storeProcedure, cn);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataSet ds = new DataSet();
            adp.Fill(ds);

            return ds;

        }


        // FUNCION PARA REGISTRAR MATRICULAS
        public String RegistrarMatricula(Matricula obj_matricula)
        {

            SqlCommand cmd = new SqlCommand("sp_registrar_matriculas", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nombre", obj_matricula.nombre);
            cmd.Parameters.AddWithValue("@apellido", obj_matricula.apellido);
            cmd.Parameters.AddWithValue("@dni", obj_matricula.dni);
            cmd.Parameters.AddWithValue("@nivel", obj_matricula.nivel);
            cmd.Parameters.AddWithValue("@turno", obj_matricula.turno);
            cmd.Parameters.AddWithValue("@grado", obj_matricula.grado);
            cmd.Parameters.AddWithValue("@seccion", obj_matricula.seccion);
            cmd.Parameters.AddWithValue("@apoderado", obj_matricula.apoderado);
            cmd.Parameters.AddWithValue("@telefono", obj_matricula.telefono);


            cn.Open();

            String estado = "";

            try
            {
                int reg = cmd.ExecuteNonQuery();
                estado = "Matricula Registada";
            }
            catch (SqlException e)
            {
                estado = "Ocurrio un error al intentar registar la matricula -> " + e.Message;
            }

            finally
            {
                cn.Close();
            }

            return estado;


        }



        // FUNCION PARA ACTUALIZAR MATRICULAS
        public String ActualizarMatricula(Matricula obj_matricula)
        {
            SqlCommand cmd = new SqlCommand("sp_actualizar_matriculas", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nombre", obj_matricula.nombre);
            cmd.Parameters.AddWithValue("@apellido", obj_matricula.apellido);
            cmd.Parameters.AddWithValue("@dni", obj_matricula.dni);
            cmd.Parameters.AddWithValue("@nivel", obj_matricula.nivel);
            cmd.Parameters.AddWithValue("@turno", obj_matricula.turno);
            cmd.Parameters.AddWithValue("@grado", obj_matricula.grado);
            cmd.Parameters.AddWithValue("@seccion", obj_matricula.seccion);
            cmd.Parameters.AddWithValue("@apoderado", obj_matricula.apoderado);
            cmd.Parameters.AddWithValue("@telefono", obj_matricula.telefono);

            cmd.Parameters.AddWithValue("@id", obj_matricula.id_matricula);


            cn.Open();

            String estado = "";

            try
            {
                int reg = cmd.ExecuteNonQuery();
                estado = "Matricula Actualizada";
            }
            catch (SqlException e)
            {
                estado = "Error al actualizar la matricula -> " + e.Message;
            }

            finally
            {
                cn.Close();
            }

            return estado;
        }


        // FUNCION PARA BUSCAR POR MATRICULAS
        public DataSet BuscarporMatricula(int id)
        {
            string cadSQL = "sp_buscar_por_id";
            SqlDataAdapter adp = new SqlDataAdapter(cadSQL, cn);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;

            adp.SelectCommand.Parameters.AddWithValue("@id", id);

            DataSet ds = new DataSet();
            adp.Fill(ds);

            return ds;
        }

        // FUNCION PARA ELIMINAR MATRICULAS
        public String EliminarMatricula(Matricula obj_matricula)
        {
            SqlCommand cmd = new SqlCommand("sp_eliminar_matriculas", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id", obj_matricula.id_matricula);

            cn.Open();

            String estado = "";

            try
            {
                int reg = cmd.ExecuteNonQuery();
                estado = "Matricula Eliminada";
            }
            catch (SqlException e)
            {
                estado = "No se pudo eliminar la matricula -> " + e.Message;
            }

            finally
            {
                cn.Close();
            }

            return estado;
        }


     
    }
}
