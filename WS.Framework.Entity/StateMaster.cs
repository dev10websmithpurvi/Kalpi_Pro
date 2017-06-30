using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.Framework.Common;

namespace WS.Framework.Entity
{
    public class StateMaster : CommonEntity
    {
        [Key]
        public Guid sm_id { get; set; }
        public string sm_statename { get; set; }
        public Guid sm_countryid { get; set; }
        public bool sm_isactive { get; set; }
    }
}
