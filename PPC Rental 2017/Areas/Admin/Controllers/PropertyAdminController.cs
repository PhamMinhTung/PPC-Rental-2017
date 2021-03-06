﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PPC_Rental_2017.Models;
using System.IO;

namespace PPC_Rental_2017.Areas.Admin.Controllers
{
    public class PropertyAdminController : Controller
    {
        team15Entities read = new team15Entities();
        // GET: Admin/PropertyAdmin
        public ActionResult Index()
        {
            var property = read.PROPERTies.OrderByDescending(x => x.ID).ToList();
            return View(property);
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            var propertys = read.PROPERTies.FirstOrDefault(x => x.ID == id);
            return View(propertys);


        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var product = read.PROPERTies.FirstOrDefault(x => x.ID == id);
            ViewBag.proprety_type = read.PROPERTY_TYPE.OrderByDescending(x => x.ID).ToList();
            ViewBag.street = read.STREETs.OrderByDescending(x => x.ID).ToList();
            ViewBag.ward = read.WARDs.OrderByDescending(x => x.ID).ToList();
            ViewBag.dictrict = read.DISTRICTs.OrderByDescending(x => x.ID).ToList();
            //ViewBag.user = read.USERs.OrderByDescending(x => x.ID).ToList();
            ViewBag.project_status = read.PROJECT_STATUS.OrderByDescending(x => x.ID).ToList();
            return View(product);
        }
        [HttpPost]
        public ActionResult Edit(int id, PROPERTY p, PROPERTY proprety, HttpPostedFileBase Avatar, HttpPostedFileBase Image)
        {
            string avatar = "";
            if (Avatar.ContentLength > 0)
            {

                var filenameav = Path.GetFileName(Avatar.FileName);
                var path = Path.Combine(Server.MapPath("~/Image"), filenameav);
                Avatar.SaveAs(path);
                avatar = filenameav;
            }
            string image = "";
            if (Image.ContentLength > 0)
            {
                var filename = Path.GetFileName(Image.FileName);
                var path = Path.Combine(Server.MapPath("~/Image"), filename);
                Image.SaveAs(path);
                image = filename;
            }
            var property = read.PROPERTies.FirstOrDefault(x => x.ID == id);
            property.PropertyName = p.PropertyName;
            property.Avatar = p.Avatar;
            property.Images = p.Images;
            property.PropertyType_ID = p.PropertyType_ID;
            property.Content = p.Content;
            property.Street_ID = p.Street_ID;
            property.Ward_ID = p.Ward_ID;
            property.District_ID = p.District_ID;
            property.Price = p.Price;
            property.UnitPrice = p.UnitPrice;
            property.Area = p.Area;
            property.BedRoom = p.BedRoom;
            property.BathRoom = p.BathRoom;
            property.PackingPlace = p.PackingPlace;
            property.UserID = p.UserID;
            property.Created_at = p.Created_at;
            property.Create_post = p.Create_post;
            property.Status_ID = p.Status_ID;
            property.Note = p.Note;
            property.Updated_at = DateTime.Now;
            read.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var property = read.PROPERTies.FirstOrDefault(x => x.ID == id);
            return View(property);
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            var property = read.PROPERTies.FirstOrDefault(x => x.ID == id);
            read.PROPERTies.Remove(property);
            read.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult News()
        {
            var news = read.News_and_Events.ToList();
            return View(news);
        }

        [HttpGet]
        public ActionResult editnews(int id)
        {
            var news = read.News_and_Events.Find(id);
            return View(news);
        }

        [HttpPost]
        public ActionResult editnews(News_and_Events model, HttpPostedFileBase Avatar)
        {
            News_and_Events n = read.News_and_Events.Find(model.ID);

            if (Avatar != null)
            {
                string avatar = "";
                if (Avatar.ContentLength > 0)
                {
                    var filename = Path.GetFileName(Avatar.FileName);
                    var path = Path.Combine(Server.MapPath("~/Images/News/"), filename);
                    Avatar.SaveAs(path);
                    avatar = filename;
                }
                n.Images = avatar;
            }
            n.Title = model.Title;
            n.ShortDescription = model.ShortDescription;

            read.Entry(n).State = System.Data.Entity.EntityState.Modified;
            read.SaveChanges();
            return RedirectToAction("News");
        }

        [HttpGet]
        public ActionResult addnews(int id)
        {
            var news = read.News_and_Events.Find(id);
            return View(news);
        }

        [HttpPost]
        public ActionResult addnews(News_and_Events model, HttpPostedFileBase Avatar)
        {
            News_and_Events n = read.News_and_Events.Find(model.ID);

            if (Avatar != null)
            {
                string avatar = "";
                if (Avatar.ContentLength > 0)
                {
                    var filename = Path.GetFileName(Avatar.FileName);
                    var path = Path.Combine(Server.MapPath("~/Images/News/"), filename);
                    Avatar.SaveAs(path);
                    avatar = filename;
                }
                model.Images = avatar;
            }

           
            read.News_and_Events.Add(model);
            read.SaveChanges();
            return RedirectToAction("News");
        }
        [HttpGet]
        public ActionResult About()
        {
            var about = read.ABOUT_US.ToList();
            return View(about);
        }

        [HttpGet]
        public ActionResult editabout(int id)
        {
            ABOUT_US edit = read.ABOUT_US.Find(id);
            return View(edit);
        }

        [HttpPost]
        public ActionResult editabout(ABOUT_US model)
        {
            ABOUT_US ab = read.ABOUT_US.Find(model.ID);
            ab.Title = model.Title;
            ab.Images = model.Images;
            ab.About = model.About;
            ab.Sponsor = model.Sponsor;
            ab.Developer = model.Developer;

            read.Entry(ab).State = System.Data.Entity.EntityState.Modified;
            read.SaveChanges();
            return RedirectToAction("About");   
        }
    }
}
