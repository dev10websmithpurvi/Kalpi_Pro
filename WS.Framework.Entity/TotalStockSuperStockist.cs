using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.Framework.Common;
using System.ComponentModel.DataAnnotations;

namespace WS.Framework.Entity
{
    public class TotalStockSuperStockist : CommonEntity
    {
        [Key]
        public Guid tsss_id { get; set; }
        public Guid tsss_productid { get; set; }
        public int tsss_qty { get; set; }
        public Guid tsss_userid { get; set; }
        public string pm_name { get; set; }
        public string ss_name { get; set; }
    }
}
