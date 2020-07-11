
namespace PharmacyManagement.Core.CommandHandler
{
    using Command;
    using DTO;
    using MediatR;
    using Interface;
    using System.Threading;
    using System.Threading.Tasks;
    using AutoMapper;
    using Model;

    public class MedicineAddCommandHandler : IRequestHandler<MedicineAddCommand, MedicineDTO>
    {
        private readonly IMedicineRepository _medicineRepository;
        private readonly IMapper _mapper;
        public MedicineAddCommandHandler(IMedicineRepository medicineRepository, IMapper mapper)
        {
            _medicineRepository = medicineRepository;
            _mapper = mapper;
        }

        public async Task<MedicineDTO> Handle(MedicineAddCommand request, CancellationToken cancellationToken)
        {
            try
            {
                Medicine medicine =
              await _medicineRepository.AddMedicine(_mapper.Map<Medicine>(request));
                return this._mapper.Map<MedicineDTO>(medicine);
            }
            catch (System.Exception ex)
            {

                throw;
            }
            
        }
    }
}
