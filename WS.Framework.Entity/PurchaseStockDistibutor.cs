using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.Framework.Common;
using System.ComponentModel.DataAnnotations;

namespace WS.Framework.Entity
{
    public class PurchaseStockDistibutor : CommonEntity
    {
        [Key]
        public Guid psd_id { get; set; }
        public Guid psd_productid { get; set; }
        public int psd_qty { get; set; }
        public Guid psd_userid { get; set; }
        public Guid psd_superid { get; set; }
        public string dm_name { get; set; }
        public string pm_name { get; set; }
        public string ss_name { get; set; }
    }
}
