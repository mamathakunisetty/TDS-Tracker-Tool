using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AccountIntelligenceTool.Models
{
    public class FIReassignSubForm
    {
        [Required]
        public int FIStatus_value { get; set; }
        [Required]
        public int AssignedUserValue { get; set; }
        [Required]
        public string commentsAdded { get; set; }

        [Required]
        public DateTime reviewDate = @System.DateTime.Now.AddDays(14);
    }
}
