using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountIntelligenceTool.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AccountIntelligenceTool.Models
{
    public class UserLoginReturn
    {
        //public UserLoginReturn()
        //{
        //    Sip = new HashSet<Sip>();
        //}


        public virtual ICollection<Sip> Sip { get; set; }

        public virtual ICollection<BusinessChallenges> BusinessChallenges { get; set; }

        public int Id { get; set; }

        [Required]
        public string Email { get; set; }


        [Required]
        [MaxLength(20)]
        [MinLength(8)]
        public string Password { get; set; }


        //  [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //public int UserType { get; set; }
        [DefaultValue(false)]
        public bool IsBCAdmin { get; set; }

        //   [DefaultValue(false)]           
        //   public bool IsTriageAdmin{get;set;}

        [DefaultValue(false)]
        public bool IsFIOwner { get; set; }

        //  [DatabaseGenerated(DatabaseGeneratedOption.Computed)] 
        [DefaultValue("")]
        public string ResourceName { get; set; }

        public DateTime CreatedDate { get; set; }

        //public int TeamID { get; set; }
        public virtual Teams Team { get; set; }

        public virtual ICollection<Initiatives> Initiatives { get; set; }
        //public virtual ICollection<Ideas> Ideas { get; set;}
        public virtual ICollection<Ideas> RaisedIdeas { get; set; }
        public virtual ICollection<Ideas> AssignedIdeas { get; set; }


        [DefaultValue(false)]
        public bool AccountLevelOwner { get; set; }

        [DefaultValue(false)]
        public bool ProjectImprovementOwner { get; set; }

        [DefaultValue(false)]
        public bool ServiceImprovementOwner { get; set; }

    }
}
