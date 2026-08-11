using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using NegoCity.Application.Contracts.Services;
using NegoCity.Application.DTOs.Business;
using NegoCity.Application.Validators.Business;

namespace NegoCity.API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class BusinessesController : ControllerBase
    {
        private readonly IBusinessService _businessService;
        private readonly IValidator<CreateBusinessRequest> _validator;

        public BusinessesController(
            IBusinessService businessService,
            IValidator<CreateBusinessRequest> validator)
        {
            _businessService = businessService;
            _validator = validator;
        }

        [HttpPost]
        public async Task<ActionResult<BusinessResponse>> Create(
            [FromBody] CreateBusinessRequest request)
        {
            var validationResult =
                await _validator.ValidateAsync(request);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            var business =
                await _businessService.CreateAsync(request);

            return Ok(business);
        }
    }
}
