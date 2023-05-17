using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hospital_Management_System.Models
{
    public class PatientDetails
    {
        [Key]
        public int RegId { get; set; }
        public string PatientFname { get; set;}
        public string PatientLname { get; set;}
        public int PhoneNum { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public int AdharNum { get; set; }
        public string Speciality { get; set; }
    }
}
