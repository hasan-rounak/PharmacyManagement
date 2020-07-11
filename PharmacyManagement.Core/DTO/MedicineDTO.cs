
using System;

namespace PharmacyManagement.Core.DTO
{
   public class MedicineDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
        public short Quantity { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
