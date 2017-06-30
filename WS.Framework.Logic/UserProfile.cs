using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COM = WS.Framework.Common;
using ENT = WS.Framework.Entity;

namespace WS.Framework.Logic
{
    public class UserProfile
    {
        COM.SqlHelper SqlHelper = new COM.SqlHelper();

        public COM.MEMBERS.SQLReturnValue UserProfile_Insert_Update(ENT.UserProfile model)
        {
            return SqlHelper.ExecuteProceduerWithValue("UserProfile_Insert_Update", new object[,] {
                { "up_id", model.up_id }
                ,{ "up_userid", model.up_userid }
                ,{ "up_name", model.up_name }
                ,{ "up_mobileno", model.up_mobileno }
                ,{ "up_usertype", model.up_usertype }
                ,{ "SystemDateTime", DateTime.Now }
                ,{ "CreatedBy", model.CreatedBy }
                ,{ "CreatedDateTime", DateTime.Now }
                ,{ "UpdatedBy", model.UpdatedBy }
                ,{ "UpdatedDateTime", DateTime.Now }
            }, 3);
        }

        public ENT.UserProfile UserProfile_Get(Guid up_userid,string deviceid)
        {
            return SqlHelper.Get_GetAll_Data<ENT.UserProfile>("UserProfile_Get1", new object[,] { { "up_userid", up_userid }, { "up_deviceid", deviceid } }).FirstOrDefault();
        }
    }
}
