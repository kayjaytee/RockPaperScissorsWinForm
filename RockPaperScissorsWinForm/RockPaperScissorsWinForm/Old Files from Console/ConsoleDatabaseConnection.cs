using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsWinForm
{
    public class User
    {
        public User
        (long userID,
        string username,
        string firstName,
        string lastName,
        string userEmail,
        string passwordHash,
        string token,
        DateTime? tokenIssued)
        {
            UserID = userID;
            Username = username;
            FirstName = firstName;
            LastName = lastName;
            UserEmail = userEmail;
            PasswordHash = passwordHash;
            Token = token;
            TokenIssued = tokenIssued;

        }

        public long? UserID { get; set; } = null;
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserEmail { get; set; }
        public string PasswordHash { get; set; }
        public string Token { get; set; }
        public DateTime? TokenIssued { get; set; }
        public long Wins { get; set; }
        public long Losses { get; set; }
        public long GamesPlayed { get; set; }

        private static string baseSelectSQL => "select [UserID], [Username], [FirstName], [LastName], [UserEmail], [PasswordHash], [Token], [TokenIssued], [Wins], [Losses], [GamesPlayed] from [User] ";

        public static string SqlAll()
        {
            return baseSelectSQL;
        }

        public static (string, List<SqlParameter>) SqlLogin(string username, string passwordhash)
        {
            List<SqlParameter> parameterValues = new List<SqlParameter>();
            parameterValues.Add(ConsoleDatabaseConnection.GetParameter("@username", username));
            parameterValues.Add(ConsoleDatabaseConnection.GetParameter("@passwordhash", passwordhash));
            string selectSql = baseSelectSQL + " where Username = @username and Passwordhash = @passwordhash";
            return (selectSql, parameterValues);
        }
        public static (string, List<SqlParameter>) SqlUser(string username, string passwordhash = null)
        {
            string sql = baseSelectSQL + " where Username = @username";
            List<SqlParameter> parameterValues = new List<SqlParameter>();
            parameterValues.Add(new SqlParameter("@username", username));
            if (string.IsNullOrEmpty(passwordhash) == false)
            {
                parameterValues.Add(new SqlParameter("@passwordHash", passwordhash));
                sql = sql + " and passwordHash = @passwordHash";
            }
            return (sql, parameterValues);
        }
        public static (string, List<SqlParameter>) SqlAdd(User user)
        {
            List<SqlParameter> parameterValues = new List<SqlParameter>();
            parameterValues.Add(ConsoleDatabaseConnection.GetParameter("@Username", user.Username));
            parameterValues.Add(ConsoleDatabaseConnection.GetParameter("@FirstName", user.FirstName));
            parameterValues.Add(ConsoleDatabaseConnection.GetParameter("@LastName", user.LastName));
            parameterValues.Add(ConsoleDatabaseConnection.GetParameter("@UserEmail", user.UserEmail));
            parameterValues.Add(ConsoleDatabaseConnection.GetParameter("@PasswordHash", user.PasswordHash));
            parameterValues.Add(ConsoleDatabaseConnection.GetParameter("@Token", "NA"));
            parameterValues.Add(ConsoleDatabaseConnection.GetParameter("@TokenIssued", "2000-01-01"));
            parameterValues.Add(ConsoleDatabaseConnection.GetParameter("@Wins", 0));
            parameterValues.Add(ConsoleDatabaseConnection.GetParameter("@Losses", 0));
            parameterValues.Add(ConsoleDatabaseConnection.GetParameter("@GamesPlayed", 0));

            return (@"insert into [User]
                  ([Username],[FirstName],[LastName],[PasswordHash],[Token],[TokenIssued],[Wins],[Losses],[GamesPlayed])
                   values (@Username,@FirstName,@LastName,@PasswordHash,@Token,@TokenIssued,@Wins,@Losses,@GamesPlayed)",
                   parameterValues);
        }

    }
    public class ConsoleDatabaseConnection
    {
        public string ConnectionString { get; }

        public ConsoleDatabaseConnection(string connectionString)
        {
            ConnectionString = connectionString;
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

        # region Run Query
        public List<T> RunQuery<T>(string sql, List<SqlParameter> parameters = null)
        {
            Type itemType = typeof(T);

            List<T> list = new List<T>();
            using (SqlConnection mySqlConnection = new SqlConnection(ConnectionString))
            {
                mySqlConnection.Open();

                using (SqlCommand cmd = mySqlConnection.CreateCommand())
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

                    mySqlConnection.Close();

                }
            }

            return list;
        }
        public List<T> RunQuery<T>((string, List<SqlParameter>) parameters)
        {
            return RunQuery<T>(parameters.Item1, parameters.Item2);
        }
        #endregion Run Query

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
        #endregion None Query

    }


}
