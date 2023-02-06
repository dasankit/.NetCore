using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AnkitTest.Controllers
{
    [ApiController]
    [Route("ankitcontroller")]
    public class CTETestController : ControllerBase
    {
        public readonly CrudSampleContext _context;
        public CTETestController(CrudSampleContext context)
        {
            _context = context;
        }


        [HttpGet("getFirst")]
        public async Task<CTEResult> GetAsync()
        {
            return await _context.CTEResults.FirstAsync();
        }


        //10814
        [HttpGet("getById/{id}")]
        public async Task<IEnumerable<CTEResult>> GetByIdAsync(int id)
        {
            return await _context.CTEResults.Where(_ => _.Id == id).ToListAsync();
        }

        [HttpPut("update")]
        public async Task<int> Update(CTEResult request)
        {
            _context.CTEResults.Update(request);
            await _context.SaveChangesAsync();
            return request.Id;
        }
    }
}