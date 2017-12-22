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

            int a = int.Parse(Session["UserID"].ToString());
            var viewlist = m.PROPERTies.Where(p => p.PROJECT_STATUS.Status_Name == status && p.UserID == a && p.Status_ID == 1).ToList();
            return View(viewlist);
        }
        public ActionResult SaveDrafts(string status = "Lưu nháp")
        {
            int b = int.Parse(Session["UserID"].ToString());
            var viewlist = m.PROPERTies.Where(p => p.PROJECT_STATUS.Status_Name == status && p.UserID == b && p.Status_ID==2).ToList();
            return View(viewlist);
        }
    }
}