using System;
using WS.Framework.Common;
using System.ComponentModel.DataAnnotations;

namespace WS.Framework.Entity
{
    public class VisitTypeMaster : CommonEntity
    {
        [Key]
        public Guid vt_id { get; set; }
        public string vt_typename { get; set; }
        public bool vt_isactive { get; set; }


    }
}
