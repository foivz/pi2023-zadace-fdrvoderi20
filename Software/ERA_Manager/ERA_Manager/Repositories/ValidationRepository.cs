using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBLayer;
using ERA_Manager.Models;

namespace ERA_Manager.Repositories
{
    public class ValidationRepository
    {
        public static void ValidateStudent(string firstname,string lastname,string motivation,string preference,string possibleDestinations,string validator, int id)
        {
            //string sql1 = $"UPDATE Validation SET FirstName = '{firstname}', LastName = '{lastname}', Motivation = '{motivation}', Preference = '{preference}', PossibleDestinations = '{possibleDestinations}', ValidatedBy = '{validator}' WHERE StudentID = '{id}'";
            string sql1 = $"INSERT INTO Validation (FirstName, LastName, Motivation, Preference, PossibleDestinations, ValidatedBy, StudentID) VALUES ('{firstname}', '{lastname}', '{motivation}', '{preference}', '{possibleDestinations}', '{validator}', '{id}')";
            string sql2 = $"DELETE FROM Students WHERE Id='{id}'";
            string sql3 = $"DELETE FROM Person WHERE Id='{id}'";
            DB.OpenConnection();
            DB.ExecuteCommand(sql1);
            DB.ExecuteCommand(sql2);
            DB.ExecuteCommand(sql3);
            DB.CloseConnection();
        }

        public static List<Validation> GetValidatedStudents()
        {
            List<Validation> students = new List<Validation>();
            string sql = "SELECT * FROM Validation";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Validation student = CreateValidObject(reader);
                students.Add(student);
            }
            reader.Close();
            DB.CloseConnection();
            return students;
        }

        private static Validation CreateValidObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string firstName = reader["FirstName"].ToString();
            string lastName = reader["LastName"].ToString();
            string motivation = reader["Motivation"].ToString();
            string preference = reader["Preference"].ToString();
            string possibleDestinations = reader["PossibleDestinations"].ToString();
            string validator = reader["ValidatedBy"].ToString();
            int studentId = int.Parse(reader["StudentID"].ToString());
            var student = new Validation
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Motivation = motivation,
                Preference = preference,
                PossibleDestinations = possibleDestinations,
                ValidatedBy = validator,
                StudentID = studentId

            };
            return student;
        }

        public static void DeleteValidatedStudent(int id) {

            string sql = $"DELETE FROM Validation WHERE StudentID ='{id}'";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }


    }
}
