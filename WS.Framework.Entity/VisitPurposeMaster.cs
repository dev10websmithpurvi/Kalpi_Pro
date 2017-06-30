using System;
using WS.Framework.Common;
using System.ComponentModel.DataAnnotations;

namespace WS.Framework.Entity
{
   public class VisitPurposeMaster : CommonEntity
    {
        [Key]
        public Guid vp_id { get; set; }
        public string vp_purposename { get; set; }
        public bool vp_isactive { get; set; }


    }
}
