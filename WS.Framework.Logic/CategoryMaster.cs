using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COM = WS.Framework.Common;
using ENT = WS.Framework.Entity;

namespace WS.Framework.Logic
{
    public class CategoryMaster
    {
        COM.SqlHelper SqlHelper = new COM.SqlHelper();

        public COM.MEMBERS.SQLReturnValue CategoryMaster_Insert_Update(ENT.CategoryMaster model)
        {
            return SqlHelper.ExecuteProceduerWithValue("CategoryMaster_Insert_Update", new object[,] {
                { "cm_id", model.cm_id }
                ,{ "cm_name", model.cm_name }
                ,{ "cm_isactive", model.cm_isactive }
                ,{ "SystemDateTime", DateTime.Now }
                ,{ "CreatedBy", model.CreatedBy }
                ,{ "CreatedDateTime", DateTime.Now }
                ,{ "UpdatedBy", model.UpdatedBy }
                ,{ "UpdatedDateTime", DateTime.Now }
            }, 3);
        }

        public List<ENT.CategoryMaster> CategoryMaster_Get_GetAll(Guid cm_id)
        {
            return SqlHelper.Get_GetAll_Data<ENT.CategoryMaster>("CategoryMaster_Get_GetAll", new object[,] { { "cm_id", cm_id } });
        }

        public COM.MEMBERS.SQLReturnValue CategoryMaster_Delete_IsActive(Guid cm_id, int ActionType)
        {
            return SqlHelper.ExecuteProceduerWithValue("CategoryMaster_Delete_IsActive", new object[,] { { "cm_id", cm_id }, { "ActionType", ActionType } }, 3);
        }
    }
}
