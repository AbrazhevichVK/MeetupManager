using MeetupManager.Context;
using MeetupManager.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace MeetupManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetupsController : ControllerBase
    {
        private readonly MeetupContext _meetupContext;

        public MeetupsController(MeetupContext meetupContext)
        {
            _meetupContext = meetupContext;
        }

        [HttpGet]
        public IEnumerable<Meetup> Get()
        {
            return _meetupContext.Meetups;
        }

        [HttpGet("{id}", Name = "Get")]
        public Meetup Get(int id)
        {
            return _meetupContext.Meetups.SingleOrDefault(x=>x.MeetupId == id);
        }

        [HttpPost]
        public void Post([FromBody] Meetup meetup)
        {
            _meetupContext.Meetups.Add(meetup);
            _meetupContext.SaveChanges();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Meetup meetup)
        {
            meetup.MeetupId = id;
            _meetupContext.Meetups.Update(meetup);
            _meetupContext.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var meetup = _meetupContext.Meetups.FirstOrDefault(x => x.MeetupId == id);

            if (meetup != null) 
            {
                _meetupContext.Meetups.Remove(meetup);
                _meetupContext.SaveChanges();
            }
        }
    }
}
