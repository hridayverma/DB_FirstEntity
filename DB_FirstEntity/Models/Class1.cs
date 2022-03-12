using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DB_FirstEntity.Models
{
    //DTO
    class EmployeeDetails
    {
        //employee poco
        public int EId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        //Address poco
        public string AddressLine { get; set; }
        public string State { get; set; }
        public string City { get; set; }


    }
}