using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.Framework.Common;
using System.ComponentModel.DataAnnotations;

namespace WS.Framework.Entity
{
    public class RouteMaster : CommonEntity
    {
        [Key]
        public Guid rm_id { get; set; }
        public Guid rm_stateid { get; set; }
        public Guid rm_cityid { get; set; }
        public string rm_areaname { get; set; }
        public bool rm_isactive { get; set; }
        public string cm_cityname { get; set; }
        public string sm_statename { get; set; }
    }
}
