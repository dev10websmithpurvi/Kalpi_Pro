using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COM = WS.Framework.Common;
using ENT = WS.Framework.Entity;

namespace WS.Framework.Logic
{
    public class RetailerPayment
    {
        COM.SqlHelper SqlHelper = new COM.SqlHelper();

        public COM.MEMBERS.SQLReturnValue RetailerPayment_Insert(ENT.RetailerPayment model)
        {
            return SqlHelper.ExecuteProceduerWithValue("RetailerPayment_Insert", new object[,] {
                { "rp_id", model.rp_id }
                ,{ "rp_salesmanid", model.rp_salesmanid }
                ,{ "rp_retailoutletid", model.rp_retailoutletid }
                ,{ "rp_paymenttype", model.rp_paymenttype }
                ,{ "rp_amount", model.rp_amount }
                ,{ "rp_bankname", model.rp_bankname }
                ,{ "rp_chequedate",model.rp_chequedate }
                ,{ "rp_chequeno", model.rp_chequeno }
                ,{ "rp_chequeimage", model.rp_chequeimage }
                ,{ "rp_remarks", model.rp_remarks }
                ,{ "rp_paymentmethod", model.rp_paymentmethod }
                ,{ "SystemDateTime", DateTime.Now }
                ,{ "CreatedBy", model.CreatedBy }
                ,{ "CreatedDateTime", DateTime.Now }
                ,{ "UpdatedBy", model.UpdatedBy }
                ,{ "UpdatedDateTime", DateTime.Now }
            }, 3);
        }

        public List<ENT.RetailerPayment> RetailerPayment_GetAll()
        {
            return SqlHelper.Get_GetAll_Data<ENT.RetailerPayment>("RetailerPayment_GetAll", new object[,] { });
        }
    }
}
