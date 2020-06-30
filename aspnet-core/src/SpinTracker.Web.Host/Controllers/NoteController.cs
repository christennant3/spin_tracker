using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SpinTracker.Controllers;
using SpinTracker.EntityFrameworkCore;
using SpinTracker.Notes;
using Microsoft.AspNetCore.Http;

namespace SpinTracker.Web.Host.Controllers
{
   
    public class NoteController : ControllerBase
    {
        private readonly SpinTrackerDbContext _context;
        private readonly IRepository<Note> _noteRepository;
        public NoteController(IRepository<Note> noteRepository, SpinTrackerDbContext context)
        {
            _noteRepository = noteRepository;
            _context = context;

        }
        [HttpGet("api/notes/{id}")]
        public JsonResult GetNoteById(int id)
        {

            var questions = _context.Notes
            .Where(n => n.Id == id)
            .FirstOrDefault();
            return new JsonResult(questions);

        }

        [HttpGet("api/EntryDate/")]
        public JsonResult GetNoteBySome()
        {

            var questions = _context.EntryDates
            .Where(n => n.Id > 0)
            .ToList();
            return new JsonResult(questions);

        }


    }
}
    