using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COM = WS.Framework.Common;
using ENT = WS.Framework.Entity;

namespace WS.Framework.Logic
{
    public class VisitPurposeMaster
    {
        COM.SqlHelper SqlHelper = new COM.SqlHelper();

        public COM.MEMBERS.SQLReturnValue VisitPurposeMaster_Insert_Update(ENT.VisitPurposeMaster model)
        {
            return SqlHelper.ExecuteProceduerWithValue("VisitPurposeMaster_Insert_Update", new object[,] {
                 { "vp_id", model.vp_id }
                ,{ "vp_purposename", model.vp_purposename }
                ,{ "vp_isactive", model.vp_isactive }
                ,{ "SystemDateTime", DateTime.Now }
                ,{ "CreatedBy", model.CreatedBy }
                ,{ "CreatedDateTime", DateTime.Now }
                ,{ "UpdatedBy", model.UpdatedBy }
                ,{ "UpdatedDateTime", DateTime.Now }
            }, 3);
        }

        public List<ENT.VisitPurposeMaster> VisitPurposeMaster_Get_GetAll(Guid vp_id)
        {
            return SqlHelper.Get_GetAll_Data<ENT.VisitPurposeMaster>("VisitPurposeMaster_Get_GetAll", new object[,] { { "vp_id", vp_id } });
        }
        public COM.MEMBERS.SQLReturnValue VisitPurposeMaster_Delete_IsActive(Guid vp_id, int ActionType)
        {
            return SqlHelper.ExecuteProceduerWithValue("VisitPurposeMaster_Delete_IsActive", new object[,] { { "vp_id", vp_id }, { "ActionType", ActionType } }, 3);
        }
    }
}
