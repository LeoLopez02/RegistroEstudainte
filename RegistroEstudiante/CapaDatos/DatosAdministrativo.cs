using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DatosAdministrativo
    {
        public int IdAdministrativo { get; set; }
        public string Nombre { get; set; }
        public string  Apellido { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Cedula { get; set; }
        public string Genero { get; set; }
        public string Condicion_Medica { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public string Correo_Electronico { get; set; }
        public string Nacionalidad { get; set; }
        public string Titulo { get; set; }
        public string Estatus { get; set; }
        public string Funcion { get; set; }
        public string TextoBuscar { get; set; }
        
        //Constructor
        public DatosAdministrativo()
        {

        }

        //Constructor
        public DatosAdministrativo(int idadministrativo, string nombre, string apellido, string telefono, string direccion, string cedula, string genero, string condicion_medica, DateTime fecha_nacimiento, DateTime fecha_ingreso, string correo_electronico, string nacionalidad, string titulo, string estatus, string funcion)
        {
            this.IdAdministrativo = idadministrativo;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Telefono = telefono;
            this.Direccion = direccion;
            this.Cedula = cedula;
            this.Genero = genero;
            this.Condicion_Medica = condicion_medica;
            this.Fecha_Nacimiento = fecha_nacimiento;
            this.Fecha_Ingreso = fecha_ingreso;
            this.Correo_Electronico = correo_electronico;
            this.Nacionalidad = nacionalidad;
            this.Titulo = titulo;
            this.Estatus = estatus;
            this.Funcion = funcion;
        }

        //Metodos
        public string Insertar(DatosAdministrativo Administrativo)
        {
            string Respuesta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand Comando = new SqlCommand();
                Comando.Connection = SqlCon;
                Comando.CommandText = "SP_InsertarAdministrativo";
                Comando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParametroIdAdministrativo = new SqlParameter();
                ParametroIdAdministrativo.ParameterName = "@IdAdministrativo";
                ParametroIdAdministrativo.SqlDbType = SqlDbType.Int;
                ParametroIdAdministrativo.Direction = ParameterDirection.Output;
                Comando.Parameters.Add(ParametroIdAdministrativo);

                SqlParameter ParametroNombre = new SqlParameter();
                ParametroNombre.ParameterName = "@Nombre";
                ParametroNombre.SqlDbType = SqlDbType.NVarChar;
                ParametroNombre.Size = 30;
                ParametroNombre.Value = Administrativo.Nombre;
                Comando.Parameters.Add(ParametroNombre);

                SqlParameter ParametroApellido = new SqlParameter();
                ParametroApellido.ParameterName = "@Apellido";
                ParametroApellido.SqlDbType = SqlDbType.NVarChar;
                ParametroApellido.Size = 30;
                ParametroApellido.Value = Administrativo.Apellido;
                Comando.Parameters.Add(ParametroApellido);

                SqlParameter ParametroTelefono = new SqlParameter();
                ParametroTelefono.ParameterName = "@Telefono";
                ParametroTelefono.SqlDbType = SqlDbType.NVarChar;
                ParametroTelefono.Size = 12;
                ParametroTelefono.Value = Administrativo.Telefono;
                Comando.Parameters.Add(ParametroTelefono);

                SqlParameter ParametroDireccion = new SqlParameter();
                ParametroDireccion.ParameterName = "@Direccion";
                ParametroDireccion.SqlDbType = SqlDbType.NVarChar;
                ParametroDireccion.Size = 50;
                ParametroDireccion.Value = Administrativo.Direccion;
                Comando.Parameters.Add(ParametroDireccion);

                SqlParameter ParametroCedula = new SqlParameter();
                ParametroCedula.ParameterName = "@Cedula";
                ParametroCedula.SqlDbType = SqlDbType.NVarChar;
                ParametroCedula.Size = 13;
                ParametroCedula.Value = Administrativo.Cedula;
                Comando.Parameters.Add(ParametroCedula);

                SqlParameter ParametroGenero = new SqlParameter();
                ParametroGenero.ParameterName = "@Genero";
                ParametroGenero.SqlDbType = SqlDbType.NVarChar;
                ParametroGenero.Size = 1;
                ParametroGenero.Value = Administrativo.Genero;
                Comando.Parameters.Add(ParametroGenero);

                SqlParameter ParametroCondicion_Medica = new SqlParameter();
                ParametroCondicion_Medica.ParameterName = "@Condicion_Medica";
                ParametroCondicion_Medica.SqlDbType = SqlDbType.NVarChar;
                ParametroCondicion_Medica.Size = 50;
                ParametroCondicion_Medica.Value = Administrativo.Condicion_Medica;
                Comando.Parameters.Add(ParametroCondicion_Medica);

                SqlParameter ParametroFecha_Nacimiento = new SqlParameter();
                ParametroFecha_Nacimiento.ParameterName = "@Fecha_Nacimiento";
                ParametroFecha_Nacimiento.SqlDbType = SqlDbType.DateTime;
                ParametroFecha_Nacimiento.Value = Administrativo.Fecha_Nacimiento;
                Comando.Parameters.Add(ParametroFecha_Nacimiento);

                SqlParameter ParametroFecha_Ingreso = new SqlParameter();
                ParametroFecha_Ingreso.ParameterName = "@Fecha_Ingreso";
                ParametroFecha_Ingreso.SqlDbType = SqlDbType.DateTime;
                ParametroFecha_Ingreso.Value = Administrativo.Fecha_Ingreso;
                Comando.Parameters.Add(ParametroFecha_Ingreso);

                SqlParameter ParametroCorreo_Electronico = new SqlParameter();
                ParametroCorreo_Electronico.ParameterName = "@Correo_Electronico";
                ParametroCorreo_Electronico.SqlDbType = SqlDbType.NVarChar;
                ParametroCorreo_Electronico.Size = 30;
                ParametroCorreo_Electronico.Value = Administrativo.Correo_Electronico;
                Comando.Parameters.Add(ParametroCorreo_Electronico);

                SqlParameter ParametroNacionalidad = new SqlParameter();
                ParametroNacionalidad.ParameterName = "@Nacionalidad";
                ParametroNacionalidad.SqlDbType = SqlDbType.NVarChar;
                ParametroNacionalidad.Size = 30;
                ParametroNacionalidad.Value = Administrativo.Nacionalidad;
                Comando.Parameters.Add(ParametroNacionalidad);

                SqlParameter ParametroTitulo = new SqlParameter();
                ParametroTitulo.ParameterName = "@Titulo";
                ParametroTitulo.SqlDbType = SqlDbType.NVarChar;
                ParametroTitulo.Size = 30;
                ParametroTitulo.Value = Administrativo.Titulo;
                Comando.Parameters.Add(ParametroTitulo);

                SqlParameter ParametroEstatus = new SqlParameter();
                ParametroEstatus.ParameterName = "@Estatus";
                ParametroEstatus.SqlDbType = SqlDbType.NVarChar;
                ParametroEstatus.Size = 30;
                ParametroEstatus.Value = Administrativo.Estatus;
                Comando.Parameters.Add(ParametroEstatus);

                SqlParameter ParametroFuncion = new SqlParameter();
                ParametroFuncion.ParameterName = "@Funcion";
                ParametroFuncion.SqlDbType = SqlDbType.NVarChar;
                ParametroFuncion.Size = 30;
                ParametroFuncion.Value = Administrativo.Funcion;
                Comando.Parameters.Add(ParametroFuncion);

                //Ejecutamos nuestro comando
                Respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se insertó correctamente el registro.";
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message + ex.StackTrace + " Insertar CapaDatos Administrativo.";
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
            return Respuesta;
        }

        public string Editar(DatosAdministrativo Administrativo)
        {
            string Respuesta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand Comando = new SqlCommand();
                Comando.Connection = SqlCon;
                Comando.CommandText = "SP_EditarAdministrativo";
                Comando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParametroIdAdministrativo = new SqlParameter();
                ParametroIdAdministrativo.ParameterName = "@IdAdministrativo";
                ParametroIdAdministrativo.SqlDbType = SqlDbType.Int;
                ParametroIdAdministrativo.Value = Administrativo.IdAdministrativo;
                Comando.Parameters.Add(ParametroIdAdministrativo);

                SqlParameter ParametroNombre = new SqlParameter();
                ParametroNombre.ParameterName = "@Nombre";
                ParametroNombre.SqlDbType = SqlDbType.NVarChar;
                ParametroNombre.Size = 30;
                ParametroNombre.Value = Administrativo.Nombre;
                Comando.Parameters.Add(ParametroNombre);

                SqlParameter ParametroApellido = new SqlParameter();
                ParametroApellido.ParameterName = "@Apellido";
                ParametroApellido.SqlDbType = SqlDbType.NVarChar;
                ParametroApellido.Size = 30;
                ParametroApellido.Value = Administrativo.Apellido;
                Comando.Parameters.Add(ParametroApellido);

                SqlParameter ParametroTelefono = new SqlParameter();
                ParametroTelefono.ParameterName = "@Telefono";
                ParametroTelefono.SqlDbType = SqlDbType.NVarChar;
                ParametroTelefono.Size = 12;
                ParametroTelefono.Value = Administrativo.Telefono;
                Comando.Parameters.Add(ParametroTelefono);

                SqlParameter ParametroDireccion = new SqlParameter();
                ParametroDireccion.ParameterName = "@Direccion";
                ParametroDireccion.SqlDbType = SqlDbType.NVarChar;
                ParametroDireccion.Size = 50;
                ParametroDireccion.Value = Administrativo.Direccion;
                Comando.Parameters.Add(ParametroDireccion);

                SqlParameter ParametroCedula = new SqlParameter();
                ParametroCedula.ParameterName = "@Cedula";
                ParametroCedula.SqlDbType = SqlDbType.NVarChar;
                ParametroCedula.Size = 13;
                ParametroCedula.Value = Administrativo.Cedula;
                Comando.Parameters.Add(ParametroCedula);

                SqlParameter ParametroGenero = new SqlParameter();
                ParametroGenero.ParameterName = "@Genero";
                ParametroGenero.SqlDbType = SqlDbType.NVarChar;
                ParametroGenero.Size = 1;
                ParametroGenero.Value = Administrativo.Genero;
                Comando.Parameters.Add(ParametroGenero);

                SqlParameter ParametroCondicion_Medica = new SqlParameter();
                ParametroCondicion_Medica.ParameterName = "@Condicion_Medica";
                ParametroCondicion_Medica.SqlDbType = SqlDbType.NVarChar;
                ParametroCondicion_Medica.Size = 50;
                ParametroCondicion_Medica.Value = Administrativo.Condicion_Medica;
                Comando.Parameters.Add(ParametroCondicion_Medica);

                SqlParameter ParametroFecha_Nacimiento = new SqlParameter();
                ParametroFecha_Nacimiento.ParameterName = "@Fecha_Nacimiento";
                ParametroFecha_Nacimiento.SqlDbType = SqlDbType.DateTime;
                ParametroFecha_Nacimiento.Value = Administrativo.Fecha_Nacimiento;
                Comando.Parameters.Add(ParametroFecha_Nacimiento);

                SqlParameter ParametroFecha_Ingreso = new SqlParameter();
                ParametroFecha_Ingreso.ParameterName = "@Fecha_Ingreso";
                ParametroFecha_Ingreso.SqlDbType = SqlDbType.DateTime;
                ParametroFecha_Ingreso.Value = Administrativo.Fecha_Ingreso;
                Comando.Parameters.Add(ParametroFecha_Ingreso);

                SqlParameter ParametroCorreo_Electronico = new SqlParameter();
                ParametroCorreo_Electronico.ParameterName = "@Correo_Electronico";
                ParametroCorreo_Electronico.SqlDbType = SqlDbType.NVarChar;
                ParametroCorreo_Electronico.Size = 30;
                ParametroCorreo_Electronico.Value = Administrativo.Correo_Electronico;
                Comando.Parameters.Add(ParametroCorreo_Electronico);

                SqlParameter ParametroNacionalidad = new SqlParameter();
                ParametroNacionalidad.ParameterName = "@Nacionalidad";
                ParametroNacionalidad.SqlDbType = SqlDbType.NVarChar;
                ParametroNacionalidad.Size = 30;
                ParametroNacionalidad.Value = Administrativo.Nacionalidad;
                Comando.Parameters.Add(ParametroNacionalidad);

                SqlParameter ParametroTitulo = new SqlParameter();
                ParametroTitulo.ParameterName = "@Titulo";
                ParametroTitulo.SqlDbType = SqlDbType.NVarChar;
                ParametroTitulo.Size = 30;
                ParametroTitulo.Value = Administrativo.Titulo;
                Comando.Parameters.Add(ParametroTitulo);

                SqlParameter ParametroEstatus = new SqlParameter();
                ParametroEstatus.ParameterName = "@Estatus";
                ParametroEstatus.SqlDbType = SqlDbType.NVarChar;
                ParametroEstatus.Size = 30;
                ParametroEstatus.Value = Administrativo.Estatus;
                Comando.Parameters.Add(ParametroEstatus);

                SqlParameter ParametroFuncion = new SqlParameter();
                ParametroFuncion.ParameterName = "@Funcion";
                ParametroFuncion.SqlDbType = SqlDbType.NVarChar;
                ParametroFuncion.Size = 30;
                ParametroFuncion.Value = Administrativo.Funcion;
                Comando.Parameters.Add(ParametroFuncion);

                //Ejecutamos nuestro comando
                Respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se actualizó correctamente el registro.";
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message + ex.StackTrace + " Editar CapaDatos Administrativo.";
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
            return Respuesta;
        }


        public string Eliminar(DatosAdministrativo Administrativo)
        {
            string Respuesta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand Comando = new SqlCommand();
                Comando.Connection = SqlCon;
                Comando.CommandText = "SP_EliminarAdministrativo";
                Comando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParametroIdAdministrativo = new SqlParameter();
                ParametroIdAdministrativo.ParameterName = "@IdAdministrativo";
                ParametroIdAdministrativo.SqlDbType = SqlDbType.Int;
                ParametroIdAdministrativo.Value = Administrativo.IdAdministrativo;
                Comando.Parameters.Add(ParametroIdAdministrativo);
                
                //Ejecutamos nuestro comando
                Respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se eliminó correctamente el registro.";
                
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message + ex.StackTrace + " Eliminar CapaDatos Administrativo.";
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
            return Respuesta;
        }

        //METODO MOSTRAR
        public DataTable Mostrar()
        {
            DataTable DataTableResultado = new DataTable("Administrativo");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo Fuente
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand Command = new SqlCommand();
                Command.Connection = SqlCon;
                Command.CommandText = "SP_MostrarAdministrativo";
                Command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SQLAdapter = new SqlDataAdapter(Command);
                SQLAdapter.Fill(DataTableResultado);

            }
            catch (Exception)
            {
                DataTableResultado = null;
            }
            return DataTableResultado;
        }

        public DataTable BuscarNombre(DatosAdministrativo Administrativo)
        {
            DataTable DataTableResult = new DataTable("Administrativo");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo Fuente
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand Command = new SqlCommand();
                Command.Connection = SqlCon;
                Command.CommandText = "SP_BuscarApellidoAdministrativo";
                Command.CommandType = CommandType.StoredProcedure;

                SqlParameter ParametroBuscarNombre = new SqlParameter();
                ParametroBuscarNombre.ParameterName = "@textobuscar";
                ParametroBuscarNombre.SqlDbType = SqlDbType.VarChar;
                ParametroBuscarNombre.Size = 20;
                ParametroBuscarNombre.Value = Administrativo.TextoBuscar;
                Command.Parameters.Add(ParametroBuscarNombre);

                SqlDataAdapter SQLAdapter = new SqlDataAdapter();
                SQLAdapter.Fill(DataTableResult);

                //Ejecutamos nuestro comando

            }
            catch (Exception)
            {
                DataTableResult = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return DataTableResult;
        }

        public DataTable BuscarCedula(DatosAdministrativo Administrativo)
        {
            DataTable DataTableResult = new DataTable("Administrativo");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo Fuente
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand Command = new SqlCommand();
                Command.Connection = SqlCon;
                Command.CommandText = "SP_BuscarCedulaAdministrativo";
                Command.CommandType = CommandType.StoredProcedure;

                SqlParameter ParametroBuscarCedula = new SqlParameter();
                ParametroBuscarCedula.ParameterName = "@textobuscar";
                ParametroBuscarCedula.SqlDbType = SqlDbType.VarChar;
                ParametroBuscarCedula.Size = 20;
                ParametroBuscarCedula.Value = Administrativo.TextoBuscar;
                Command.Parameters.Add(ParametroBuscarCedula);

                SqlDataAdapter SQLAdapter = new SqlDataAdapter();
                SQLAdapter.Fill(DataTableResult);

                //Ejecutamos nuestro comando

            }
            catch (Exception)
            {
                DataTableResult = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return DataTableResult;
        }

    }
}
