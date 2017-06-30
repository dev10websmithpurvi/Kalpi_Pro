using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.Framework.Common;
using System.ComponentModel.DataAnnotations;

namespace WS.Framework.Entity
{
    public class SalesmanAttadanceTime : CommonEntity
    {
        [Key]
        public Guid sat_id { get; set; }
        public Guid sat_salesmanid { get; set; }
        public int sat_totaltime { get; set; }
        public string smm_name { get; set; }
        public string sat_totaltimestring { get; set; }
    }
}
