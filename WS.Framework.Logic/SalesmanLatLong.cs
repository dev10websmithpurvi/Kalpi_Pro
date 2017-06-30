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
    public class SalesmanLatLong
    {
        COM.SqlHelper SqlHelper = new COM.SqlHelper();

        public COM.MEMBERS.SQLReturnValue SalesmanLatLong_Insert(ENT.SalesmanLatLong model)
        {
            return SqlHelper.ExecuteProceduerWithValue("SalesmanLatLong_Insert", new object[,] {
                { "sll_id", model.sll_id }
                ,{ "sll_salesmanid", model.sll_salesmanid }
                ,{ "sll_lat", model.sll_lat }
                ,{ "sll_long", model.sll_long }
                ,{ "SystemDateTime", DateTime.Now }
                ,{ "CreatedBy", model.CreatedBy }
                ,{ "CreatedDateTime", DateTime.Now }
                ,{ "UpdatedBy", model.UpdatedBy }
                ,{ "UpdatedDateTime", DateTime.Now }
            }, 3);
        }

        //public COM.MEMBERS.SQLReturnValue SalesmanLatLong_Insert(DataTable dtData)
        //{
        //    return SqlHelper.ExecuteProcedureWithDatatable("SalesmanLatLong_Insert", dtData, "SalesmanLatLong", 3);
        //}
    }
}
