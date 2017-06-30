using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COM = WS.Framework.Common;
using ENT = WS.Framework.Entity;

namespace WS.Framework.Logic
{
    public class RouteMaster
    {
        COM.SqlHelper SqlHelper = new COM.SqlHelper();

        public COM.MEMBERS.SQLReturnValue RouteMaster_Insert_Update(ENT.RouteMaster model)
        {
            return SqlHelper.ExecuteProceduerWithValue("RouteMaster_Insert_Update", new object[,] {
                { "rm_id", model.rm_id }
                ,{ "rm_stateid", model.rm_stateid }
                ,{ "rm_cityid", model.rm_cityid }
                ,{ "rm_areaname", model.rm_areaname }
                ,{ "rm_isactive", model.rm_isactive }
                ,{ "SystemDateTime", DateTime.Now }
                ,{ "CreatedBy", model.CreatedBy }
                ,{ "CreatedDateTime", DateTime.Now }
                ,{ "UpdatedBy", model.UpdatedBy }
                ,{ "UpdatedDateTime", DateTime.Now }
            }, 3);
        }

        public List<ENT.RouteMaster> RouteMaster_Get_GetAll(Guid rm_id)
        {
            return SqlHelper.Get_GetAll_Data<ENT.RouteMaster>("RouteMaster_Get_GetAll", new object[,] { { "rm_id", rm_id } });
        }

        public List<ENT.RouteMaster> RouteMaster_GetAll_ByCityID(Guid rm_cityid)
        {
            return SqlHelper.Get_GetAll_Data<ENT.RouteMaster>("RouteMaster_GetAll_ByCityID", new object[,] { { "rm_cityid", rm_cityid } });
        }

        public List<ENT.RouteMaster> RouteMaster_GetAll_ByDistibutorID(Guid rom_distibutorid)
        {
            return SqlHelper.Get_GetAll_Data<ENT.RouteMaster>("RouteMaster_GetAll_ByDistibutorID", new object[,] { { "rom_distibutorid", rom_distibutorid } });
        }

        public COM.MEMBERS.SQLReturnValue RouteMaster_Delete_IsActive(Guid rm_id, int ActionType)
        {
            return SqlHelper.ExecuteProceduerWithValue("RouteMaster_Delete_IsActive", new object[,] { { "rm_id", rm_id }, { "ActionType", ActionType } }, 3);
        }
    }
}
