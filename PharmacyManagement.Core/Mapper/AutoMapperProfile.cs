namespace PharmacyManagement.Core.Mapper
{
    using AutoMapper;
    using DTO;
    using Model;

    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            this.CreateMap<Medicine, MedicineDTO>();
            this.CreateMap<MedicineDTO, Medicine>();
        }
    }
}
