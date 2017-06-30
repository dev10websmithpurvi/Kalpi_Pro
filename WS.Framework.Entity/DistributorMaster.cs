using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.Framework.Common;
using System.ComponentModel.DataAnnotations;

namespace WS.Framework.Entity
{
    public class DistributorMaster : CommonEntity
    {
        [Key]
        public Guid dm_id { get; set; }
        public Guid dm_userid { get; set; }
        public Guid dm_superstockisid { get; set; }
        public string dm_name { get; set; }
        public string dm_emailid { get; set; }
        public string dm_mobileno { get; set; }
        public string dm_address { get; set; }
        public Guid dm_cityid { get; set; }
        public Guid dm_stateid { get; set; }
        public string dm_pincode { get; set; }
        public DateTime dm_dob { get; set; }
        public bool dm_isactive { get; set; }
        public string cm_cityname { get; set; }
        public string sm_statename { get; set; }
        public string ss_name { get; set; }
    }
}
