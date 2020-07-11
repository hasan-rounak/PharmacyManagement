
namespace PharmacyManagement.Core.QueryHandler
{
    using MediatR;
    using Core.DTO;
    using Core.Query;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Interface;
    using AutoMapper;
    using Model;

    public class MedicineByNameQueryHandler : IRequestHandler<MedicineByNameQuery, IEnumerable<MedicineDTO>>
    {
        private readonly IMedicineRepository _medicineRepository;
        private readonly IMapper _mapper;
        public MedicineByNameQueryHandler(IMedicineRepository medicineRepository, IMapper mapper)
        {
            _medicineRepository = medicineRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<MedicineDTO>> Handle(MedicineByNameQuery request, CancellationToken cancellationToken)
        {
            IEnumerable<Medicine> medicine =
              await _medicineRepository.SearchMedicineByName(request.Name);
            return this._mapper.Map<IEnumerable<MedicineDTO>>(medicine);
        }
    }
}
