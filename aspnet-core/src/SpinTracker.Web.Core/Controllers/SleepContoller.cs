using Abp.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using SpinTracker.EntityFrameworkCore;
using SpinTracker.Sleeps;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpinTracker.Controllers
{
    public class SleepContoller : SpinTrackerControllerBase
    {
        private readonly IRepository<Sleep> _sleepRepository;
        private readonly SpinTrackerDbContext _context;

        public SleepContoller(IRepository<Sleep> sleepRepository)
        {
            _sleepRepository = sleepRepository;

            
        }
        [HttpGet("api/sleep/{id}")]
        public JsonResult GetSleepById(int id)
        {
            var sleep = _sleepRepository.Get(id);
            return new JsonResult(sleep);

        }
    }
    
    
}
