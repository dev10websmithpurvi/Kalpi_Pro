using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.Framework.Common;

namespace WS.Framework.Entity
{
    public class CategoryMaster : CommonEntity
    {
        [Key]
        public Guid cm_id { get; set; }
        public string cm_name { get; set; }
        public bool cm_isactive { get; set; }
    }
}
