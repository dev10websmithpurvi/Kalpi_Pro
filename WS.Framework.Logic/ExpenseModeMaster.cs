using System;
using System.Collections.Generic;
using COM = WS.Framework.Common;
using ENT = WS.Framework.Entity;

namespace WS.Framework.Logic
{
    public class ExpenseModeMaster
    {
        COM.SqlHelper SqlHelper = new COM.SqlHelper();

        public COM.MEMBERS.SQLReturnValue ExpenseModeMaster_Insert_Update(ENT.ExpenseModeMaster model)
        {
            //string DateFormat = COM.GeneralLogic.GenerateDateFormat(model.dm_dob.ToString());

            return SqlHelper.ExecuteProceduerWithValue("ExpenseModeMaster_Insert_Update", new object[,] {
                { "em_id", model.em_id, }
                ,{ "em_modename", model.em_modename }
                ,{ "em_isactive", model.em_isactive }
                ,{ "SystemDateTime", DateTime.Now }
                ,{ "CreatedBy", model.CreatedBy }
                ,{ "CreatedDateTime", DateTime.Now }
                ,{ "UpdatedBy", model.UpdatedBy }
                ,{ "UpdatedDateTime", DateTime.Now }
            }, 3);
        }

        public List<ENT.ExpenseModeMaster> ExpenseModeMaster_Get_GetAll(Guid em_id)
        {
            return SqlHelper.Get_GetAll_Data<ENT.ExpenseModeMaster>("ExpenseModeMaster_Get_GetAll", new object[,] { { "em_id", em_id } });
        }


        public COM.MEMBERS.SQLReturnValue ExpenseModeMaster_Delete_IsActive(Guid em_id, int ActionType)
        {
            return SqlHelper.ExecuteProceduerWithValue("ExpenseModeMaster_Delete_IsActive", new object[,] { { "em_id", em_id }, { "ActionType", ActionType } }, 3);
        }
    }
}
