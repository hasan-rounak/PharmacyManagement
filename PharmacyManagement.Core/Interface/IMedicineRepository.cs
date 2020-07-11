using PharmacyManagement.Core.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PharmacyManagement.Core.Interface
{
    public interface IMedicineRepository
    {
        Task<List<Medicine>> SearchMedicineByName(string name);
        Task<Medicine> UpdateMedicine(Medicine medicine);
        Task<Medicine> AddMedicine(Medicine medicine);
    }
}
