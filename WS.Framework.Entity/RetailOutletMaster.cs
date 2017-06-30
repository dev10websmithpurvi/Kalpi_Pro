using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.Framework.Common;
using System.ComponentModel.DataAnnotations;

namespace WS.Framework.Entity
{
    public class RetailOutletMaster : CommonEntity
    {
        [Key]
        public Guid rom_id { get; set; }
        public Guid rom_userid { get; set; }
        public string rom_name { get; set; }
        public Guid rom_distibutorid { get; set; }
        public string rom_emailid { get; set; }
        public string rom_mobileno { get; set; }
        public Guid rom_stateid { get; set; }
        public Guid rom_cityid { get; set; }
        public Guid rom_areaid { get; set; }
        public string rom_address { get; set; }
        public string rom_pincode { get; set; }
        public DateTime rom_dob { get; set; }
        public bool rom_isactive { get; set; }
        public string cm_cityname { get; set; }
        public string sm_statename { get; set; }
        public string rm_areaname { get; set; }
        public string dm_name { get; set; }
    }
}
