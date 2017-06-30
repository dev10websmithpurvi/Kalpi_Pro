using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.Framework.Common;
using System.ComponentModel.DataAnnotations;

namespace WS.Framework.Entity
{
    public class HeadquarterNotes : CommonEntity
    {
        [Key]
        public Guid hn_id { get; set; }
        public Guid hn_salesmanid { get; set; }
        public string hn_note { get; set; }
        public string smm_name { get; set; }
    }
}
