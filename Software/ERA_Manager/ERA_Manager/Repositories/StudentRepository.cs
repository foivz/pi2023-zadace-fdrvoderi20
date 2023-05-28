using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using ERA_Manager.Models;

namespace ERA_Manager.Repositories
{
    public class StudentRepository
    {

        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            string sql = "SELECT * FROM Students INNER JOIN Person ON Students.Id = Person.Id";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Student student = CreateObject(reader);
                students.Add(student);
            }
            reader.Close();
            DB.CloseConnection();
            return students;
        }

        private static Student CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string firstName = reader["FirstName"].ToString();
            string lastName = reader["LastName"].ToString();
            string motivation = reader["Motivation"].ToString();
            string preference = reader["Preference"].ToString();
            var student = new Student
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Motivation = motivation,
                Preference = preference
            };
            return student;
        }

        public static List<Student> SearchStudent(string search)
        { 
            List<Student> students = new List<Student>();
            string sql = $"SELECT * FROM Students INNER JOIN Person ON Students.Id = Person.Id WHERE Preference like '%{search}%'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Student student = CreateObject(reader);
                students.Add(student);
            }
            reader.Close();
            DB.CloseConnection();
            return students;
        }
        public static void AddStudent(string firstname, string lastname, string motivation, string preference)
        {
            string sql1 = $"INSERT INTO Students (Motivation, Preference) VALUES ('{motivation}', '{preference}')";
            string sql2 = $"INSERT INTO Person (FirstName, LastName) VALUES ('{firstname}', '{lastname}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql2);
            DB.ExecuteCommand(sql1);
            DB.CloseConnection();
        }

        public static void UpdateStudent(string firstname, string lastname, string motivation, string preference, int id) {
            string sql1 = $"UPDATE Person SET FirstName = '{firstname}', LastName='{lastname}' WHERE Id = '{id}'";
            string sql2 = $"UPDATE Students SET Motivation = '{motivation}', Preference='{preference}' WHERE Id = '{id}'";
            DB.OpenConnection();
            DB.ExecuteCommand(sql1);
            DB.ExecuteCommand(sql2);
            DB.CloseConnection();
        }
    }
}
