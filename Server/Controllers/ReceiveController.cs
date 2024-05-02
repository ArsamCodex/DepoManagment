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
        [HttpGet("GetAllBoxes")]
        public async Task<ActionResult<ReceiveBox>> GetBozes()
        {
            try
            {
                var AllBoxes = await _context.receivBox.OrderByDescending(c => c.IncomeDate).ToListAsync();
                return Ok(AllBoxes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("CheckOrBoxExist/{ReceiveBoxBarcode}")]
        public async Task<ActionResult<bool>> CheckBox(string ReceiveBoxBarcode)
        {
           var x = await _context.receivBox.FirstOrDefaultAsync(c => c.BoxBarcode == ReceiveBoxBarcode);
            bool boxExists = x != null;
            return Ok(boxExists);

        }
        [HttpGet("GetBoxIdByBarcode/{barcode}")]
        public async Task<ActionResult<int>> GetBoxIdByBarcode(string barcode)
        {
            try
            {
                var receiveBox = await _context.receivBox.FirstOrDefaultAsync(c => c.BoxBarcode == barcode);
                if (receiveBox != null)
                {
                    int boxId = receiveBox.ReceiveBoxID;
                    return Ok(boxId);
                }
                else
                {
                    return NotFound(); // Return 404 if no receive box is found with the given barcode
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("SaveEnveloopExtract")]
        public async Task<ActionResult<EnveloopExtract>> SaveEnveloop(EnveloopExtract enveloopExtract)
        {
            try
            {
                await _context.enveloopExtracts.AddAsync(enveloopExtract);
                await _context.SaveChangesAsync();
                return Ok(enveloopExtract);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("EditReceiveBoxLocation")]
        public async Task<IActionResult> EditReceiveBoxLocation( ReceiveBox receiveBox)
        {
            try
            {
                var result = await _context.receivBox.FirstOrDefaultAsync(e => e.ReceiveBoxID == receiveBox.ReceiveBoxID);
                if (result != null)
                {
                    //Here we change department in phase 1
                    result.WhereIsTheBox = Department.Extract;
                    await _context.SaveChangesAsync();
                    return Ok(receiveBox);
                }
                else
                {
                    return NotFound(); // Return 404 Not Found if receive box with the specified ID is not found
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("GetBoxById/{id}")]
        public async Task<ActionResult<ReceiveBox>> GetBoxByBarcode(int Id)
        {
            try
            {
                var receiveBox = await _context.receivBox.FirstOrDefaultAsync(c => c.ReceiveBoxID == Id);
                if (receiveBox != null)
                {
                   
                    return Ok(receiveBox);
                }
                else
                {
                    return NotFound(); // Return 404 if no receive box is found with the given barcode
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
