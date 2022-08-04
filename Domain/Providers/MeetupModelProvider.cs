using Domain.Models;
using Storage.Context;
using Storage.Models;
using Storage.Providers;
using System.Collections.Generic;

namespace Domain.Providers
{
    public class MeetupModelProvider
    {
        private readonly MeetupContext _meetupContext;

        public MeetupModelProvider(MeetupContext meetupContext)
        {
            _meetupContext = meetupContext;
        }

        public IEnumerable<MeetupModel> GetMeetups()
        {
            var provider = new MeetupDataModelProvider(_meetupContext);

            var meetupsData = provider.GetMeetups();

            var meetups = new List<MeetupModel>();

            foreach (var item in meetupsData)
            {
                var meetup = ConvertToMeetupModel(item);

                meetups.Add(meetup);
            }

            return meetups;
        }

        public MeetupModel GetMeetup(int id)
        {
            var provider = new MeetupDataModelProvider(_meetupContext);

            var meetupData = provider.GetMeetup(id);

            return ConvertToMeetupModel(meetupData);
        }

        public void CreateMeetup(MeetupModel meetupModel)
        {
            var provider = new MeetupDataModelProvider(_meetupContext);

            var meetupData = ConvertToMeetupDataModel(meetupModel);

            provider.CreateMeetup(meetupData);
        }

        public void UpdateMeetup(int id, MeetupModel meetupModelToUpdate)
        {
            var provider = new MeetupDataModelProvider(_meetupContext);

            var meetupDataToUpdate = ConvertToMeetupDataModel(meetupModelToUpdate);

            provider.UpdateMeetup(id, meetupDataToUpdate);
        }

        public void DeleteMeetup(int id)
        {
            var provider = new MeetupDataModelProvider(_meetupContext);

            provider.DeleteMeetup(id);
        }

        private MeetupDataModel ConvertToMeetupDataModel (MeetupModel meetupModel)
        {
            return new MeetupDataModel()
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

        private MeetupModel ConvertToMeetupModel(MeetupDataModel meetupDataModel)
        {
            return new MeetupModel()
            {
                MeetupId = meetupDataModel.MeetupId,
                Title = meetupDataModel.Title,
                Theme = meetupDataModel.Theme,
                Description = meetupDataModel.Description,
                Plan = meetupDataModel.Plan,
                Organizar = meetupDataModel.Organizar,
                Speaker = meetupDataModel.Speaker,
                MeetupTime = meetupDataModel.MeetupTime,
                MeetupPlace = meetupDataModel.MeetupPlace
            };
        }
    }
}
