using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.Framework.Common;
using System.ComponentModel.DataAnnotations;

namespace WS.Framework.Entity
{
    public class TotalStockCompany
    {
        [Key]
        public Guid tsc_id { get; set; }
        public Guid tsc_productid { get; set; }
        public int tsc_qty { get; set; }
        public Guid tsc_userid { get; set; }
        public string pm_name { get; set; }
        public string cp_companyname { get; set; }
    }
}
