using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DBLayer;

namespace ERA_Manager.Models
{
    public class Validation
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Motivation { get; set; }
        public string Preference { get; set; }
        public string PossibleDestinations { get; set; }
        public string ValidatedBy { get; set; }

    }
}
