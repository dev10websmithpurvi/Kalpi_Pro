using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.Framework.Common;
using System.ComponentModel.DataAnnotations;

namespace WS.Framework.Entity
{
    public class ProductMaster : CommonEntity
    {
        [Key]
        public Guid pm_id { get; set; }
        public string pm_name { get; set; }
        public float pm_price { get; set; }
        public Guid pm_categoryid { get; set; }
        public string pm_productimage { get; set; }
        public bool pm_isactive { get; set; }
        public string cm_name { get; set; }
    }
}
