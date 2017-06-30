using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.Framework.Common;
using System.ComponentModel.DataAnnotations;

namespace WS.Framework.Entity
{
    public class SalesmanMaster : CommonEntity
    {
        [Key]
        public Guid smm_id { get; set; }
        public Guid smm_userid { get; set; }
        public string smm_name { get; set; }
        public string smm_emailid { get; set; }
        public string smm_mobileno { get; set; }
        public string smm_address { get; set; }
        public Guid smm_cityid { get; set; }
        public Guid smm_stateid { get; set; }
        public string smm_pincode { get; set; }
        public DateTime smm_dob { get; set; }
        public bool smm_isactive { get; set; }
        public string cm_cityname { get; set; }
        public string sm_statename { get; set; }
        public string smm_deviceid { get; set; }
    }
}
