using System;
using System.Collections.Generic;
using Hospital_Management_System.Models;
using Hospital_Management_System.HospitalServices;
using Hospital_Management_System.IhospitalServices;
using System.Numerics;

namespace Hospital_Management_System.UI
{
    public class Program
    {
        private static hospitalServices hservices = new hospitalServices();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Add Patient Details");
                Console.WriteLine("2. Display all Patient Details");
                Console.WriteLine("3. search Paitent by ID");
                Console.WriteLine("4. Update Paitent Details");
                Console.WriteLine("5. Delete Paitnet details");
                Console.WriteLine("6. Exit\n");
                Console.WriteLine("Enter your choice:");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddPatient();
                        break;
                    case 2:
                        ReadAllPatient();
                        break;
                    case 3:
                        ReadPatientrById();
                        break;
                    case 4:
                        updatedPatient();
                        break;
                    case 5:
                        DeletePatient();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }

        private static void AddPatient()
        {
            //Console.WriteLine("Enter player ID:");
            //int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Paitent First Name:");
            string fname = Console.ReadLine();

            Console.WriteLine("Enter Paitent Last name:");
            string lname = Console.ReadLine();

            Console.WriteLine("Enter Patient phone number:");
            int pnumber = (int)Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Enter Patient gender:");
            string gender = Console.ReadLine();

            Console.WriteLine("Enter patient age:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter player Address:");
            string address = Console.ReadLine();

            Console.WriteLine("Enter player Adhar number:");
            int adhar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Speciality to be consulted:");
            string consulted = Console.ReadLine();

            PatientDetails patient = new PatientDetails { /*Id = id,*/ PatientFname = fname, PatientLname = lname,
             PhoneNum= pnumber,Gender=gender,Age = age,Address = address,AdharNum = adhar,Speciality = consulted};
            
            hservices.add(patient);

            Console.WriteLine("Person created successfully!");
        }

        private static void ReadAllPatient()
        {
            var services = hservices.getPatient();

            if (services.Count == 0)
            {
                Console.WriteLine("No Patient found!");
            }
            else
            {
                foreach (var patient in services)
                {
                    Console.WriteLine($"ID: {patient.RegId}, First_Name: {patient.PatientFname}, Last_Name: {patient.PatientLname}, Phone_Number: {patient.PhoneNum}, Gender: {patient.Gender},Age: {patient.Age},Address: {patient.Address},Adhar_number: {patient.AdharNum},Speciality: {patient.Speciality}");
                }
            }
        }

        private static void ReadPatientrById()
        {
            Console.WriteLine("Enter person ID:");
            int id = Convert.ToInt32(Console.ReadLine());

            PatientDetails patient = hservices.getById(id);

            if (patient != null)
            {
                Console.WriteLine($"ID: {patient.RegId}, First_Name: {patient.PatientFname}, Last_Name: {patient.PatientLname}, Phone_Number: {patient.PhoneNum}, Gender: {patient.Gender},Age: {patient.Age},Address: {patient.Address},Adhar_number: {patient.AdharNum},Speciality: {patient.Speciality}");
            }
            else
            {
                Console.WriteLine("Patient not found!");
            }
        }

        private static void updatedPatient()
        {
            Console.WriteLine("Enter Patient ID:");
            int id = Convert.ToInt32(Console.ReadLine());

            PatientDetails existingPatient = hservices.getById(id);

            if (existingPatient != null)
            {
                //Console.WriteLine("Enter player ID:");
                //int id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Paitent First Name:");
                string fname = Console.ReadLine();

                Console.WriteLine("Enter Paitent Last name:");
                string lname = Console.ReadLine();

                Console.WriteLine("Enter Patient phone number:");
                int pnumber = (int)Convert.ToInt64(Console.ReadLine());

                Console.WriteLine("Enter Patient gender:");
                string gender = Console.ReadLine();

                Console.WriteLine("Enter patient age:");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Patient Address:");
                string address = Console.ReadLine();

                Console.WriteLine("Enter Patient Adhar number:");
                int adhar = (int)Convert.ToInt64(Console.ReadLine());

                Console.WriteLine("Enter Speciality to be consulted:");
                string consulted = Console.ReadLine();

                PatientDetails patient = new PatientDetails
                {
                    RegId = id,
                    PatientFname = fname,
                    PatientLname = lname,
                    PhoneNum = pnumber,
                    Gender = gender,
                    Age = age,
                    Address = address,
                    AdharNum = adhar,
                    Speciality = consulted
                };

                hservices.Update(patient);

                Console.WriteLine("Patient updated successfully!");
            }
            else
            {
                Console.WriteLine("Patient not found!");
            }
        }

        private static void DeletePatient()
        {
            Console.WriteLine("Enter player ID:");
            int id = Convert.ToInt32(Console.ReadLine());

            hservices.Delete(id);

            Console.WriteLine("Player deleted successfully!");
        }
    }
}
