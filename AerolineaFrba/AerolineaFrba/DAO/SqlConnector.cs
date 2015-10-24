﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Text.RegularExpressions;


namespace AerolineaFrba.DAO
{
    public class SqlConnector
    {
        private static SqlConnection connection;
        private static SqlCommand command;

        private string infoConexion()
        {
            return @"Data Source=localhost;Initial Catalog=GD2C2015; User Id=gd; Password=gd2015";
        }

        /*Abre la conexion con la base*/
        public static void conexion(SqlConnection conn, SqlCommand command)
        {
            try
            {
                SqlConnector conexion = new SqlConnector();
                String info = conexion.infoConexion();
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
            List<string> argumentos = generarParametros(procedure);
            return _retrieveDataTable(procedure, argumentos, parametros);
        }


        private static DataTable _retrieveDataTable(string procedure,List<string> argumentos,object[] parametros)
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
            catch
            {
                return null;
            }

            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }    
        }

        
        private static List<string> generarParametros(string procedure)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            SqlDataReader dataReader;
            DataTable dataTable = new DataTable();
            List<string> argumentos = new List<string>();
            try
            {
                conexion(connection, command);
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT PARAMETER_NAME FROM information_schema.parameters WHERE SPECIFIC_SCHEMA='SMALL' AND SPECIFIC_NAME='" + procedure + "'";
                dataReader = command.ExecuteReader();
                dataTable.Load(dataReader);
                foreach (DataRow d in dataTable.Rows)
                {
                    argumentos.Add(d[0].ToString());
                }
                return argumentos;
            }
            catch
            {
                return null;
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
            List<string> argumentos = generarParametros(procedure);
            ejecutarProcedure(procedure, argumentos, parametros);
        }


        public static void ejecutarProcedure(string procedure)
        {
            ejecutarProcedure(procedure, null, null);
        }


        public static bool checkIfExists(string procedure, params object[] parametros)
        {
            List<string> argumentos = generarParametros(procedure);
            return _verSiExiste(procedure, argumentos, parametros);
        }
       

        public static bool verSiExiste(string procedure)
        {
            return _verSiExiste(procedure, null, null);
        }
        

        public static int ejecutarProcedureRetornaValor(string procedure, params object[] values)
        {
            List<string> argumentos = generarParametros(procedure);
            return _executeProcedureWithReturnValue(procedure, argumentos, values);
        }


        private static void ejecutarProcedure(string procedure, List<string> args, params object[] values)
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


        private static bool _verSiExiste(string procedure, List<string> argumentos, params object[] parametros)
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


        private static int _executeProcedureWithReturnValue(string procedure, List<string> argumentos, params object[] parametros)
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
        
        private static bool chequearParametros(List<string> argumentos, params object[] parametros)
        {
            //todo ver si hay que validar aca o en la clase que llame al metodo....
            if (argumentos != null && parametros != null)
            {
                if (argumentos.Count != parametros.Length)
                {
                    throw new ApplicationException();
                }
                return true;
            }
            return false;
        }

        private static void cargarComandosSql(List<string> argumentos, object[] parametros, SqlCommand command)
        {
            for (int i = 0; i < argumentos.Count; i++)
            {
                command.Parameters.AddWithValue(argumentos[i], parametros[i]);
            }
        }
    }
}