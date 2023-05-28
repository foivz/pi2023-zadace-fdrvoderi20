using DBLayer;
using ERA_Manager.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERA_Manager.Repositories
{
    public class EosmMangerRepository
    {

        public static EosmManager GetManager(string username)
        {
            return FetchManager($"SELECT * FROM EosmManager INNER JOIN Person ON EosmManager.Id = Person.Id WHERE Username = '{username}'");
        }

        private static EosmManager FetchManager(string sql)
        {
            EosmManager manager = null;
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                manager = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return manager;
        }

        private static EosmManager CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string firstName = reader["FirstName"].ToString();
            string lastName = reader["LastName"].ToString();
            string username = reader["Username"].ToString();
            string password = reader["Password"].ToString();

            var manager = new EosmManager
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Username = username,
                Password = password
            };
            return manager;
        }
    }
}

