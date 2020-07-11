namespace PharmacyManagement.Core.Command
{
    using MediatR;
    using DTO;
    using Model;
    using System.Collections.Generic;

    public class MedicineUpdateCommand : Medicine, IRequest<MedicineDTO>
    {
    }
}
