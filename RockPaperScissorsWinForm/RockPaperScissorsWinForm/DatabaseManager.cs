using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsWinForm
{

    //Börjat jobba här på en seperat SQLconnection klass

    internal class DatabaseManager
    {
        public string ConnectionString { get; }

        public DatabaseManager(string connectionString)
        {
            ConnectionString = connectionString;
            connectionString = "Server=localhost;Database=RockPaperScissor;Trusted_Connection=True";
        }

        public DatabaseManager()
        {

            SqlConnection connect = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connect;
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable datatable = new DataTable();

        }

        public static SqlParameter GetParameter(string parameterName, object parameterValue)
        {
            SqlParameter parameterObject = new SqlParameter
            (
                parameterName, parameterValue == null ? DBNull.Value : parameterValue
            );

            parameterObject.Direction = ParameterDirection.Input;
            return parameterObject;

        }

        #region Run Query
        public List<T> RunQuery<T>(string sql, List<SqlParameter> parameters = null)
        {
            Type itemType = typeof(T);

            List<T> list = new List<T>();
            using (SqlConnection connect = new SqlConnection(ConnectionString))
            {
                connect.Open();

                using (SqlCommand cmd = connect.CreateCommand())
                {

                    cmd.CommandText = sql;

                    if (parameters != null)
                        foreach (var pm in parameters)
                            cmd.Parameters.Add(pm);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        int cols = reader.FieldCount;
                        while (reader.Read())
                        {
                            object[] item = new object[reader.FieldCount];
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                var objectType = reader[i].GetType();
                                item[i] = Convert.ChangeType(reader[i], objectType);
                            }
                            list.Add((T)Activator.CreateInstance(itemType, item));
                        }
                    }

                    connect.Close();

                }
            }

            return list;
        }
        public List<T> RunQuery<T>((string, List<SqlParameter>) parameters)
        {
            return RunQuery<T>(parameters.Item1, parameters.Item2);
        }
        
        #endregion

        #region None Query
        public int ExecuteNoneQuery((string, List<SqlParameter>) parameters)
        {
            return ExecuteNoneQuery(parameters.Item1, parameters.Item2);
        }

        public int ExecuteNoneQuery(string sql, List<SqlParameter> sqlParameters)
        {
            int returnValue = -1;

            try
            {
                using (SqlConnection mySqlConnection = new SqlConnection(ConnectionString))
                {
                    mySqlConnection.Open();
                    using (SqlCommand cmd = mySqlConnection.CreateCommand())
                    {
                        cmd.CommandText = sql;
                        cmd.Parameters.AddRange(sqlParameters.ToArray());
                        returnValue = cmd.ExecuteNonQuery();
                    }
                    mySqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in ExecuteNonQuery:");
                throw;
            }

            return returnValue;

        }
        #endregion
    }
}
