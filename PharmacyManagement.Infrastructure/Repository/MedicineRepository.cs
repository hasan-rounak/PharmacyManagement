using System.Collections.Generic;
using System.Threading.Tasks;

namespace PharmacyManagement.Data.Repository
{
    using Core.Interface;
    using Core.Model;

    public class MedicineRepository : IMedicineRepository
    {
        public Task<Medicine> AddMedicine(Medicine medicine)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Medicine>> SearchMedicineByName(string name)
        {
            throw new System.NotImplementedException();
        }

        public Task<Medicine> UpdateMedicine(Medicine medicine)
        {
            throw new System.NotImplementedException();
        }
    }
}
