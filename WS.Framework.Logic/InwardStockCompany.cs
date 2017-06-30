using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COM = WS.Framework.Common;
using ENT = WS.Framework.Entity;

namespace WS.Framework.Logic
{
    public class InwardStockCompany
    {
        COM.SqlHelper SqlHelper = new COM.SqlHelper();

        public COM.MEMBERS.SQLReturnValue InwardStockCompany_Insert(ENT.InwardStockCompany model)
        {
            // ADD STATIC COMPANY ID IN PROCEDURE @ 19.05.2017 @ 6.19 PM
            return SqlHelper.ExecuteProceduerWithValue("InwardStockCompany_Insert", new object[,] {
                { "isc_id", model.isc_id }
                ,{ "isc_productid", model.isc_productid }
                ,{ "isc_qty", model.isc_qty }
                ,{ "isc_userid", model.isc_userid }
                ,{ "SystemDateTime", DateTime.Now }
                ,{ "CreatedBy", model.CreatedBy }
                ,{ "CreatedDateTime", DateTime.Now }
                ,{ "UpdatedBy", model.UpdatedBy }
                ,{ "UpdatedDateTime", DateTime.Now }
            }, 3);
        }

        public List<ENT.InwardStockCompany> InwardStockCompany_GetAll()
        {
            return SqlHelper.Get_GetAll_Data<ENT.InwardStockCompany>("InwardStockCompany_GetAll", new object[,] { });
        }

        public COM.MEMBERS.SQLReturnValue TotalStockCompany_GetStock(Guid tsc_productid)
        {
            return SqlHelper.ExecuteProceduerWithValue("TotalStockCompany_GetStock", new object[,] { { "tsc_productid", tsc_productid } }, 2);
        }
    }
}
