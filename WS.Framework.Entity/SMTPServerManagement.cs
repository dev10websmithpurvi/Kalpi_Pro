using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.Framework.Common;

namespace WS.Framework.Entity
{
    public class SMTPServerManagement : CommonEntity
    {
        [Key]
        public System.Guid ssm_id { get; set; }
        public string ssm_displayname { get; set; }
        public string ssm_emailaddress { get; set; }
        public string ssm_password { get; set; }
        public string ssm_replaytomailaddress { get; set; }
        public string ssm_smtpserver { get; set; }
        public int ssm_smtpport { get; set; }
        public bool ssm_enablessl { get; set; }
        public bool ssm_isdefault { get; set; }
        public bool ssm_isactive { get; set; }
    }
}
