using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using PPC_Rental_2017.Controllers;
using PPCRental2017.AcceptanceTests.Support;
using PPC_Rental_2017.Models;
using TechTalk.SpecFlow;

namespace PPCRental2017.AcceptanceTests.Drivers.PostProject
{
    public class PostProjectDriver
    {
        private ActionResult _result;
        private PostProjectController _controller;
        private readonly CatalogContext _context;
        public PostProjectDriver(CatalogContext context)
        {
            _context = context;
        }
        public void InsertProjecttoDB(Table givenProjects)
        {
            using (var db = new team15Entities())
            {
                foreach (var row in givenProjects.Rows)
                {
                    var property = new PROPERTY
                    {
                        PropertyName = row["PropertyName"],
                        Content = row["Content"],
                        PropertyType_ID = db.PROPERTY_TYPE.ToList().FirstOrDefault(d => d.CodeType == row["CodeType"]).ID,
                        Street_ID = db.STREETs.ToList().FirstOrDefault(d => d.StreetName == row["Street"]).ID,
                        Ward_ID = db.WARDs.ToList().FirstOrDefault(d => d.WardName == row["Ward"]).ID,
                        District_ID = db.DISTRICTs.ToList().FirstOrDefault(d => d.DistrictName == row["District"]).ID,
                        Price = int.Parse(row["Price"]),
                        UnitPrice = row["UnitPrice"],
                        Area = row["Area"],
                        BedRoom = int.Parse(row["BedRoom"]),
                        BathRoom = int.Parse(row["BathRoom"]),
                        PackingPlace = int.Parse(row["PackingPlace"]),
                        UserID = int.Parse(row["UserID"]),
                        Status_ID = db.PROJECT_STATUS.ToList().FirstOrDefault(x => x.Status_Name == row["Status"]).ID,
                        Note = row["Note"]
                    };

                    _context.ReferenceProject.Add(
                        givenProjects.Header.Contains("Id") ? row["Id"] : property.PropertyName,
                        property);

                    db.PROPERTies.Add(property);
                }

                db.SaveChanges();
            }
        }
        public void NavigateCreateBook()
        {
            _result = _controller.PostProject();
        }
        public void CreateProperty(Table inputproperty)
        {
            var row = inputproperty.Rows[0];
            using (var db = new team15Entities())
            {
                var property = new PROPERTY
                {
                    PropertyName = row["PropertyName"],
                    Content = row["Content"],
                    PropertyType_ID = db.PROPERTY_TYPE.ToList().FirstOrDefault(d => d.CodeType == row["Property Type"]).ID,
                    Street_ID = db.STREETs.ToList().FirstOrDefault(d => d.StreetName == row["Street"]).ID,
                    Ward_ID = db.WARDs.ToList().FirstOrDefault(d => d.WardName == row["Ward"]).ID,
                    District_ID = db.DISTRICTs.ToList().FirstOrDefault(d => d.DistrictName == row["District"]).ID,
                    Price = int.Parse(row["Price"]),
                    UnitPrice = row["UnitPrice"],
                    Area = row["Area"],
                    BedRoom = int.Parse(row["BedRoom"]),
                    BathRoom = int.Parse(row["BathRoom"]),
                    PackingPlace = int.Parse(row["PackingPlace"]),
                    UserID = int.Parse(row["UserID"]),
                    Status_ID = db.PROJECT_STATUS.ToList().FirstOrDefault(x => x.Status_Name == row["Status"]).ID,
                };

                //Save book item into ScenarioContext object so that we can get it in the next step (UploadImage)
                ScenarioContext.Current.Add("property", property);

                //Save the create action into ScenarioContext object so that we can get it in the next step (UploadImage)
                ScenarioContext.Current.Add("isCreated", "Y");
                //_result = _controller.Create(book);
            }
        }
    }
}
