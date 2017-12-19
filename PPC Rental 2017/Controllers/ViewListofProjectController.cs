using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PPC_Rental_2017.Models;

namespace PPC_Rental_2017.Controllers
{
    public class ViewListofProjectController : Controller
    {
        team15Entities m = new team15Entities();
        // GET: ViewListofProject
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Unapproved(string status= "Chưa duyệt")
        {
            var viewlist = m.PROPERTies.Where(p => p.PROJECT_STATUS.Status_Name == status).ToList();
            return View(viewlist);
        }
        public ActionResult SaveDrafts(string status = "Lưu nháp")
        {
            var viewlist = m.PROPERTies.Where(p => p.PROJECT_STATUS.Status_Name == status).ToList();
            return View(viewlist);
        }
    }
}