using System;
using System.Collections.Generic;
using Hospital_Management_System.Models;

namespace Hospital_Management_System.HospitalServices
{
    public class hospitalServices
    {
        private List<PatientDetails> patientDetails; 

        public hospitalServices()
        {
            patientDetails = new List<PatientDetails>();
        }


        public void add(PatientDetails patient)
        {
            if (patientDetails.Contains(patient))
            {
                Console.WriteLine("Patient already exist !");
            }
            else
            {
                patientDetails.Add(patient);
                Console.WriteLine("You are successfully Registred ...");
            }
        }

        public List<PatientDetails> getPatient()
        {
            return patientDetails;
        }

        public PatientDetails getById(int id)
        {
            return patientDetails.Find(p => p.RegId == id);
        }

        public void Update(PatientDetails updatedPatient)
        {
            PatientDetails patient = patientDetails.Find(p => p.RegId == updatedPatient.RegId);
            if (patient != null)
            {
                //patient.RegId = updatedPatient.RegId;
                patient.PatientFname = updatedPatient.PatientFname;
                patient.PatientLname = updatedPatient.PatientLname;
                patient.PhoneNum = updatedPatient.PhoneNum;
                patient.Address = updatedPatient.Address;
                patient.AdharNum = updatedPatient.AdharNum;
                patient.Speciality = updatedPatient.Speciality;
                patient.Gender = updatedPatient.Gender;
                patient.Age = updatedPatient.Age;
            }
            else
            {
                Console.WriteLine("Patient not found!");
            }
        }
        public void Delete(int id)
        {
            PatientDetails patient = patientDetails.Find(p => p.RegId==id);
            if (patient != null)
            {
                patientDetails.Remove(patient);
            }
            else
            {
                Console.WriteLine("Patient Dosn't exist !");
            }
        }
        
    }
}
