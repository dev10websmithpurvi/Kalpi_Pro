using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COM = WS.Framework.Common;
using ENT = WS.Framework.Entity;

namespace WS.Framework.Logic
{
    public class SMTPServerManagement
    {
        COM.SqlHelper SqlHelper = new COM.SqlHelper();

        public COM.MEMBERS.SQLReturnValue SMTPServerManagement_Insert_Update(ENT.SMTPServerManagement model)
        {
            return SqlHelper.ExecuteProceduerWithValue("SMTPServerManagement_Insert_Update", new object[,] { 
                { "ssm_id", model.ssm_id }
                ,{ "ssm_displayname", model.ssm_displayname }
                ,{ "ssm_emailaddress", model.ssm_emailaddress }
                ,{ "ssm_password", model.ssm_password }
                ,{ "ssm_replaytomailaddress", model.ssm_replaytomailaddress }
                ,{ "ssm_smtpserver", model.ssm_smtpserver }
                ,{ "ssm_smtpport", model.ssm_smtpport }
                ,{ "ssm_enablessl", model.ssm_enablessl }
                ,{ "ssm_isdefault", model.ssm_isdefault }
                ,{ "ssm_isactive", model.ssm_isactive }
                ,{ "SystemDateTime", DateTime.Now }
                ,{ "CreatedBy", model.CreatedBy }
                ,{ "CreatedDateTime", DateTime.Now }
                ,{ "UpdatedBy", model.UpdatedBy }
                ,{ "UpdatedDateTime", DateTime.Now }
            }
            , 3);
        }

        public List<ENT.SMTPServerManagement> SMTPServerManagement_Get_GetAll(System.Guid ssm_id)
        {
            return SqlHelper.Get_GetAll_Data<ENT.SMTPServerManagement>("SMTPServerManagement_Get_GetAll", new object[,] { { "ssm_id", ssm_id } });
        }

        public COM.MEMBERS.SQLReturnValue SMTPServerManagement_Delete_IsActive_IsDefault_IsEnableSSL(System.Guid ssm_id, Int32 ActionType)
        {
            return SqlHelper.ExecuteProceduerWithValue("SMTPServerManagement_Delete_IsActive_IsDefault_IsEnableSSL", new object[,] { { "ssm_id", ssm_id }, { "ActionType", ActionType } }, 3);
        }
    }
}
