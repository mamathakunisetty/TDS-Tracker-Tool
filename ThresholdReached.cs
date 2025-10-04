using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AccountIntelligenceTool.Models
{
    public class ThresholdReached
    {
        [Required]
        public string ResourceName { get; set; }
    }
}
