using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using ERA_Manager.Models;

namespace ERA_Manager.Repositories
{
    public class StudentRepository
    {
        public static Student GetStudent(int id)
        {
            Student student = null;
            string sql = $"SELECT * FROM Students WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                //student = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return student;
        }
    }
}
