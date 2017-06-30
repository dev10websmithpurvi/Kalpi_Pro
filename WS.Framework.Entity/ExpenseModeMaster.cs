using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.Framework.Common;
using System.ComponentModel.DataAnnotations;

namespace WS.Framework.Entity
{
    public class ExpenseModeMaster : CommonEntity
    {
        [Key]
        public Guid em_id { get; set; }
        public string em_modename { get; set; }
        public bool em_isactive { get; set; }
    }
}
