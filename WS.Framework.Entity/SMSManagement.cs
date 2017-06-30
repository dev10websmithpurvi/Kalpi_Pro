using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.Framework.Common;

namespace WS.Framework.Entity
{
    public class SMSManagement : CommonEntity
    {
        [Key]
        public Guid sm_id { get; set; }
        public bool sm_isdefault { get; set; }
        public string sm_titlename { get; set; }
        public string sm_smsapi { get; set; }
        public bool sm_isacative { get; set; }
    }
}
