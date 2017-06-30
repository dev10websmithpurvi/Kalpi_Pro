using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.Framework.Common;
using System.ComponentModel.DataAnnotations;

namespace WS.Framework.Entity
{
    public class PurchaseStockSuperStockist : CommonEntity
    {
        [Key]
        public Guid psss_id { get; set; }
        public Guid psss_productid { get; set; }
        public int psss_qty { get; set; }
        public Guid psss_userid { get; set; }
        public Guid psss_companyid { get; set; }
        public string pm_name { get; set; }
        public string ss_name { get; set; }
        public string cp_companyname { get; set; }
    }
}
