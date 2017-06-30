using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.Framework.Common;
using System.ComponentModel.DataAnnotations;

namespace WS.Framework.Entity
{
    public class ExpenseTypeMaster : CommonEntity
    {
        [Key]
        public Guid et_id { get; set; }
        public string et_typename { get; set; }
        public bool et_isactive { get; set; }
    }
}
