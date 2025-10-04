using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AccountIntelligenceTool.Models
{
    public class BusinessChallenges
    {
        
        public int Id { get; set; }

        [MaxLength(100)]
        [Required]
        public string Title { get; set; }

        [MaxLength(150)]
        [Required]
        public string ShortDescription { get; set; }

        [Required]
        public string LongDescription { get; set; }

        [Required]
        //[DisplayFormat]
        public DateTime EndDate { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        public int UserID { get; set; }
        public virtual UserLoginReturn users { get; set; }
        public int statusID { get; set; }
        public virtual BusinessChallengeStatus Status { get; set; }

        public long ViewCount { get; set; }
    }
}
