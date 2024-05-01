using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using DepoManagment.Server.Data;
using DepoManagment.Shared;

namespace DepoManagment.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceiveController : ControllerBase
    {
        public readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _environment;
        public ReceiveController(ApplicationDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }
        [HttpPost("ReceiveBoxes")]
        public async Task<ActionResult<ReceiveBox>> CreateReceiverPoin(ReceiveBox receive)
        {
            try
            {
                await _context.receivBox.AddAsync(receive);
                await _context.SaveChangesAsync();
                return Ok(receive);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
