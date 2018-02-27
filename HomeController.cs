using App_Hospital.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App_Hospital.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        HospitalDBEntities DB;
        PatientOperation operations;
        /// <summary>
        /// Get All Patient 
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            DB = new HospitalDBEntities();
            return View(DB.tbl_Patients.ToList());
        }
        /// <summary>
        /// Open Create Patient Page without parameter
        /// </summary>
        /// <returns></returns>
        public ActionResult CreatePatient()
        {
            return View();
        }

        /// <summary>
        /// Save Patient Data When Click On Register Button
        /// </summary>
        /// <param name="Fname"></param>
        /// <param name="Lname"></param>
        /// <param name="Address"></param>
        /// <param name="DateBirth"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult SavePatientData(string Fname,string Lname,string Address,string DateBirth)
        {
            operations = new PatientOperation();
           bool Result= operations.SavePatientData(Fname, Lname, Address,DateTime.Parse( DateBirth.ToString()));
           if (Result)
           {
              // string URL = ConfigurationManager.AppSettings["Root"].ToString() + "Home/Index";
               return RedirectToAction("Index");
             // return Json(Result);
           }
           else
           {
               return Json(Result);
           }
        }
    }
}
