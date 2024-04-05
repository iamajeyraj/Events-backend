using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Activities.Model;
using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Activities.Controllers {
    public class ActivitiesController : BaseAPIController {
        private readonly ApplicationDbContext dbContext;
        public ActivitiesController(ApplicationDbContext dbContext) {
            this.dbContext = dbContext;
        }

        //GET: /api/activities
        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivities() {
            return await dbContext.Activities.ToListAsync();
        }

        //GET: /api/activity/id
        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> GetActivity(Guid id) {
            return await dbContext.Activities.FindAsync(id);
        }
    }
}

