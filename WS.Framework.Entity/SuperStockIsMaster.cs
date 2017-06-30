using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.Framework.Common;
using System.ComponentModel.DataAnnotations;

namespace WS.Framework.Entity
{
    public class SuperStockIsMaster : CommonEntity
    {
        [Key]
        public Guid ss_id { get; set; }
        public Guid ss_userid { get; set; }
        public string ss_name { get; set; }
        public string ss_emailid { get; set; }
        public string ss_mobileno { get; set; }
        public string ss_address { get; set; }
        public Guid ss_cityid { get; set; }
        public Guid ss_stateid { get; set; }
        public string ss_pincode { get; set; }
        public DateTime ss_dob { get; set; }
        public bool ss_isactive { get; set; }
        public string cm_cityname { get; set; }
        public string sm_statename { get; set; }
    }
}
