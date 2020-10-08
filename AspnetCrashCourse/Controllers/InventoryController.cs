using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspnetCrashCourse.Logic.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspnetCrashCourse.Controllers
{
    [Route("api/inventory")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryService InventoryService;

        public InventoryController(IInventoryService inventoryService)
        {
            InventoryService = inventoryService;
        }

        [HttpGet]
        public IActionResult Get() =>
            throw new NotImplementedException();
    }
}
