using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.Framework.Common;
using System.ComponentModel.DataAnnotations;

namespace WS.Framework.Entity
{
    public class SchemeBuilder : CommonEntity
    {
        [Key]
        public Guid sb_id { get; set; }
        public string sb_schemename { get; set; }
        public int sb_buyitems { get; set; }
        public int sb_getitems { get; set; }
        public bool sb_isactive { get; set; }
    }
}
