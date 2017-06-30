using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.Framework.Common;
using System.ComponentModel.DataAnnotations;

namespace WS.Framework.Entity
{
    public class TotalStockDistibutor : CommonEntity
    {
        [Key]
        public Guid tsd_id { get; set; }
        public Guid tsd_productid { get; set; }
        public int tsd_qty { get; set; }
        public Guid tsd_userid { get; set; }
        public string pm_name { get; set; }
        public string dm_name { get; set; }
    }
}
