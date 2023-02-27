using BookingService.Server.Logic;
using BookingService.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BookingService.Server.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PortInfoController : ControllerBase
    {
        private readonly ILogger<PortInfoController> _logger;
        private readonly PortLogic _portLogic;
        public PortInfoController(ILogger<PortInfoController> logger)
        {
            _logger = logger;
            _portLogic = new PortLogic();
        }

        [HttpGet]
        public async Task<List<Port>> GetList()
        {
            return await _portLogic.GetList();
        }

        [HttpGet]
        public async Task<Port> Get(int id)
        {
            return await _portLogic.Get(id);
        }

        [HttpPost]
        public async Task Add([FromBody] Port port)
        {
            await _portLogic.Add(port);
        }

        [HttpPost]
        public async Task Edit([FromBody] Port port)
        {
            await _portLogic.Edit(port);
        }
    }
}

