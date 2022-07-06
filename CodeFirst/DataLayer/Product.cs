namespace CodeFirst.DataLayer
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int VendorID { get; set; }

        public Vendor Vendor { get; set; }
    }
}
