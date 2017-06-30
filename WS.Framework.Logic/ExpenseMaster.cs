using System;
using System.Collections.Generic;
using COM = WS.Framework.Common;
using ENT = WS.Framework.Entity;

namespace WS.Framework.Logic
{
    public  class ExpenseMaster
    {
        COM.SqlHelper SqlHelper = new COM.SqlHelper();

        public COM.MEMBERS.SQLReturnValue ExpenseMaster_Insert_Update(ENT.ExpenseMaster model)
        {
            //string DateFormat = COM.GeneralLogic.GenerateDateFormat(model.dm_dob.ToString());

            return SqlHelper.ExecuteProceduerWithValue("ExpenseMaster_Insert_Update", new object[,] {
                { "em_id", model.em_id }
                ,{ "em_adv_amount", model.em_adv_amount }
                ,{ "em_amount", model.em_amount }
                ,{ "em_attachment", model.em_attachment }
                ,{ "em_billable", model.em_billable }
                ,{ "em_cash_return", model.em_cash_return }
                ,{ "em_client_name", model.em_client_name }
                ,{ "em_company_paid", model.em_company_paid }
                ,{ "dm_pincode", model.em_expenseDate }
                ,{ "em_isactive", model.em_isactive }
                ,{ "em_mode_id", model.em_mode_id }
                ,{ "em_paid_by", model.em_paid_by }
                ,{ "em_payment_mode", model.em_payment_mode }
                ,{ "em_remark", model.em_remark }
                ,{ "em_total_exp", model.em_total_exp }
                ,{ "em_total_reimbursement", model.em_total_reimbursement }
                ,{ "em_type_id", model.em_type_id }
                ,{ "SystemDateTime", DateTime.Now }
                ,{ "CreatedBy", model.CreatedBy }
                ,{ "CreatedDateTime", DateTime.Now }
                ,{ "UpdatedBy", model.UpdatedBy }
                ,{ "UpdatedDateTime", DateTime.Now }
            }, 3);
        }

        public List<ENT.ExpenseMaster> ExpenseMaster_Get_GetAll(Guid em_id)
        {
            return SqlHelper.Get_GetAll_Data<ENT.ExpenseMaster>("ExpenseMaster_Get_GetAll", new object[,] { { "em_id", em_id } });
        }

        public COM.MEMBERS.SQLReturnValue ExpenseMaster_Delete_IsActive(Guid em_id, int ActionType)
        {
            return SqlHelper.ExecuteProceduerWithValue("ExpenseMaster_Delete_IsActive", new object[,] { { "em_id", em_id }, { "ActionType", ActionType } }, 3);
        }
    }
}
