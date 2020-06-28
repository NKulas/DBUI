using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBUI.Data
{
    public static class DataAccess
    {
        public static string ConnectionString { get; set; }

        private static SqlConnection connection;

        private static void openConnection()
        {
            if (ConnectionString == null || ConnectionString == string.Empty) throw new Exception("The connection string has not been set");

            connection = new SqlConnection(ConnectionString);
            try
            {
                connection.Open();
            }
            catch
            {
                throw;
            }
        }

        private static void closeConnection()
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public static bool TestConnection()
        {
            try
            {
                openConnection();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                closeConnection();
            }
        }

        public async static Task<DataTable> QueryAsync(string sql, SqlParameter[] parameters = null)
        {
            Task<DataTable> t = Task.Run(() =>
            {
                return Query(sql, parameters);
            });

            return await t;
        }

        public static DataTable Query(string sql, SqlParameter[] parameters = null)
        {
            try
            {
                openConnection();
                SqlCommand command = new SqlCommand(sql, connection);

                if (parameters != null) command.Parameters.AddRange(parameters);

                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(data);

                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                closeConnection();
            }
        }

        public async static Task<int> NonQueryAsync(string sql, SqlParameter[] parameters = null)
        {
            Task<int> t = Task.Run(() =>
            {
                return NonQuery(sql, parameters);
            });

            return await t;
        }

        public static int NonQuery(string sql, SqlParameter[] parameters = null)
        {
            try
            {
                openConnection();
                SqlCommand command = new SqlCommand(sql, connection);
                if (parameters != null) command.Parameters.AddRange(parameters);

                int rowsChanged = command.ExecuteNonQuery();

                return rowsChanged;
            }
            catch
            {
                throw;
            }
            finally
            {
                closeConnection();
            }
        }
    }
}