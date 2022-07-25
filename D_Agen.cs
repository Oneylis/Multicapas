using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Entidad;
using System.Data;

namespace Datos
{
    public class D_Agen
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conect"].ConnectionString);

        public List<E_Agen> ListarAgenda(String buscar)
        {
            SqlDataReader leerfilas;
            SqlCommand cmd = new SqlCommand("SP_BuscarAgenda", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Buscar", buscar);
            leerfilas = cmd.ExecuteReader();

            List<E_Agen> Listar = new List<E_Agen>();
            while (leerfilas.Read())
            {
                Listar.Add(new E_Agen
                {
                    Nombre = leerfilas.GetString(0),
                    Apellido = leerfilas.GetString(1),
                    Telefono = leerfilas.GetString(2),
                    Genero = leerfilas.GetString(3),
                    Estado_Civil = leerfilas.GetString(4),
                    Direccion = leerfilas.GetString(5),
                    Correo = leerfilas.GetString(6)
                });
                  
            }
            conexion.Close();
            leerfilas.Close();
            return Listar;
        }
        public void Insertaragenda(E_Agen Agenda)
        {
            SqlCommand cmd = new SqlCommand("SP_InsertarAgenda", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Nombre", Agenda.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", Agenda.Apellido);
            cmd.Parameters.AddWithValue("@Telefono", Agenda.Telefono);
            cmd.Parameters.AddWithValue("@Genero", Agenda.Genero);
            cmd.Parameters.AddWithValue("@Estado_Civil", Agenda.Estado_Civil);
            cmd.Parameters.AddWithValue("@Direccion", Agenda.Direccion);
            cmd.Parameters.AddWithValue("@correo", Agenda.Correo);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void EditarAgenda(E_Agen Agenda)
        {
            SqlCommand cmd = new SqlCommand("SP_ModificarAgenda", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Nombre", Agenda.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", Agenda.Apellido);
            cmd.Parameters.AddWithValue("@Telefono", Agenda.Telefono);
            cmd.Parameters.AddWithValue("@Genero", Agenda.Genero);
            cmd.Parameters.AddWithValue("@Estado_Civil", Agenda.Estado_Civil);
            cmd.Parameters.AddWithValue("@Direccion", Agenda.Direccion);
            cmd.Parameters.AddWithValue("@correo", Agenda.Correo);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void EliminarAgenda(E_Agen Agenda)
        {
            SqlCommand cmd = new SqlCommand("SP_EliminarAgenda", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Nombre", Agenda.Nombre);
           
            cmd.ExecuteNonQuery();
            conexion.Close();


        }
    }

}
