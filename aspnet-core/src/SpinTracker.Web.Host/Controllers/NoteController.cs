using System;
using System.Linq;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using SpinTracker.Controllers;
using SpinTracker.EntityFrameworkCore;
using SpinTracker.Notes;

namespace SpinTracker.Web.Host.Controllers
{
    [Route("api/NoteContoller")]
    [ApiController]
    public class NoteController : SpinTrackerControllerBase
    {

        private readonly IRepository<Note> _noteRepository;
   
        public NoteController(IRepository<Note> noteRepository)
        {
            _noteRepository = noteRepository;
           

        }

        [HttpGet("api/note/{id}")]
        public JsonResult GetNoteByTest(int id)
        {
            var notes = _noteRepository.GetAll()
                .Where(n => n.Id > 0)
                .ToList();



            return new JsonResult(notes);

        }




    }
}
    