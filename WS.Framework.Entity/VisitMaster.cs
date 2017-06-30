using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.Framework.Common;
using System.ComponentModel.DataAnnotations;

namespace WS.Framework.Entity
{
    public class VisitMaster : CommonEntity
    {
        [Key]

        [Required]
        [MinLength(36)]
        public Guid vm_id { get; set; }

        [Required]
        public DateTime vm_VisitDate { get; set; }

        [MinLength(36)]
        public Guid vm_retailoutletid { get; set; }

        [Required]
        [MinLength(36)]
        public Guid vm_customertypeid { get; set; }

        [StringLength(50)]
        public string vm_Other_customertype { get; set; }

        [Required]
        [MinLength(36)]
        public Guid vm_WithWhom { get; set; }

        [Required]
        [MinLength(36)]
        public Guid vm_categoryid { get; set; }

        
        [MinLength(36)]
        public Guid vm_distibutorid { get; set; }

        [MaxLength(200)]
        public string vm_Remarks { get; set; }

        [Required]
        [MinLength(36)]
        public Guid vm_visitpurposeid { get; set; }

        public string vm_other_visitpurpose { get; set; }

        [Required]
        [MinLength(36)]
        public Guid vm_visittypeid { get; set; }

        [MaxLength(100)]
        public string vm_PersonMetatCompany { get; set; }

        public string vm_visitfile { get; set; }

        [Required]
        public bool vm_isactive { get; set; }

        public byte[] vm_imagebyte { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "visit Product array")]
        public VisitProductDetailData[] _VisitProductDetailData;

        public string ct_typename { get; set; }
        public string smm_name { get; set; }
        public string vp_purposename { get; set; }
        public string vt_typename { get; set; }
        public string rom_name { get; set; }
        public string dm_name { get; set; }
    }
    public class VisitProductDetailData
    {
        [Required]
        [Display(Name = "visit Product id")]
        public Guid ProductIDF { get; set; }
    }

    public class VisitMasterDocument : CommonEntity
    {
        [Key]
        [Required]
        [Display(Name = "visit id")]
        [MaxLength(36)]
        public Guid vm_id { get; set; }

        [Required]
        [Display(Name = "image file name with extension")]
        public string vm_visitfile { get; set; }

        [Key]
        [Required]
        [Display(Name = "image byte array")]
        public byte[] vm_imagebyte { get; set; }
    }


}
