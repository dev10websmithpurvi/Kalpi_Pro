using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.Framework.Common;
using System.ComponentModel.DataAnnotations;

namespace WS.Framework.Entity
{
    public class ExpenseMaster : CommonEntity
    {
        [Key]
        public Guid em_id { get; set; }
        public Guid em_mode_id { get; set; }
        public Guid em_type_id { get; set; }
        public int em_amount { get; set; }
        public string em_payment_mode { get; set; }
        public string em_paid_by { get; set; }
        public string em_client_name { get; set; }
        public string em_remark { get; set; }
        public string em_attachment { get; set; }
        public int em_billable { get; set; }
        public int em_adv_amount { get; set; }
        public int em_cash_return { get; set; }
        public int em_total_exp { get; set; }
        public int em_company_paid {get; set; }
        public int em_total_reimbursement { get; set; }
        public DateTime em_expenseDate { get; set; }
        public bool em_isactive { get; set; }


    }
}
