using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace AccountIntelligenceTool.Models
{
    public class NewIdeaSuggestion
    {
        public int IdeaId { get; set; }
        public int SuggestedUser { get; set; }
        public string ImpactService { get; set; }

        public string Requirements { get; set; }
        public string NonActionImplication { get; set; }
   
        public string Constraints { get; set; }
        
        public string Comments { get; set; }
    }
}
