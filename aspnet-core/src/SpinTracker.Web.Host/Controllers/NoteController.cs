using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpinTracker.EntityFrameworkCore;
using SpinTracker.Notes;

namespace SpinTracker.Web.Host.Controllers
{
    [Route("api/NoteContoller")]
    [ApiController]
    public class NoteController : ControllerBase
    {
        private readonly SpinTrackerDbContext _context;

        public NoteController(SpinTrackerDbContext context)
        {
            //_noteRepository = noteRepository;
            _context = context;

        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Note>> GetTodoItem(long id)
        {
            var todoItem = await _context.Notes.FindAsync(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            return todoItem;
        }




    }
}
    