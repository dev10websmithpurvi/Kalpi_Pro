using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COM = WS.Framework.Common;
using ENT = WS.Framework.Entity;

namespace WS.Framework.Logic
{
    public class SchemeBuilder
    {
        COM.SqlHelper SqlHelper = new COM.SqlHelper();

        public COM.MEMBERS.SQLReturnValue SchemeBuilder_Insert_Update(ENT.SchemeBuilder model)
        {
            return SqlHelper.ExecuteProceduerWithValue("SchemeBuilder_Insert_Update", new object[,] {
                { "sb_id", model.sb_id }
                ,{ "sb_schemename", model.sb_schemename }
                ,{ "sb_buyitems", model.sb_buyitems }
                ,{ "sb_getitems", model.sb_getitems }
                ,{ "sb_isactive", model.sb_isactive }
                ,{ "SystemDateTime", DateTime.Now }
                ,{ "CreatedBy", model.CreatedBy }
                ,{ "CreatedDateTime", DateTime.Now }
                ,{ "UpdatedBy", model.UpdatedBy }
                ,{ "UpdatedDateTime", DateTime.Now }
            }, 3);
        }

        public List<ENT.SchemeBuilder> SchemeBuilder_Get_GetAll(Guid sb_id)
        {
            return SqlHelper.Get_GetAll_Data<ENT.SchemeBuilder>("SchemeBuilder_Get_GetAll", new object[,] { { "sb_id", sb_id } });
        }

        public COM.MEMBERS.SQLReturnValue SchemeBuilder_Delete_IsActive(Guid sb_id, int ActionType)
        {
            return SqlHelper.ExecuteProceduerWithValue("SchemeBuilder_Delete_IsActive", new object[,] { { "sb_id", sb_id }, { "ActionType", ActionType } }, 3);
        }
        
    }
}
