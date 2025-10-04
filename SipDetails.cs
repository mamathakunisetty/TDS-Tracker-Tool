using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AccountIntelligenceTool.Models
{
    public class SipDetails
    {
        [Key]
        public int SipDetailID { get; set; }

        public int SipID { get; set; }

        public string DetailedDesc { get; set; }

        public DateTime UpdatedOn { get; set; }

        public string UpdatedBy { get; set; }

        public virtual Sip Sips { get; set; }
    }
}
