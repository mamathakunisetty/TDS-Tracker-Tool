using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountIntelligenceTool.Models
{
    public class Comments
    {
        public int Id { get; set; }

        public string Comment { get; set; }

        public DateTime CreatedDate { get; set; }

        public int UserID { get; set; }
        public virtual UserLoginReturn users { get; set; }
        public int CategoryType { get; set; }
        //public virtual CategoryTypes Category { get; set; }

        public int CategoryUID { get; set; }

        public bool IsRAGSet { get; set; }
    }
}
