using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTracker.Models
{
    public class ProjectLog
    {
        public int Id { get; set; }

        [DisplayName("Company")]
        public int? CompanyId { get; set; }

        [DisplayName("User")]
        public int UserId { get; set; }

        [DisplayName("Start Time")]
        [DataType(DataType.DateTime)]
        public DateTime StartTime { get; set; }

        [DisplayName("End Time")]
        [DataType(DataType.DateTime)]
        public DateTime? EndTime { get; set; }

        public TimeSpan? Duration { get { return EndTime - StartTime; } }
    }
}
