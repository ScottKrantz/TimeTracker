using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTracker.Models
{
    public class Project
    {
        public int Id { get; set; }

        [DisplayName("Company")]
        public int? CompanyId { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} character long and no more than {1} characters.", MinimumLength = 1)]
        [DisplayName("Project Name")]
        public string ProjectName { get; set; }

        public string Description { get; set; }

        [DisplayName("Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DisplayName("End Date")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [DisplayName("Priority")]
        public int ProjectPriorityId { get; set; }

        public bool Archived { get; set; }
    }
}
