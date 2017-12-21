using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PPC_Rental_2017.Models;

namespace PPC_Rental_2017.Controllers
{
    public class HomeController : Controller
    {
        team15Entities db = new team15Entities();
        public ActionResult Index()
        {
            var model = db.PROPERTies.ToList();
            return View(model);
            
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
        [HttpPost]
        public ActionResult Search(string searchtxt, string gia, string quanhuyen, string loaida, string phongtam, string phongngu, string baidauxe)
        {

            IEnumerable<PPC_Rental_2017.Models.PROPERTY> ls;
            var dicGia = new Dictionary<string, string> { { "Dưới 50.000", "0#50000" }, { "Từ 50.000-100.000", "50000#100000" }, { "Từ 100.000-150.000", "100000#150000" }, { "Trên 150.000", "150000#999999999" } };
            if (searchtxt == "")
            {
                if (gia != "Giá")
                {
                    int first = int.Parse(dicGia[gia].Split('#')[0]);
                    int second = int.Parse(dicGia[gia].Split('#')[1]);
                    ls = db.PROPERTies.Where(x => x.Price >= first && x.Price <= second);
                }
                else
                    ls = db.PROPERTies;

                if (phongtam != "Phòng tắm")
                    ls = ls.Where(x => x.BathRoom.ToString() == phongtam);
                if (phongngu != "Phòng ngủ")
                    ls = ls.Where(x => x.BedRoom.ToString() == phongngu);
                if (baidauxe != "Bãi đậu xe")
                    ls = ls.Where(x => x.PackingPlace.ToString() == baidauxe);
                ls = ls.ToList();
            }
            else
            {
                ls = db.PROPERTies.Where(x => x.PropertyName.Trim().ToLower().Contains(searchtxt.Trim().ToLower()));
            }

            return View(ls);

        }
        public PartialViewResult Filter()
        {
            return PartialView(db);
        }
        public ActionResult ViewDetailProject(int id)
        {
            var project = db.PROPERTies.FirstOrDefault(t => t.ID == id);
            return View(project);
        }
     
    }
}