using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COM = WS.Framework.Common;
using ENT = WS.Framework.Entity;

namespace WS.Framework.Logic
{
    public class CustomeScheme
    {
        COM.SqlHelper SqlHelper = new COM.SqlHelper();

        public COM.MEMBERS.SQLReturnValue CustomeScheme_Insert(ENT.CustomeScheme model)
        {
            COM.MEMBERS.SQLReturnValue mRes = new COM.MEMBERS.SQLReturnValue();
            mRes = SqlHelper.ExecuteProceduerWithValue("CustomeScheme_Insert", new object[,] {
                { "cs_id", model.cs_id }
                ,{ "cs_salesmanid", model.cs_salesmanid }
                ,{ "cs_retaileoutletid", model.cs_retaileoutletid }
                ,{ "cs_qty", model.cs_qty }
                ,{ "cs_freeqty", model.cs_freeqty }
                ,{ "cs_rate", model.cs_rate }
                ,{ "cs_remarsk", model.cs_remarsk }
                ,{ "cs_status", model.cs_status }
                ,{ "cs_reg_no", model.cs_reg_no }
                ,{ "cs_distributorid", model.cs_distributorid }
                ,{ "cs_title", model.cs_title }
                ,{ "SystemDateTime", DateTime.Now }
                ,{ "CreatedBy", model.CreatedBy }
                ,{ "CreatedDateTime", DateTime.Now }
                ,{ "UpdatedBy", model.UpdatedBy }
                ,{ "UpdatedDateTime", DateTime.Now }
            }, 3);
            return mRes;
        }

        public COM.MEMBERS.SQLReturnValue CustomeScheme_IsApprove(Guid cs_id,int cs_status)
        {
            return SqlHelper.ExecuteProceduerWithValue("CustomeScheme_IsApprove", new object[,] { { "cs_id", cs_id }, { "cs_status", cs_status } }, 3);
        }
        public COM.MEMBERS.SQLReturnValue CustomeScheme_ChangeType(Guid cs_id, int cs_status)
        {
            return SqlHelper.ExecuteProceduerWithValue("CustomeScheme_ChangeType", new object[,] { { "cs_id", cs_id }, { "cs_status", cs_status } }, 3);
        }
        public List<ENT.CustomeScheme> CustomeScheme_Get_GetAll(Guid cs_id)
        {
            return SqlHelper.Get_GetAll_Data<ENT.CustomeScheme>("CustomeScheme_Get_GetAll", new object[,] { { "cs_id", cs_id } });
        }

        public List<ENT.CustomeScheme> CustomeScheme_GetAll_PendingApprove()
        {
            return SqlHelper.Get_GetAll_Data<ENT.CustomeScheme>("CustomeScheme_GetAll_PendingApprove", new object[,] { });
        }
    }
}
