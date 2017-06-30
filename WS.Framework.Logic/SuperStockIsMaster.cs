using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COM = WS.Framework.Common;
using ENT = WS.Framework.Entity;

namespace WS.Framework.Logic
{
    public class SuperStockIsMaster
    {
        COM.SqlHelper SqlHelper = new COM.SqlHelper();

        public COM.MEMBERS.SQLReturnValue SuperStockIsMaster_Insert_Update(ENT.SuperStockIsMaster model)
        {
            //string DateFormat = COM.GeneralLogic.GenerateDateFormat(model.ss_dob.ToString());

            return SqlHelper.ExecuteProceduerWithValue("SuperStockIsMaster_Insert_Update", new object[,] {
                { "ss_id", model.ss_id }
                ,{ "ss_userid", model.ss_userid }
                ,{ "ss_name", model.ss_name }
                ,{ "ss_emailid", model.ss_emailid }
                ,{ "ss_mobileno", model.ss_mobileno }
                ,{ "ss_address", model.ss_address }
                ,{ "ss_cityid", model.ss_cityid }
                ,{ "ss_stateid", model.ss_stateid }
                ,{ "ss_pincode", model.ss_pincode }
                ,{ "ss_dob", model.ss_dob }
                ,{ "ss_isactive", model.ss_isactive }
                ,{ "SystemDateTime", DateTime.Now }
                ,{ "CreatedBy", model.CreatedBy }
                ,{ "CreatedDateTime", DateTime.Now }
                ,{ "UpdatedBy", model.UpdatedBy }
                ,{ "UpdatedDateTime", DateTime.Now }
            }, 3);
        }

        public List<ENT.SuperStockIsMaster> SuperStockIsMaster_Get_GetAll(Guid ss_id)
        {
            return SqlHelper.Get_GetAll_Data<ENT.SuperStockIsMaster>("SuperStockIsMaster_Get_GetAll", new object[,] { { "ss_id", ss_id } });
        }

        public List<ENT.SuperStockIsMaster> SuperStockIsMaster_GetAll_ByCityID(Guid ss_cityid)
        {
            return SqlHelper.Get_GetAll_Data<ENT.SuperStockIsMaster>("SuperStockIsMaster_GetAll_ByCityID", new object[,] { { "ss_cityid", ss_cityid } });
        }

        public COM.MEMBERS.SQLReturnValue SuperStockIsMaster_Delete_IsActive(Guid ss_id, int ActionType)
        {
            return SqlHelper.ExecuteProceduerWithValue("SuperStockIsMaster_Delete_IsActive", new object[,] { { "ss_id", ss_id }, { "ActionType", ActionType } }, 3);
        }
    }
}
