using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COM = WS.Framework.Common;
using ENT = WS.Framework.Entity;

namespace WS.Framework.Logic
{
    public class ProductMaster
    {
        COM.SqlHelper SqlHelper = new COM.SqlHelper();

        public COM.MEMBERS.SQLReturnMessageNValue ProductMaster_Insert_Update(ENT.ProductMaster model)
        {
            return SqlHelper.ExecuteProceduerWithMessageNValue("ProductMaster_Insert_Update", new object[,] {
                { "pm_id", model.pm_id }
                ,{ "pm_name", model.pm_name }
                ,{ "pm_price", model.pm_price }
                ,{ "pm_categoryid", model.pm_categoryid }
                ,{ "pm_productimage", model.pm_productimage }
                ,{ "pm_isactive", model.pm_isactive }
                ,{ "SystemDateTime", DateTime.Now }
                ,{ "CreatedBy", model.CreatedBy }
                ,{ "CreatedDateTime", DateTime.Now }
                ,{ "UpdatedBy", model.UpdatedBy }
                ,{ "UpdatedDateTime", DateTime.Now }
            }, 1);
        }

        public List<ENT.ProductMaster> ProductMaster_Get_GetAll(Guid pm_id)
        {
            return SqlHelper.Get_GetAll_Data<ENT.ProductMaster>("ProductMaster_Get_GetAll", new object[,] { { "pm_id", pm_id } });
        }

        public List<ENT.ProductMaster> ProductMaster_GetAll_Service()
        {
            return SqlHelper.Get_GetAll_Data<ENT.ProductMaster>("ProductMaster_GetAll_Service", new object[,] { });
        }

        public COM.MEMBERS.SQLReturnValue ProductMaster_Delete_IsActive(Guid pm_id, int ActionType)
        {
            return SqlHelper.ExecuteProceduerWithValue("ProductMaster_Delete_IsActive", new object[,] { { "pm_id", pm_id }, { "ActionType", ActionType } }, 3);
        }
    }
}
