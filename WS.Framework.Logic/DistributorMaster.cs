using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COM = WS.Framework.Common;
using ENT = WS.Framework.Entity;

namespace WS.Framework.Logic
{
    public class DistributorMaster
    {
        COM.SqlHelper SqlHelper = new COM.SqlHelper();

        public COM.MEMBERS.SQLReturnValue DistributorMaster_Insert_Update(ENT.DistributorMaster model)
        {
            //string DateFormat = COM.GeneralLogic.GenerateDateFormat(model.dm_dob.ToString());

            return SqlHelper.ExecuteProceduerWithValue("DistributorMaster_Insert_Update", new object[,] {
                { "dm_id", model.dm_id }
                ,{ "dm_userid", model.dm_userid }
                ,{ "dm_superstockisid", model.dm_superstockisid }
                ,{ "dm_name", model.dm_name }
                ,{ "dm_emailid", model.dm_emailid }
                ,{ "dm_mobileno", model.dm_mobileno }
                ,{ "dm_address", model.dm_address }
                ,{ "dm_cityid", model.dm_cityid }
                ,{ "dm_stateid", model.dm_stateid }
                ,{ "dm_pincode", model.dm_pincode }
                ,{ "dm_dob", model.dm_dob }
                ,{ "dm_isactive", model.dm_isactive }
                ,{ "SystemDateTime", DateTime.Now }
                ,{ "CreatedBy", model.CreatedBy }
                ,{ "CreatedDateTime", DateTime.Now }
                ,{ "UpdatedBy", model.UpdatedBy }
                ,{ "UpdatedDateTime", DateTime.Now }
            }, 3);
        }

        public List<ENT.DistributorMaster> DistributorMaster_Get_GetAll(Guid dm_id)
        {
            return SqlHelper.Get_GetAll_Data<ENT.DistributorMaster>("DistributorMaster_Get_GetAll", new object[,] { { "dm_id", dm_id } });
        }

        public List<ENT.DistributorMaster> DistributorMaster_GetAll_BySuperstockistID(Guid dm_superstockisid)
        {
            return SqlHelper.Get_GetAll_Data<ENT.DistributorMaster>("DistributorMaster_GetAll_BySuperstockistID", new object[,] { { "dm_superstockisid", dm_superstockisid } });
        }

        public COM.MEMBERS.SQLReturnValue DistributorMaster_Delete_IsActive(Guid dm_id, int ActionType)
        {
            return SqlHelper.ExecuteProceduerWithValue("DistributorMaster_Delete_IsActive", new object[,] { { "dm_id", dm_id }, { "ActionType", ActionType } }, 3);
        }
    }
}
