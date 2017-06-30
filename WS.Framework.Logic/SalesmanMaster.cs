using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COM = WS.Framework.Common;
using ENT = WS.Framework.Entity;

namespace WS.Framework.Logic
{
    public class SalesmanMaster
    {
        COM.SqlHelper SqlHelper = new COM.SqlHelper();

        public COM.MEMBERS.SQLReturnValue SalesmanMaster_Insert_Update(ENT.SalesmanMaster model)
        {
            //string DateFormat = COM.GeneralLogic.GenerateDateFormat(model.smm_dob.ToString());

            return SqlHelper.ExecuteProceduerWithValue("SalesmanMaster_Insert_Update", new object[,] {
                { "smm_id", model.smm_id }
                ,{ "smm_userid", model.smm_userid }
                ,{ "smm_name", model.smm_name }
                ,{ "smm_emailid", model.smm_emailid }
                ,{ "smm_mobileno", model.smm_mobileno }
                ,{ "smm_address", model.smm_address }
                ,{ "smm_cityid", model.smm_cityid }
                ,{ "smm_stateid", model.smm_stateid }
                ,{ "smm_pincode", model.smm_pincode }
                ,{ "smm_dob", model.smm_dob }
                ,{ "smm_isactive", model.smm_isactive }
                ,{ "SystemDateTime", DateTime.Now }
                ,{ "CreatedBy", model.CreatedBy }
                ,{ "CreatedDateTime", DateTime.Now }
                ,{ "UpdatedBy", model.UpdatedBy }
                ,{ "UpdatedDateTime", DateTime.Now }
            }, 3);
        }

        public List<ENT.SalesmanMaster> SalesmanMaster_Get_GetAll(Guid smm_id)
        {
            return SqlHelper.Get_GetAll_Data<ENT.SalesmanMaster>("SalesmanMaster_Get_GetAll", new object[,] { { "smm_id", smm_id } });
        }

        public COM.MEMBERS.SQLReturnValue SalesmanMaster_Delete_IsActive(Guid smm_id, int ActionType)
        {
            return SqlHelper.ExecuteProceduerWithValue("SalesmanMaster_Delete_IsActive", new object[,] { { "smm_id", smm_id }, { "ActionType", ActionType } }, 3);
        }
    }
}
