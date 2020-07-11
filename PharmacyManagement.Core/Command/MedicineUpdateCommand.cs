namespace PharmacyManagement.Core.Command
{
    using DTO;
    using MediatR;
    using Model;

    public class MedicineUpdateCommand : Medicine, IRequest<MedicineDTO>
    {
    }
}
