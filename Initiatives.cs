using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AccountIntelligenceTool.Models
{
    public class Initiatives
    {
        public int Id { get; set; }

        public int UserID { get; set; }
        public virtual UserLoginReturn users { get; set; }

        public DateTime CreatedDate { get; set; }

        [MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(150)]
        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        [MaxLength(100)]
        public string Technology { get; set; }

        [MaxLength(200)]
        public string POCIdeas { get; set; }

        public string Benefits { get; set; }

        public DateTime LastUpdatedDate { get; set; }

    }
}
