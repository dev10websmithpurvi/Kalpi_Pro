using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.Framework.Common;
using System.ComponentModel.DataAnnotations;

namespace WS.Framework.Entity
{
    public class InwardStockCompany : CommonEntity
    {
        [Key]
        public Guid isc_id { get; set; }
        public Guid isc_productid { get; set; }
        public int isc_qty { get; set; }
        public Guid isc_userid { get; set; }
        public string pm_name { get; set; }
        public string cp_companyname { get; set; }
    }
}
