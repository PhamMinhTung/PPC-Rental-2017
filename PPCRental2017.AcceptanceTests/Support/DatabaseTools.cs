using PPC_Rental_2017.Models;
using TechTalk.SpecFlow;

namespace PPCRental2017.AcceptanceTests.Support
{
    [Binding]
    public class DatabaseTools
    {
        [BeforeScenario]
        public void CleanDatabase()
        {
            using (var db = new team15Entities())
            {
                db.PROPERTY_FEATURE.RemoveRange(db.PROPERTY_FEATURE);
                db.PROPERTies.RemoveRange(db.PROPERTies);
               
                db.SaveChanges();
            }
        }
    }
}
