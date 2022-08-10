using Storage.Context;
using MeetupManager.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Domain.Models;
using Domain.Providers;
using Microsoft.AspNetCore.Authorization;

namespace MeetupManager.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MeetupsController : ControllerBase
    {
        private readonly MeetupContext _meetupContext;

        public MeetupsController(MeetupContext meetupContext)
        {
            _meetupContext = meetupContext;
        }

        /// <summary>
        ///     Get meetups
        /// </summary>
        [HttpGet]
        public IEnumerable<MeetupContract> Get()
        {
            var provider = new MeetupModelProvider(_meetupContext);

            var meetupModels = provider.GetMeetups();

            var meetups = new List<MeetupContract>();

            foreach (var item in meetupModels)
            {
                var meetup = ConvertToMeetupContract(item);

                meetups.Add(meetup);
            }

            return meetups;
        }

        /// <summary>
        ///     Get meetup by id
        /// </summary>
        [HttpGet("{id}", Name = "Get")]
        public MeetupContract Get(int id)
        {
            var provider = new MeetupModelProvider(_meetupContext);

            var meetupModel = provider.GetMeetup(id);

            return ConvertToMeetupContract(meetupModel);
        }

        /// <summary>
        ///     Create meetup
        /// </summary>
        [HttpPost]
        public void Post([FromBody] MeetupContract meetupContract)
        {
            var provider = new MeetupModelProvider(_meetupContext);

            var meetupModel = ConvertToMeetupModel(meetupContract);

            provider.CreateMeetup(meetupModel);
        }

        /// <summary>
        ///     Update meetup
        /// </summary>
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] MeetupContract meetupContract)
        {
            var provider = new MeetupModelProvider(_meetupContext);

            var meetupModelToUpdate = ConvertToMeetupModel(meetupContract);

            provider.UpdateMeetup(id, meetupModelToUpdate);
        }

        /// <summary>
        ///     Delete meetup
        /// </summary>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var provider = new MeetupModelProvider(_meetupContext);

            provider.DeleteMeetup(id);
        }

        private MeetupModel ConvertToMeetupModel(MeetupContract meetupContract)
        {
            return new MeetupModel()
            {
                MeetupId = meetupContract.MeetupId,
                Title = meetupContract.Title,
                Theme = meetupContract.Theme,
                Description = meetupContract.Description,
                Plan = meetupContract.Plan,
                Organizar = meetupContract.Organizar,
                Speaker = meetupContract.Speaker,
                MeetupTime = meetupContract.MeetupTime,
                MeetupPlace = meetupContract.MeetupPlace
            };
        }

        private MeetupContract ConvertToMeetupContract(MeetupModel meetupModel)
        {
            return new MeetupContract()
            {
                MeetupId = meetupModel.MeetupId,
                Title = meetupModel.Title,
                Theme = meetupModel.Theme,
                Description = meetupModel.Description,
                Plan = meetupModel.Plan,
                Organizar = meetupModel.Organizar,
                Speaker = meetupModel.Speaker,
                MeetupTime = meetupModel.MeetupTime,
                MeetupPlace = meetupModel.MeetupPlace
            };
        }
    }
}
