using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.Framework.Common;
using System.ComponentModel.DataAnnotations;

namespace WS.Framework.Entity
{
  public  class CustomerTypeMaster : CommonEntity
    {
        [Key]
        public Guid ct_id { get; set; }
        public string ct_typename { get; set; }
        public bool ct_isactive { get; set; }


    }
}
