using System;
using System.Collections.Generic;
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
            DB.OpenConnection();
            DB.ExecuteCommand(sql1);
            DB.ExecuteCommand(sql2);
            DB.CloseConnection();
        }
    }
}
