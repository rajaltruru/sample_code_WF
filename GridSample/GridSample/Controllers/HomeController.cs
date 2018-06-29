using GridSample.Models;
using GridSample.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GridSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ContactDetails contact = new ContactDetails();
            List<ContactDetails> lstcontact = new List<ContactDetails>();
            DataTable dtcontact = ContactRepository.GetContactsDetails();
            foreach(DataRow dr in dtcontact.Rows)
            {
                lstcontact.Add(new ContactDetails
                {
                    ID = Convert.ToInt32(dr["ID"]),
                    FirstName = Convert.ToString(dr["FirstName"]),
                    Lastname = Convert.ToString(dr["LastName"]),
                    Address = Convert.ToString(dr["Address"]),
                    Phone = Convert.ToString(dr["Phone"])
                });
            }
            return View(lstcontact);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}