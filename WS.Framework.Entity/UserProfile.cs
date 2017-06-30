using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.Framework.Common;
using System.ComponentModel.DataAnnotations;

namespace WS.Framework.Entity
{
    public class UserProfile : CommonEntity
    {
        [Key]
        public Guid up_id { get; set; }
        public Guid up_userid { get; set; }
        public string up_name { get; set; }
        public string up_mobileno { get; set; }
        public int up_usertype { get; set; }
    }
}
