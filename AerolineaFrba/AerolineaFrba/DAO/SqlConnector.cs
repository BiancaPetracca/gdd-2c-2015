using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Text.RegularExpressions;


namespace AerolineaFrba.DAO
{
    public static class SqlConnector
    {


        private static string infoConexion()
        {
            return @"Data Source=NICO-PC\SQLSERVER2012 ; Initial Catalog=GD2C2015; User Id=gd; Password=gd2015";
        }

        /*Abre la conexion con la base*/
        public static void conexion(SqlConnection conn, SqlCommand command)
        {
            try
            {
                
                String info = infoConexion();
                conn.ConnectionString = info;
                command.Connection = conn;
                conn.Open();
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }        
        
        public static DataTable retrieveDataTable(string procedure, params object[] parametros)
        {
            string[] argumentos = generarParametros(procedure);
            return _retrieveDataTable(procedure, argumentos, parametros);
        }
     
        
        private static DataTable _retrieveDataTable(string procedure,string[] argumentos,object[] parametros)
        {
 	        SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            SqlDataReader dataReader;
            DataTable dataTable = new DataTable();

            try
            {
                conexion(connection, command);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "AWANTA." + procedure;
                if (chequearParametros(argumentos, parametros))
                {
                    cargarComandosSql(argumentos, parametros, command);
                }
                dataReader = command.ExecuteReader();
                dataTable.Load(dataReader);
                return dataTable;
            }
            catch(SqlException e)
            {
                throw e;
            }

            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }    
        }


        
        private static string[] generarParametros(string procedure)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            SqlDataReader dataReader;
            DataTable dataTable = new DataTable();

            try
            {
                conexion(connection, command);
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT PARAMETER_NAME FROM information_schema.parameters WHERE SPECIFIC_SCHEMA='AWANTA' AND SPECIFIC_NAME='" + procedure + "'";
                dataReader = command.ExecuteReader();
                dataTable.Load(dataReader);
                string[] argumentos = new string[dataTable.Rows.Count];
                int i = 0;
                foreach (DataRow d in dataTable.Rows)
                {
                    
                    argumentos[i] = (d[0].ToString());
                    i++;
                }
                return argumentos;
            }
            catch(SqlException e)
            {
                throw e;
            }

            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
       

        public static void ejecutarProcedure(string procedure, params object[] parametros)
        {
            string[] argumentos = generarParametros(procedure);
            ejecutarProcedure(procedure, argumentos, parametros);
        }


        public static void ejecutarProcedure(string procedure)
        {
            ejecutarProcedure(procedure, null, null);
        }


        public static bool checkIfExists(string procedure, params object[] parametros)
        {
            string[] argumentos = generarParametros(procedure);
            return _verSiExiste(procedure, argumentos, parametros);
        }
       

        public static bool verSiExiste(string procedure)
        {
            return _verSiExiste(procedure, null, null);
        }
        

        public static int ejecutarProcedureRetornaValor(string procedure, params object[] values)
        {
            string[] argumentos = generarParametros(procedure);
            return _executeProcedureWithReturnValue(procedure, argumentos, values);
        }


        private static void ejecutarProcedure(string procedure, string[] args, params object[] values)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();


            try
            {
                conexion(connection, command);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "AWANTA." + procedure;
                if (chequearParametros(args, values))
                {
                    cargarComandosSql(args, values, command);
                }
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }


        private static bool _verSiExiste(string procedure, string[] argumentos, params object[] parametros)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            SqlDataReader dataReader;
            DataTable dataTable = new DataTable();

            try
            {
                conexion(connection, command);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "AWANTA." + procedure;
                if (chequearParametros(argumentos, parametros))
                {
                    cargarComandosSql(argumentos, parametros, command);
                }
                dataReader = command.ExecuteReader();
                return dataReader.HasRows;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }


        private static int _executeProcedureWithReturnValue(string procedure, string[] argumentos, params object[] parametros)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();


            try
            {
                conexion(connection, command);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "AWANTA." + procedure;
                if (chequearParametros(argumentos, parametros))
                {
                    cargarComandosSql(argumentos, parametros, command);
                }
                command.Parameters.Add("@RETURN_VALUE", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                command.ExecuteNonQuery();
                return (int)command.Parameters["@RETURN_VALUE"].Value;
            }
            catch
            {
                return -1;
            }

            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        private static bool chequearParametros(string[] argumentos, params object[] parametros)
        {
            //todo ver si hay que validar aca o en la clase que llame al metodo....
            if (argumentos != null && parametros != null)
            {
                if (argumentos.Length != parametros.Length)
                {
                    throw new ApplicationException();
                }
                return true;
            }
            return false;
        }

        private static void cargarComandosSql(string[] argumentos, object[] parametros, SqlCommand command)
        {
            for (int i = 0; i < argumentos.Length; i++)
            {
                command.Parameters.AddWithValue(argumentos[i], parametros[i]);
            }
        }
    }
}
