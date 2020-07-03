using Abp.Domain.Repositories;
using Abp.EntityFrameworkCore.Repositories;
using Abp.Json;
using Microsoft.AspNetCore.Mvc;
using SpinTracker.EntityFrameworkCore;
using SpinTracker.Sleeps;
using System;
using System.Collections.Generic;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Linq;

namespace SpinTracker.Controllers
{
    public class SleepContoller : SpinTrackerControllerBase
    {
        private readonly IRepository<Sleep> _sleepRepository;
        private readonly SpinTrackerDbContext _context;

        public SleepContoller(IRepository<Sleep> sleepRepository)
        {
            _sleepRepository = sleepRepository;
            //_context = context;



        }
        [HttpGet("api/sleep/{id}")]
        
        public JsonResult GetSleepById(int id)
        {
            var sleeps = _sleepRepository.GetAll()
                .Where(p => p.FellAsleep == true)
                .ToList()
                ;



            return new JsonResult(sleeps);

        }

        //[HttpGet("api/sleeps/{id}")]
        //public JsonResult GetSleepBySleep(int id)
        //{
        //    var sleeps = _context.Sleeps
        //       .Where(s => s.Id == id)
        //       .FirstOrDefault();
        //     return new JsonResult(sleeps);

        //}
    }
    
    
}
