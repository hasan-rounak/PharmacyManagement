namespace PharmacyManagement.Data.Repository
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Core.Interface;
    using Core.Model;
    using JsonFlatFileDataStore;
    using System;
    using System.Linq;

    public class MedicineRepository : IMedicineRepository
    {
       private readonly IDocumentCollection<Medicine> _medicineDb;
        public MedicineRepository()
        {
            var store = new DataStore("data.json");
            _medicineDb = store.GetCollection<Medicine>();
        }
        public async Task<Medicine> AddMedicine(Medicine medicine)
        {
            medicine.Id = Guid.NewGuid().ToString("N");
            await _medicineDb.InsertOneAsync(medicine);
            return _medicineDb.AsQueryable().FirstOrDefault(m=> m.Id== medicine.Id);
        }

        public Task<List<Medicine>> SearchMedicineByName(string name)
        {
            return Task.FromResult(_medicineDb.AsQueryable()
                          .Where(m=> (String.IsNullOrWhiteSpace(name)) ? true:
                          m.Name.StartsWith(name,StringComparison.InvariantCultureIgnoreCase)).ToList());
        }

        public async Task<Medicine> UpdateMedicine(Medicine medicine)
        {
            await _medicineDb.UpdateOneAsync(medicine.Id, medicine);
            return _medicineDb.AsQueryable().FirstOrDefault(m => m.Id == medicine.Id);
        }
    }
}
