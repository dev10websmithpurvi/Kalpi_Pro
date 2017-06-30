using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.Framework.Common;
using System.ComponentModel.DataAnnotations;

namespace WS.Framework.Entity
{
    public class RetailerPayment : CommonEntity
    {
        [Key]
        public Guid rp_id { get; set; }
        public Guid rp_salesmanid { get; set; }
        public Guid rp_retailoutletid { get; set; }
        public int rp_paymenttype { get; set; }
        public int rp_amount { get; set; }
        public string rp_bankname { get; set; }
        public DateTime? rp_chequedate { get; set; }
        public string rp_chequeno { get; set; }

        public byte[] rp_imagebyte { get; set; }

        public string rp_chequeimage { get; set; }
        public string rp_remarks { get; set; }
        public string smm_name { get; set; }
        public string rom_name { get; set; }
        public string rp_paymenttypename { get; set; }
        public int rp_paymentmethod { get; set; }
        public string rp_paymentmethodname { get; set; }
    }
}
