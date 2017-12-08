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
        public PartialViewResult Filter()
        {
            return PartialView(db);
        }

        [HttpPost]
        public ActionResult Search(string gia, string quanhuyen, string loaida, string phongtam, string phongngu, string baidauxe)
        {

            IEnumerable<PPC_Rental_2017.Models.PROPERTY> vc;

            if (gia == "Dưới 50000")
            {
                vc = db.PROPERTies.ToList().Where(x => (x.Price < 50000 && gia != "Giá") || (x.DISTRICT.DistrictName == quanhuyen && quanhuyen != "Quận/Huyện") || (x.BathRoom.ToString() == phongtam && phongtam != "Phòng tắm") || (x.BedRoom.ToString() == phongngu && phongngu != "Phòng ngủ") || (x.PackingPlace.ToString() == baidauxe && baidauxe != "Bãi đậu xe"));
            }
            else if (gia == "Từ 50000-100000")
            {
                vc = db.PROPERTies.ToList().Where(x => (x.Price >= 50000 && x.Price < 100000 && gia != "Giá") || (x.DISTRICT.DistrictName == quanhuyen && quanhuyen != "Quận/Huyện") || (x.BathRoom.ToString() == phongtam && phongtam != "Phòng tắm") || (x.BedRoom.ToString() == phongngu && phongngu != "Phòng ngủ") || (x.PackingPlace.ToString() == baidauxe && baidauxe != "Bãi đậu xe"));
            }
            else if (gia == "Từ 100000-150000")
            {
                vc = db.PROPERTies.ToList().Where(x => (x.Price >= 100000 && x.Price < 150000 && gia != "Giá") || (x.DISTRICT.DistrictName == quanhuyen && quanhuyen != "Quận/Huyện")  || (x.BathRoom.ToString() == phongtam && phongtam != "Phòng tắm") || (x.BedRoom.ToString() == phongngu && phongngu != "Phòng ngủ") || (x.PackingPlace.ToString() == baidauxe && baidauxe != "Bãi đậu xe"));
            }
            else
            {
                vc = db.PROPERTies.ToList().Where(x => (x.Price >= 150000 && gia != "Giá") || (x.DISTRICT.DistrictName == quanhuyen && quanhuyen != "Quận/Huyện")  || (x.BathRoom.ToString() == phongtam && phongtam != "Phòng tắm") || (x.BedRoom.ToString() == phongngu && phongngu != "Phòng ngủ") || (x.PackingPlace.ToString() == baidauxe && baidauxe != "Bãi đậu xe"));
            }

            return View(vc);
        }
    }
}