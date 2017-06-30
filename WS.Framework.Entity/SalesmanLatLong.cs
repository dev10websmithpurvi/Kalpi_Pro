using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.Framework.Common;
using System.ComponentModel.DataAnnotations;

namespace WS.Framework.Entity
{
    public class SalesmanLatLong : CommonEntity
    {
        [Key]
        public Guid sll_id { get; set; }
        public Guid sll_salesmanid { get; set; }
        public string sll_lat { get; set; }
        public string sll_long { get; set; }
    }
}
