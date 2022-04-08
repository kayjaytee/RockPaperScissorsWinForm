using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsWinForm
{

    //Börjat jobba här på en seperat SQLconnection klass

    internal class DatabaseManager
    {
        public DatabaseManager()
        {
            SqlConnection connect = new SqlConnection();
            connect.ConnectionString = "Server=localhost;Database=RockPaperScissor;Trusted_Connection=True";

        }


    }
}
