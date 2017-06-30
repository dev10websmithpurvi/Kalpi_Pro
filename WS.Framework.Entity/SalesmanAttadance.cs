using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.Framework.Common;
using System.ComponentModel.DataAnnotations;

namespace WS.Framework.Entity
{
    public class SalesmanAttadance : CommonEntity
    {
        [Key]
        public Guid sa_id { get; set; }
        public Guid sa_salesmanid { get; set; }
        public DateTime sa_inouttime { get; set; }
        public int sa_attadancetype { get; set; }
        public string sa_lat { get; set; }
        public string sa_long { get; set; }
        public string sa_area { get; set; }
        public string sa_attadancetypename { get; set; }
        public string smm_deviceid { get; set; }
    }
}
