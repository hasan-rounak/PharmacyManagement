
using System;

namespace PharmacyManagement.Core.DTO
{
   public class MedicineDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
        public short Quantity { get; set; }
        public DateTime ExpiryDate { get; set; }
        private string status;

        public string Status
        {
            get
            {
                if (ExpiryDate.AddDays(-30)<DateTime.Now)
                {
                    status = "R";
                }
                else if (Quantity<10)
                {
                    status = "Y";
                }
                return status;
            }
        }

    }
}
