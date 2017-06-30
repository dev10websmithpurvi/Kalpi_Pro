using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COM = WS.Framework.Common;
using ENT = WS.Framework.Entity;

namespace WS.Framework.Logic
{
  public  class VisitTypeMaster
    {
        COM.SqlHelper SqlHelper = new COM.SqlHelper();

        public COM.MEMBERS.SQLReturnValue VisitTypeMaster_Insert_Update(ENT.VisitTypeMaster model)
        {
            return SqlHelper.ExecuteProceduerWithValue("VisitTypeMaster_Insert_Update", new object[,] {
                 { "vt_id", model.vt_id }
                ,{ "vt_typename", model.vt_typename }
                ,{ "vt_isactive", model.vt_isactive }
                ,{ "SystemDateTime", DateTime.Now }
                ,{ "CreatedBy", model.CreatedBy }
                ,{ "CreatedDateTime", DateTime.Now }
                ,{ "UpdatedBy", model.UpdatedBy }
                ,{ "UpdatedDateTime", DateTime.Now }
            }, 3);
        }

        public List<ENT.VisitTypeMaster> VisitTypeMaster_Get_GetAll(Guid vt_id)
        {
            return SqlHelper.Get_GetAll_Data<ENT.VisitTypeMaster>("VisitTypeMaster_Get_GetAll", new object[,] { { "vt_id", vt_id } });
        }
     
        public COM.MEMBERS.SQLReturnValue VisitTypeMaster_Delete_IsActive(Guid vt_id, int ActionType)
        {
            return SqlHelper.ExecuteProceduerWithValue("VisitTypeMaster_Delete_IsActive", new object[,] { { "vt_id", vt_id }, { "ActionType", ActionType } }, 3);
        }
    }
}
