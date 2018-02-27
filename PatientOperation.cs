using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace App_Hospital.Models
{
    public class PatientOperation
    {
        HospitalDBEntities db = new HospitalDBEntities();
        tbl_Patients patient;
        ADOConnection adoConnection;
        /// <summary>
        /// Save Data EF OR ADO You Have Tow Options You Can Setting From Web Config
        /// </summary>
        /// <param name="FirstName"></param>
        /// <param name="LastName"></param>
        /// <param name="Address"></param>
        /// <param name="DateOfBirth"></param>
        /// <returns></returns>
        public bool SavePatientData(string FirstName, string LastName, string Address, DateTime DateOfBirth)
        {
            bool Results = false;
            string checkConnection = ConfigurationManager.AppSettings["CheckConnection"].ToString().ToUpper();
            if (checkConnection == "ADO")
            {
                adoConnection = new ADOConnection();
                Results=adoConnection.RunInsert(FirstName, LastName, Address, DateOfBirth);
            }
            else
            {
                patient = new tbl_Patients();
                patient.Patient_Fanme = FirstName;
                patient.Patient_Lname = LastName;
                patient.Patient_Address = Address;
                patient.Patient_Date = DateOfBirth;
                patient.Patient_InsertionDateTime = DateTime.Now;
                db.tbl_Patients.Add(patient);
                int result = db.SaveChanges();
                if (result > 0)
                {
                   Results=  true;
                }
                else
                {
                    Results= false;
                }
            }
            return Results;
        }
    }
}