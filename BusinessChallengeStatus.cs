using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountIntelligenceTool.Models
{
    public class BusinessChallengeStatus
    {
        public virtual ICollection<BusinessChallenges> BusinessChallenges { get; set; }
        public int Id { get; set; }

        public string Status { get; set; }
    }
}
