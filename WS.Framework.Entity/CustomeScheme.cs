using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.Framework.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WS.Framework.Entity
{
    public class CustomeScheme : CommonEntity
    {
        [Key]
        [Required]
        public Guid cs_id { get; set; }
        [Required]
        public Guid cs_salesmanid { get; set; }
        [Required]
        public Guid cs_retaileoutletid { get; set; }
        [Required]
        [Range(0, 1000000, ErrorMessage = "Quantity must be between 0 and 1000000")]
        public int cs_qty { get; set; }
        [Range(0, 1000000, ErrorMessage = "Free Quantity must be between 0 and 1000000")]
        public int cs_freeqty { get; set; }
        [Range(0, 1000000, ErrorMessage = "Rate must be between 0 and 1000000")]
        public int cs_rate { get; set; }

        [Required]
        [MaxLength(200)]
        public string cs_remarsk { get; set; }

        [RegularExpression("^[0-9]{0,1}", ErrorMessage = "Status must 0 or 1")]
        public int cs_status { get; set; }
        public int cs_type { get; set; }

        public string smm_name { get; set; }
        public string rom_name { get; set; }
        public string dm_name { get; set; }

        
        public string cs_reg_no { get; set; }
        [Required]
        public Guid cs_distributorid { get; set; }
        [Required]
        public String cs_title { get; set; }
    }
}
