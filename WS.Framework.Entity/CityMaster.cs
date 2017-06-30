using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.Framework.Common;
using System.ComponentModel.DataAnnotations;

namespace WS.Framework.Entity
{
    public class CityMaster : CommonEntity
    {
        [Key]
        public Guid cm_id { get; set; }
        public string cm_cityname { get; set; }
        public string sm_statename { get; set; }
        public Guid cm_countryid { get; set; }
        public Guid cm_stateid { get; set; }
        public bool cm_isactive { get; set; }
    }
}
