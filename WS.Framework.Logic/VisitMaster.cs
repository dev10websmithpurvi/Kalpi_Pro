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
   public class VisitMaster
    {
        COM.SqlHelper SqlHelper = new COM.SqlHelper();

        public COM.MEMBERS.SQLReturnValue VisitMaster_Insert_Update(ENT.VisitMaster model,DataTable dt )
        {
            return SqlHelper.ExecuteProcedureWithParam_Datatable("VisitMaster_Insert_Update", new object[,] {
                { "vm_id", model.vm_id }
                ,{ "vm_VisitDate", model.vm_VisitDate }
                ,{ "vm_retailoutletid", model.vm_retailoutletid }
                ,{ "vm_customertypeid", model.vm_customertypeid }
                ,{ "vm_Other_customertype", model.vm_Other_customertype }
                ,{ "vm_WithWhom", model.vm_WithWhom }
                ,{ "vm_categoryid", model.vm_categoryid }
                ,{ "vm_distibutorid", model.vm_distibutorid }
                ,{ "vm_Remarks", model.vm_Remarks }
                ,{ "vm_visitpurposeid", model.vm_visitpurposeid }
                ,{ "vm_other_visitpurpose", model.vm_other_visitpurpose }
                ,{ "vm_visittypeid", model.vm_visittypeid }
                ,{ "vm_PersonMetatCompany", model.vm_PersonMetatCompany }
                ,{ "vm_visitfile", model.vm_visitfile }
                ,{ "vm_isactive", model.vm_isactive }

                ,{ "SystemDateTime", DateTime.Now }
                ,{ "CreatedBy", model.CreatedBy }
                ,{ "CreatedDateTime", DateTime.Now }
                ,{ "UpdatedBy", model.UpdatedBy }
                ,{ "UpdatedDateTime", DateTime.Now }
            },dt, "VisitProductDetailData", 3);
        }

        public COM.MEMBERS.SQLReturnValue VisitDocument_Insert_Update(ENT.VisitMasterDocument model)
        {
            return SqlHelper.ExecuteProceduerWithValue("VisitDocument_Insert_Update", new object[,] {
                { "vm_id", model.vm_id }
               ,{ "vm_visitfile", model.vm_visitfile }
            }, 3);
        }

        public List<ENT.VisitMaster> VisitMaster_Get_GetAll(Guid vm_id)
        {
            return SqlHelper.Get_GetAll_Data<ENT.VisitMaster>("VisitMaster_Get_GetAll", new object[,] { { "vm_id", vm_id } });
        }

        public COM.MEMBERS.SQLReturnValue VisitMaster_Delete_IsActive(Guid vm_id, int ActionType)
        {
            return SqlHelper.ExecuteProceduerWithValue("VisitMaster_Delete_IsActive", new object[,] { { "vm_id", vm_id }, { "ActionType", ActionType } }, 3);
        }
    }
}
 