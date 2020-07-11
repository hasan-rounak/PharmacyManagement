namespace PharmacyManagement.Core.CommandHandler
{
    using AutoMapper;
    using Core.Command;
    using Core.DTO;
    using Interface;
    using MediatR;
    using Model;
    using System.Threading;
    using System.Threading.Tasks;

    public class MedicineUpdateCommandHandler : IRequestHandler<MedicineUpdateCommand, MedicineDTO>
    {
        private readonly IMedicineRepository _medicineRepository;
        private readonly IMapper _mapper;
        public MedicineUpdateCommandHandler(IMedicineRepository medicineRepository, IMapper mapper)
        {
            _medicineRepository = medicineRepository;
            _mapper = mapper;
        }
        public async Task<MedicineDTO> Handle(MedicineUpdateCommand request, CancellationToken cancellationToken)
        {
            Medicine medicine = await _medicineRepository.UpdateMedicine(_mapper.Map<Medicine>(request));
            return this._mapper.Map<MedicineDTO>(medicine);
        }
    }
}
