using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COM = WS.Framework.Common;
using ENT = WS.Framework.Entity;

namespace WS.Framework.Logic
{
    public class CompanyProfile
    {
        COM.SqlHelper SqlHelper = new COM.SqlHelper();

        public COM.MEMBERS.SQLReturnValue CompanyProfile_Insert_Update(ENT.CompanyProfile model)
        {
            return SqlHelper.ExecuteProceduerWithValue("CompanyProfile_Insert_Update", new object[,] {
                { "cp_id", model.cp_id }
                ,{ "cp_companyname", model.cp_companyname }
                ,{ "cp_mobileno", model.cp_mobileno }
                ,{ "cp_officeno", model.cp_officeno }
                ,{ "cp_emailid", model.cp_emailid }
                ,{ "cp_ownername", model.cp_ownername }
                ,{ "SystemDateTime", DateTime.Now }
                ,{ "CreatedBy", model.CreatedBy }
                ,{ "CreatedDateTime", DateTime.Now }
                ,{ "UpdatedBy", model.UpdatedBy }
                ,{ "UpdatedDateTime", DateTime.Now }
            }, 3);
        }

        public List<ENT.CompanyProfile> CompanyProfile_Get()
        {
            return SqlHelper.Get_GetAll_Data<ENT.CompanyProfile>("CompanyProfile_Get", new object[,] { });
        }
    }
}
