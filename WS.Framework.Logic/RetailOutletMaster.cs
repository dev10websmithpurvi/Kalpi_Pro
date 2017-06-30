using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COM = WS.Framework.Common;
using ENT = WS.Framework.Entity;

namespace WS.Framework.Logic
{
    public class RetailOutletMaster
    {
        COM.SqlHelper SqlHelper = new COM.SqlHelper();

        public COM.MEMBERS.SQLReturnValue RetailOutletMaster_Insert_Update(ENT.RetailOutletMaster model)
        {
            //string DateFormat = COM.GeneralLogic.GenerateDateFormat(model.rom_dob.ToString());

            return SqlHelper.ExecuteProceduerWithValue("RetailOutletMaster_Insert_Update", new object[,] {
                { "rom_id", model.rom_id }
                ,{ "rom_userid", model.rom_userid }
                ,{ "rom_name", model.rom_name }
                ,{ "rom_distibutorid", model.rom_distibutorid }
                ,{ "rom_emailid", model.rom_emailid }
                ,{ "rom_mobileno", model.rom_mobileno }
                ,{ "rom_stateid", model.rom_stateid }
                ,{ "rom_cityid", model.rom_cityid }
                ,{ "rom_areaid", model.rom_areaid }
                ,{ "rom_address", model.rom_address }
                ,{ "rom_pincode", model.rom_pincode }
                ,{ "rom_dob", model.rom_dob }
                ,{ "rom_isactive", model.rom_isactive }
                ,{ "SystemDateTime", DateTime.Now }
                ,{ "CreatedBy", model.CreatedBy }
                ,{ "CreatedDateTime", DateTime.Now }
                ,{ "UpdatedBy", model.UpdatedBy }
                ,{ "UpdatedDateTime", DateTime.Now }
            }, 3);
        }

        public COM.MEMBERS.SQLReturnValue RetailOutletMaster_Insert_Update_Service(ENT.RetailOutletMaster model)
        {
            return SqlHelper.ExecuteProceduerWithValue("RetailOutletMaster_Insert_Update", new object[,] {
                { "rom_id", model.rom_id }
                ,{ "rom_userid", model.rom_userid }
                ,{ "rom_name", model.rom_name }
                ,{ "rom_distibutorid", model.rom_distibutorid }
                ,{ "rom_emailid", model.rom_emailid }
                ,{ "rom_mobileno", model.rom_mobileno }
                ,{ "rom_stateid", model.rom_stateid }
                ,{ "rom_cityid", model.rom_cityid }
                ,{ "rom_areaid", model.rom_areaid }
                ,{ "rom_address", model.rom_address }
                ,{ "rom_pincode", model.rom_pincode }
                ,{ "rom_dob", model.rom_dob }
                ,{ "rom_isactive", model.rom_isactive }
                ,{ "SystemDateTime", DateTime.Now }
                ,{ "CreatedBy", model.CreatedBy }
                ,{ "CreatedDateTime", DateTime.Now }
                ,{ "UpdatedBy", model.UpdatedBy }
                ,{ "UpdatedDateTime", DateTime.Now }
            }, 3);
        }

        public List<ENT.RetailOutletMaster> RetailOutletMaster_Get_GetAll(Guid rom_id)
        {
            return SqlHelper.Get_GetAll_Data<ENT.RetailOutletMaster>("RetailOutletMaster_Get_GetAll", new object[,] { { "rom_id", rom_id } });
        }

        public List<ENT.RetailOutletMaster> RetailOutletMaster_GetAll_ByRouteID_Service(Guid rom_areaid)
        {
            return SqlHelper.Get_GetAll_Data<ENT.RetailOutletMaster>("RetailOutletMaster_GetAll_ByRouteID_Service", new object[,] { { "rom_areaid", rom_areaid } });
        }

        public COM.MEMBERS.SQLReturnValue RetailOutletMaster_Delete_IsActive(Guid rom_id, int ActionType)
        {
            return SqlHelper.ExecuteProceduerWithValue("RetailOutletMaster_Delete_IsActive", new object[,] { { "rom_id", rom_id }, { "ActionType", ActionType } }, 3);
        }

        public COM.MEMBERS.SQLReturnValue RetailOutletMaster_UploadImage(Guid rom_id, string rom_image, int ImageType)
        {
            return SqlHelper.ExecuteProceduerWithValue("RetailOutletMaster_UploadImage", new object[,] { { "rom_id", rom_id }, { "rom_image", rom_image }, { "ImageType", ImageType } }, 3);
        }
    }
}