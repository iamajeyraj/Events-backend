using Activities.Model;
using Microsoft.AspNetCore.Mvc;
using Activities.Application;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Activities.Controllers {
    public class ActivitiesController : BaseAPIController {
        //GET: /activities
        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivities() {
            return await Mediator.Send(new ActivityList.Query());
        }

        //GET: /activity/id
        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> GetActivity(Guid id) {
            return await Mediator.Send(new ActivityDetails.Query{Id = id});
        }

        [HttpPost]
        public async Task<IActionResult> CreateActivity(Activity activity){
            await Mediator.Send(new ActivityCreate.Command{Activity = activity});
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateActivity(Guid Id,Activity activity) {
            activity.Id = Id;
            await Mediator.Send(new ActivityUpdate.Command{Activity = activity});
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActivity(Guid id){
            await Mediator.Send(new ActivityDelete.Command{Id = id});
            return Ok();
        }
    }
}

