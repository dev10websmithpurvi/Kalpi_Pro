using System;
using System.Collections.Generic;
using COM = WS.Framework.Common;
using ENT = WS.Framework.Entity;

namespace WS.Framework.Logic
{
    public class ExpenseTypeMaster
    {
        COM.SqlHelper SqlHelper = new COM.SqlHelper();

        public COM.MEMBERS.SQLReturnValue ExpenseTypeMaster_Insert_Update(ENT.ExpenseTypeMaster model)
        {
            //string DateFormat = COM.GeneralLogic.GenerateDateFormat(model.dm_dob.ToString());

            return SqlHelper.ExecuteProceduerWithValue("ExpenseTypeMaster_Insert_Update", new object[,] {
                 { "et_id", model.et_id }
                ,{ "et_typename", model.et_typename }
                ,{ "et_isactive", model.et_isactive }
                ,{ "SystemDateTime", DateTime.Now }
                ,{ "CreatedBy", model.CreatedBy }
                ,{ "CreatedDateTime", DateTime.Now }
                ,{ "UpdatedBy", model.UpdatedBy }
                ,{ "UpdatedDateTime", DateTime.Now }
            }, 3);
        }

        public List<ENT.ExpenseTypeMaster> ExpenseTypeMaster_Get_GetAll(Guid et_id)
        {
            return SqlHelper.Get_GetAll_Data<ENT.ExpenseTypeMaster>("ExpenseTypeMaster_Get_GetAll", new object[,] { { "et_id", et_id } });
        }

        public COM.MEMBERS.SQLReturnValue ExpenseTypeMaster_Delete_IsActive(Guid et_id, int ActionType)
        {
            return SqlHelper.ExecuteProceduerWithValue("ExpenseTypeMaster_Delete_IsActive", new object[,] { { "et_id", et_id }, { "ActionType", ActionType } }, 3);
        }
    }
}
