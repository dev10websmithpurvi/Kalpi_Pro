using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COM = WS.Framework.Common;
using ENT = WS.Framework.Entity;

namespace WS.Framework.Logic
{
    public class CustomerTypeMaster
    {
        COM.SqlHelper SqlHelper = new COM.SqlHelper();

        public COM.MEMBERS.SQLReturnValue CustomerTypeMaster_Insert_Update(ENT.CustomerTypeMaster model)
        {
            return SqlHelper.ExecuteProceduerWithValue("CustomerTypeMaster_Insert_Update", new object[,] {
                { "ct_id", model.ct_id }
                ,{ "ct_typename", model.ct_typename }
                ,{ "ct_isactive", model.ct_isactive }
                ,{ "SystemDateTime", DateTime.Now }
                ,{ "CreatedBy", model.CreatedBy }
                ,{ "CreatedDateTime", DateTime.Now }
                ,{ "UpdatedBy", model.UpdatedBy }
                ,{ "UpdatedDateTime", DateTime.Now }
            }, 3);
        }

        public List<ENT.CustomerTypeMaster> CustomerTypeMaster_Get_GetAll(Guid ct_id)
        {
            return SqlHelper.Get_GetAll_Data<ENT.CustomerTypeMaster>("CustomerTypeMaster_Get_GetAll", new object[,] { { "ct_id", ct_id } });
        }

        public COM.MEMBERS.SQLReturnValue CustomerTypeMaster_Delete_IsActive(Guid ct_id, int ActionType)
        {
            return SqlHelper.ExecuteProceduerWithValue("CustomerTypeMaster_Delete_IsActive", new object[,] { { "ct_id", ct_id }, { "ActionType", ActionType } }, 3);
        }
    }
}
