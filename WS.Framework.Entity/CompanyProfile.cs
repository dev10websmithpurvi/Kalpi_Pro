using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.Framework.Common;
using System.ComponentModel.DataAnnotations;

namespace WS.Framework.Entity
{
    public class CompanyProfile : CommonEntity
    {
        [Key]
        public Guid cp_id { get; set; }
        public string cp_companyname { get; set; }
        public string cp_mobileno { get; set; }
        public string cp_officeno { get; set; }
        public string cp_emailid { get; set; }
        public string cp_ownername { get; set; }
        public int tsc_qty { get; set; }
    }
}
