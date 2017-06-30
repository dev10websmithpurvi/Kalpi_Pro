using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COM = WS.Framework.Common;
using ENT = WS.Framework.Entity;

namespace WS.Framework.Logic
{
    public class CityMaster 
    {
        COM.SqlHelper SqlHelper = new COM.SqlHelper();

        public COM.MEMBERS.SQLReturnValue CityMaster_Insert_Update(ENT.CityMaster model)
        {
            return SqlHelper.ExecuteProceduerWithValue("CityMaster_Insert_Update", new object[,] { 
                { "cm_id", model.cm_id }
                ,{ "cm_cityname", model.cm_cityname }
                ,{ "cm_countryid", model.cm_countryid }
                ,{ "cm_stateid", model.cm_stateid }
                ,{ "cm_isactive", model.cm_isactive }
                ,{ "SystemDateTime", DateTime.Now }
                ,{ "CreatedBy", model.CreatedBy }
                ,{ "CreatedDateTime", DateTime.Now }
                ,{ "UpdatedBy", model.UpdatedBy }
                ,{ "UpdatedDateTime", DateTime.Now }
            }, 3);
        }

        public List<ENT.CityMaster> CityMaster_Get_GetAll(Guid cm_id)
        {
            return SqlHelper.Get_GetAll_Data<ENT.CityMaster>("CityMaster_Get_GetAll", new object[,] { { "cm_id", cm_id } });
        }

        public List<ENT.CityMaster> CityMaster_GetAll_ByStateID(Guid cm_stateid)
        {
            return SqlHelper.Get_GetAll_Data<ENT.CityMaster>("CityMaster_GetAll_ByStateID", new object[,] { { "cm_stateid", cm_stateid } });
        }

        public COM.MEMBERS.SQLReturnValue CityMaster_Delete_IsActive(Guid cm_id, int ActionType)
        {
            return SqlHelper.ExecuteProceduerWithValue("CityMaster_Delete_IsActive", new object[,] { { "cm_id", cm_id }, { "ActionType", ActionType } }, 3);
        }
    }
}
