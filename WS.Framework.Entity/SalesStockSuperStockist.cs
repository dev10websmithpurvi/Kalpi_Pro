using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.Framework.Common;
using System.ComponentModel.DataAnnotations;

namespace WS.Framework.Entity
{
    public class SalesStockSuperStockist : CommonEntity
    {
        [Key]
        public Guid ssss_id { get; set; }
        public Guid ssss_productid { get; set; }
        public int ssss_qty { get; set; }
        public Guid ssss_userid { get; set; }
        public string pm_name { get; set; }
        public string ss_name { get; set; }
    }
}
