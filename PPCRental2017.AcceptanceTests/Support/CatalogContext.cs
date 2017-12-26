namespace PPCRental2017.AcceptanceTests.Support
{
    public class CatalogContext
    {
        public CatalogContext()
        {
            ReferenceDetails = new ReferenceDetailsList();
            ReferenceProject = new ReferenceDetailsList();
        }

        public ReferenceDetailsList ReferenceDetails { get; set; }
        public ReferenceDetailsList ReferenceProject { get; set; }
    }
}
