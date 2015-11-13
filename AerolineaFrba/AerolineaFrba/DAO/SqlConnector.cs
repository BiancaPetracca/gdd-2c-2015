﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Text.RegularExpressions;
using System.Configuration;
using AerolineaFrba.Properties;
using System.Web;



namespace AerolineaFrba.DAO
{
    public static class SqlConnector
    {

        private static string infoConexion()
        {
            return Settings.Default.GD2C2015ConnectionString;
            
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
        
        // obtiene la data table resultante de ejecutar el procedure 
        public static DataTable retrieveDataTable(string procedure, params object[] parametros)
        {
            string[] argumentos = generarParametros(procedure);
            return _retrieveDataTable(procedure, argumentos, parametros);
        }




        // METODO QUE OBTIENE LA DATA TABLE RESULTANTE DE EJECUTAR EL STORED PROCEDURE 
        private static void addAllParams(Dictionary<String, Object> parameters, SqlCommand cmd)
        {
            foreach (var param in parameters)
            {
                cmd.Parameters.AddWithValue(param.Key, param.Value);
            }
        }

        // para hacerlo pasando arrays en vez de un diccionario, mas amigable 
        private static void addAllParams(String [] names, Object [] values, SqlCommand cmd)
        {
            names.Zip(values, (key, val) => cmd.Parameters.AddWithValue(key, val));
        }

        public static DataTable retrieveDTToBeConverted(String sp, Dictionary<String, object> parameters) {
   
  
            using (SqlConnection sqlcon = new SqlConnection(infoConexion()))
            {
                using (SqlCommand cmd = new SqlCommand("AWANTA." + sp, sqlcon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (parameters != null)
                    {
                        foreach (var elem in parameters) {
                            cmd.Parameters.AddWithValue(elem.Key, elem.Value);
                        }
                    }
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        sqlcon.Open();
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }

                }
            }
           
        }

        public static DataTable retrieveDTToBeConverted(String sp, String[] names, Object[] values)
        {

            using (SqlConnection sqlcon = new SqlConnection(infoConexion()))
            {
                using (SqlCommand cmd = new SqlCommand("AWANTA." + sp, sqlcon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (names != null)
                    {
                        Dictionary<String, Object> dic = Enumerable.Range(0, names.Length).ToDictionary(i => names[i], i => values[i]);
                        foreach (var elem in dic) {
                            cmd.Parameters.AddWithValue(elem.Key, elem.Value == null ? System.DBNull.Value : elem.Value);
                        }
                    }
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        sqlcon.Open();
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }

                }
            }

        }
        public static void bindNamesToDataTable(DataTable dt, DataGridView dg) {

            for (var i = 0; i < dg.Columns.Count; i++) {
                dg.Columns[i].DataPropertyName = dt.Columns[i].ColumnName;
            }}

        public static void loadWithDataTable(DataTable dt, DataGridView dg){

            dg.DataSource = dt;
          
        
        }

        public static void retrieveDT(DataTable dt, DataGridView dg)
        {
            bindNamesToDataTable(dt, dg);
            dg.DataSource = dt;
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
       
        // ejecuta un procedure
        public static void ejecutarProcedure(string procedure, params object[] parametros)
        {
            string[] argumentos = generarParametros(procedure);
            ejecutarProcedure(procedure, argumentos, parametros);
        }


        public static void ejecutarProcedure(string procedure)
        {
            ejecutarProcedure(procedure, null, null);
        }

        // ejecuta una consulta a partir de un procedure y devuelve si encontró algo o no
        public static bool checkIfExists(string procedure, params object[] parametros)
        {
            string[] argumentos = generarParametros(procedure);
            return _verSiExiste(procedure, argumentos, parametros);
        }
       

        public static bool verSiExiste(string procedure)
        {
            return _verSiExiste(procedure, null, null);
        }
        
        // ejecuta un procedure y devuelve el valor resultante de ejecutarlo
        public static int ejecutarProcedureRetornaValor(string procedure, params object[] values)
        {
            string[] argumentos = generarParametros(procedure);
            return _executeProcedureWithReturnValue(procedure, argumentos, values);
        }

        // ejecuta el procedure dentro de nuestro schema
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
