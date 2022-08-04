using Storage.Context;
using Storage.Models;
using System.Collections.Generic;
using System.Linq;

namespace Storage.Providers
{
    public class MeetupDataModelProvider
    {
        private readonly MeetupContext _meetupContext;

        public MeetupDataModelProvider(MeetupContext meetupContext)
        {
            _meetupContext = meetupContext;
        }

        public IEnumerable<MeetupDataModel> GetMeetups()
        {
            return _meetupContext.Meetups;
        }

        public MeetupDataModel GetMeetup(int id)
        {
            return _meetupContext.Meetups.SingleOrDefault(x => x.MeetupId == id);
        }

        public void CreateMeetup(MeetupDataModel meetupDataModel)
        {
            _meetupContext.Meetups.Add(meetupDataModel);
            _meetupContext.SaveChanges();
        }

        public void UpdateMeetup(int id, MeetupDataModel meetupDataModelToUpdate)
        {
            meetupDataModelToUpdate.MeetupId = id;
            _meetupContext.Meetups.Update(meetupDataModelToUpdate);
            _meetupContext.SaveChanges();
        }

        public void DeleteMeetup(int id)
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
