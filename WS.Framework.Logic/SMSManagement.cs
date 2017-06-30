using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COM = WS.Framework.Common;
using ENT = WS.Framework.Entity;

namespace WS.Framework.Logic
{
    public class SMSManagement
    {
        COM.SqlHelper SqlHelper = new COM.SqlHelper();

        public COM.MEMBERS.SQLReturnValue SMS_Insert_Update(ENT.SMSManagement model)
        {
            return SqlHelper.ExecuteProceduerWithValue("SMSManagement_Insert_Update", new object[,] { 
                { "sm_id", model.sm_id }
                ,{ "sm_isdefault", model.sm_isdefault }
                ,{ "sm_titlename", model.sm_titlename }
                ,{ "sm_smsapi", model.sm_smsapi }
                ,{ "sm_isacative", model.sm_isacative }
                ,{ "SystemDateTime", DateTime.Now }
                ,{ "CreatedBy", model.CreatedBy }
                ,{ "CreatedDateTime", DateTime.Now }
                ,{ "UpdatedBy", model.UpdatedBy }
                ,{ "UpdatedDateTime", DateTime.Now }
            }, 3);
        }

        public List<ENT.SMSManagement> SMSManagement_Get_GetAll(System.Guid sm_id)
        {
            return SqlHelper.Get_GetAll_Data<ENT.SMSManagement>("SMSManagement_Get_GetAll", new object[,] { { "sm_id", sm_id } });
        }

        public COM.MEMBERS.SQLReturnValue SMSManagement_Delete_IsActive_IsDefault(System.Guid sm_id,Int32 ActionType)
        {
            return SqlHelper.ExecuteProceduerWithValue("SMSManagement_Delete_IsActive_IsDefault", new object[,] { { "sm_id", sm_id }, { "ActionType", ActionType } }, 3);
        }
    }
}
