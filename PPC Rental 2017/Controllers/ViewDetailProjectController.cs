using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PPC_Rental_2017.Models;

namespace PPC_Rental.Controllers
{
    public class ViewDetailProjectController : Controller
    {
        team15Entities db = new team15Entities();
        // GET: ViewDetailProject
        public ActionResult ViewDetailProject(int id)
        {
            var project = db.PROPERTies.FirstOrDefault(t => t.ID == id);
            return View(project);
        }
    }
}