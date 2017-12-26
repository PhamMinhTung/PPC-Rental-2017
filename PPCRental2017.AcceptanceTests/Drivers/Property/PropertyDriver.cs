using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPC_Rental_2017.Models;
using PPCRental2017.AcceptanceTests.Support;
using PPC_Rental_2017.Controllers;
using TechTalk.SpecFlow;
using System.Web.Mvc;
using System.Web;
using PPCRental2017.UITests.Selenium;
using PPCRental2017.AcceptanceTests.Common;
using PPC_Rental_2017.Areas.Admin.Controllers;


namespace PPCRental2017.AcceptanceTests.Drivers.Property
{
    public class PropertyDriver
    {
        team15Entities db = new team15Entities();
        team15Entities pd = new team15Entities();
        private readonly CatalogContext _context;
        private ActionResult _result;
        public PropertyDriver(CatalogContext _Context)
        {
            _context = _Context;

        }
        public void NavigateToPostPage()
        {
            team15Entities get = new team15Entities();
            PPC_Rental_2017.Controllers.UsersController user = new UsersController();

            var controller = new PostProjectController();

            var moqContext = new Moq.Mock<ControllerContext>();
            var moqSession = new Moq.Mock<HttpSessionStateBase>();
            moqContext.Setup(c => c.HttpContext.Session).Returns(moqSession.Object);

            var us = get.USERs.FirstOrDefault(x => x.Email == "pet@gmail.com");
        
            controller.ControllerContext = moqContext.Object;
            moqSession.Setup(s => s["UserRole"]).Returns(us.Role);
            moqSession.Setup(s => s["UserID"]).Returns(us.ID);

            _result = controller.PostProject();

        }
        public void InsertPropertyToDB(Table Property)
        {

            using (db)
            {

                foreach (var row in Property.Rows)
                {

                    string propertyID = row["CodeType"];
                    string wardID = row["Ward"];
                    string districtID = row["District"];
                    string streetID = row["Street"];
                    string statusID = row["Status"];
                    var property = new PROPERTY
                    {

                        PropertyName = row["PropertyName"],

                        Ward_ID = db.WARDs.FirstOrDefault(d => d.WardName == wardID).ID,
                        Street_ID = db.STREETs.FirstOrDefault(d => d.StreetName == streetID).ID,
                        District_ID = db.DISTRICTs.FirstOrDefault(d => d.DistrictName == districtID).ID,
    
                        PropertyType_ID = db.PROPERTY_TYPE.FirstOrDefault(d => d.CodeType == propertyID).ID,
                    };

                    _context.ReferenceProject.Add(
                            Property.Header.Contains("ID") ? row["ID"] : property.PropertyName,
                            property);

                    db.PROPERTies.Add(property);
                }


                db.SaveChanges();
            }

        }
        public void CreateProperty(Table Property)
        {
            using (pd)
            {

                foreach (var row in Property.Rows)
                {

                    string propertyID = row["CodeType"];
                    string wardID = row["Ward"];
                    string districtID = row["District"];
                    string streetID = row["Street"];
                    string statusID = row["Status"];
                    var property = new PROPERTY
                    {

                        PropertyName = row["PropertyName"],

                        Ward_ID = pd.WARDs.FirstOrDefault(d => d.WardName == wardID).ID,
                        Street_ID = pd.STREETs.FirstOrDefault(d => d.StreetName == streetID).ID,
                        District_ID = pd.DISTRICTs.FirstOrDefault(d => d.DistrictName == districtID).ID,
   
          
         
                        PropertyType_ID = pd.PROPERTY_TYPE.FirstOrDefault(d => d.CodeType == propertyID).ID,


                    };

                    _context.ReferenceProject.Add(
                            Property.Header.Contains("ID") ? row["ID"] : property.PropertyName,
                            property);

                    pd.PROPERTies.Add(property);
                }


                pd.SaveChanges();
            }
        }
        public void GetListFromViewListOfAgencyProject()
        {
            team15Entities get = new team15Entities();
            UsersController user = new UsersController();

            var controller = new PostProjectController();

            var moqContext = new Moq.Mock<ControllerContext>();
            var moqSession = new Moq.Mock<HttpSessionStateBase>();
            moqContext.Setup(c => c.HttpContext.Session).Returns(moqSession.Object);

            var us = get.USERs.FirstOrDefault(x => x.Email == "pet@gmail.com");
            //user.ControllerContext = moqContext.Object;

            controller.ControllerContext = moqContext.Object;
            moqSession.Setup(s => s["UserRole"]).Returns(us.Role);
            moqSession.Setup(s => s["UserID"]).Returns(us.ID);

            _result = controller.PostProject();
        }
        public void ShowProperty(Table expectedProperty) => ShowProperty(expectedProperty.Rows.Select(r => r["PropertyName"]));
        public void ShowProperty(IEnumerable<string> expectedPROPERTYNames)
        {
            //Act

            var shownPROPERTYs = _result.Model<IEnumerable<PROPERTY>>();

            //Assert
            PropertyAssertions.ManageShouldShowList(shownPROPERTYs, expectedPROPERTYNames);

        }
    }
}
