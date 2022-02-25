using CarInsurance.cs.Models;
using CarInsurance.cs.ViewModles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.cs.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var table = db.Tables.ToList();
                var signupVms = new List<QuotesVm>();
                foreach (var Tables in table)
                {
                    var signupVm = new QuotesVm();
                    signupVm.Id = Tables.Id;
                    signupVm.FirstName = Tables.FirstName;
                    signupVm.LastName = Tables.LastName;
                    signupVm.EmailAdress = Tables.EmailAddress;
                    signupVm.Quote = Tables.Quote;
                    signupVms.Add(signupVm);
                }
                return View(signupVms);
            }
        }
    }
}