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

            /*SqlConnection connect = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connect;
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable datatable = new DataTable();*/

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


    }
}
