using System;

namespace PharmacyManagement.Core.Model
{
    public class Medicine
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
        public short  Quantity{ get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Notes { get; set; }

    }
}
