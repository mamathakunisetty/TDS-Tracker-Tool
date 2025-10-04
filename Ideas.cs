using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AccountIntelligenceTool.Models
{
    public class Ideas
    {
        public int Id { get; set; }

        public int RaisedUserID { get; set; }
        public UserLoginReturn RaisedUser { get; set; }

        public int AssignedUserID { get; set; }
        public UserLoginReturn AssignedUser { get; set; }
        public DateTime CreatedDate { get; set; }

        [MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(150)]
        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public virtual IdeasStatus Status { get; set; }

        public virtual Categories Category { get; set; }

        public virtual SubCategories SubCategory { get; set; }

        public string Benefits { get; set; }


        public string SuccessMeasurement { get; set; }

        public DateTime LastUpdatedDate { get; set; }
        public DateTime ReviewDate { get; set; }
    }
}
