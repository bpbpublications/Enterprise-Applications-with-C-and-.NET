using BookingService.Server.Logic;
using BookingService.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BookingService.Server.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ContainerTypeController : ControllerBase
    {
        private readonly ILogger<ContainerTypeController> _logger;
        private readonly ContainerTypeLogic _containerTypeLogic;
        public ContainerTypeController(ILogger<ContainerTypeController> logger)
        {
            _logger = logger;
            _containerTypeLogic = new ContainerTypeLogic();
        }

        [HttpGet]
        public async Task<List<ContainerType>> GetList()
        {
            return await _containerTypeLogic.GetList();
        }

        [HttpGet]
        public async Task<ContainerType> Get(int id)
        {
            return await _containerTypeLogic.Get(id);
        }

        [HttpPost]
        public async Task Add([FromBody] ContainerType containerType)
        {
            await _containerTypeLogic.Add(containerType);
        }

        [HttpPost]
        public async Task Edit([FromBody] ContainerType containerType)
        {
            await _containerTypeLogic.Edit(containerType);
        }
    }
}


