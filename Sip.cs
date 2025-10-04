using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AccountIntelligenceTool.Models
{
    public class Sip
    {
        public Sip()
        {
            sipDetails = new HashSet<SipDetails>();
        }

        public int SipID { get; set; }

        [StringLength(500)]
        public string ShortDesc { get; set; }

        [StringLength(500)]
        public string BusinessAreaImpacted { get; set; }


        [StringLength(500)]
        public string ImpactedApplication { get; set; }

        //  public string DetailedDesc { get; set; }
        public string BenefitDetails { get; set; }


        [StringLength(500)]
        public string KeyContacts { get; set; }


        public bool IsClientInvolvementReq { get; set; }

        [StringLength(500)]
        public string ClientInvolvement { get; set; }

        [StringLength(500)]
        public string TimeLine { get; set; }

        [StringLength(100)]
        public string Status { get; set; }


        public int UserID { get; set; }

        public virtual UserLoginReturn users { get; set; }

        public DateTime CreatedDate { get; set; }

        public virtual ICollection<SipDetails> sipDetails { get; set; }
    }
}
