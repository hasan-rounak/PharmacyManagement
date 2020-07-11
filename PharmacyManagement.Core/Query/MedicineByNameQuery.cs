namespace PharmacyManagement.Core.Query
{
    using DTO;
    using MediatR;
    using System.Collections.Generic;

    public class MedicineByNameQuery : IRequest<IEnumerable<MedicineDTO>>
    {
        public string Name { get; set; }
    }
}
