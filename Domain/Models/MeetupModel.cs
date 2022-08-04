using System;

namespace Domain.Models
{
    public class MeetupModel
    {
        public int MeetupId { get; set; }
        public string Title { get; set; }
        public string Theme { get; set; }
        public string Description { get; set; }
        public string Plan { get; set; }
        public string Organizar { get; set; }
        public string Speaker { get; set; }
        public DateTime MeetupTime { get; set; }
        public string MeetupPlace { get; set; }

    }
}
