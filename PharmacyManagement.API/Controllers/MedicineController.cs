

namespace PharmacyManagement.API.Controllers

{
    using MediatR;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Core.Command;
    using Core.DTO;
    using Core.Query;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    [ApiController]
    public class MedicineController : ApiControllerBase
    {
        public MedicineController(IMediator mediator) : base(mediator){}

        [HttpGet("search")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<MedicineDTO>>> SearchMedicineByName([FromQuery] MedicineByNameQuery searchMedicine)
        {
          return await QueryAsync(searchMedicine);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<MedicineDTO>> AddMedicine([FromBody] MedicineAddCommand newMedicine)
        {
            MedicineDTO medicine = await CommandAsync(newMedicine);
            return this.CreatedAtAction(nameof(this.SearchMedicineByName), new { medicine.Id }, medicine);

        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<MedicineDTO>>UpdateMedicine([FromRoute] string id, [FromBody] MedicineUpdateCommand medicine)
        {
            return await CommandAsync(medicine);
        }

    }
}
