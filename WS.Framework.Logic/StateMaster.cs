using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COM = WS.Framework.Common;
using ENT = WS.Framework.Entity;

namespace WS.Framework.Logic
{
    public class StateMaster
    {
        COM.SqlHelper SqlHelper = new COM.SqlHelper();

        public COM.MEMBERS.SQLReturnValue StateMaster_Insert_Update(ENT.StateMaster model)
        {
            return SqlHelper.ExecuteProceduerWithValue("StateMaster_Insert_Update", new object[,] {
                { "sm_id", model.sm_id }
                ,{ "sm_statename", model.sm_statename }
                ,{ "sm_countryid", model.sm_countryid }
                ,{ "sm_isactive", model.sm_isactive }
                ,{ "SystemDateTime", DateTime.Now }
                ,{ "CreatedBy", model.CreatedBy }
                ,{ "CreatedDateTime", DateTime.Now }
                ,{ "UpdatedBy", model.UpdatedBy }
                ,{ "UpdatedDateTime", DateTime.Now }
            }, 3);
        }

        public List<ENT.StateMaster> StateMaster_Get_GetAll(Guid sm_id)
        {
            return SqlHelper.Get_GetAll_Data<ENT.StateMaster>("StateMaster_Get_GetAll", new object[,] { { "sm_id", sm_id } });
        }

        public COM.MEMBERS.SQLReturnValue StateMaster_Delete_IsActive(Guid sm_id, int ActionType)
        {
            return SqlHelper.ExecuteProceduerWithValue("StateMaster_Delete_IsActive", new object[,] { { "sm_id", sm_id }, { "ActionType", ActionType } }, 3);
        }
    }
}
