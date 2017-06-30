using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COM = WS.Framework.Common;
using ENT = WS.Framework.Entity;

namespace WS.Framework.Logic
{
    public class HeadquarterNotes
    {
        COM.SqlHelper SqlHelper = new COM.SqlHelper();

        public COM.MEMBERS.SQLReturnValue HeadquarterNotes_Insert_Update(ENT.HeadquarterNotes model)
        {
            return SqlHelper.ExecuteProceduerWithValue("HeadquarterNotes_Insert_Update", new object[,] {
                { "hn_id", model.hn_id }
                ,{ "hn_salesmanid", model.hn_salesmanid }
                ,{ "hn_note", model.hn_note }
                ,{ "SystemDateTime", DateTime.Now }
                ,{ "CreatedBy", model.CreatedBy }
                ,{ "CreatedDateTime", DateTime.Now }
                ,{ "UpdatedBy", model.UpdatedBy }
                ,{ "UpdatedDateTime", DateTime.Now }
            }, 3);
        }

        public List<ENT.HeadquarterNotes> HeadquarterNotes_Get_GetAll(Guid hn_id)
        {
            return SqlHelper.Get_GetAll_Data<ENT.HeadquarterNotes>("HeadquarterNotes_Get_GetAll", new object[,] { { "hn_id", hn_id } });
        }

        public List<ENT.HeadquarterNotes> HeadquarterNotes_Get_BySalesman(Guid hn_salesmanid)
        {
            return SqlHelper.Get_GetAll_Data<ENT.HeadquarterNotes>("HeadquarterNotes_Get_BySalesman", new object[,] { { "hn_salesmanid", hn_salesmanid } });
        }
    }
}
