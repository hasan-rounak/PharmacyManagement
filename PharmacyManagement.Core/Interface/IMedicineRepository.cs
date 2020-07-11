using PharmacyManagement.Core.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PharmacyManagement.Core.Interface
{
    public interface IMedicineRepository
    { 
        Task<IEnumerable<Medicine>> SearchMedicineByName(string name);
        Task<Medicine> UpdateMedicine(Medicine medicine);
        Task<Medicine> AddMedicine(Medicine medicine);
    }
}
