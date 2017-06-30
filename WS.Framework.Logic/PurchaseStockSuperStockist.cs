using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COM = WS.Framework.Common;
using ENT = WS.Framework.Entity;

namespace WS.Framework.Logic
{
    public class PurchaseStockSuperStockist
    {
        COM.SqlHelper SqlHelper = new COM.SqlHelper();

        public COM.MEMBERS.SQLReturnValue PurchaseStockSuperStockist_Insert(ENT.PurchaseStockSuperStockist model)
        {
            return SqlHelper.ExecuteProceduerWithValue("PurchaseStockSuperStockist_Insert", new object[,] {
                { "psss_id", model.psss_id }
                ,{ "psss_productid", model.psss_productid }
                ,{ "psss_qty", model.psss_qty }
                ,{ "psss_userid", model.psss_userid }
                ,{ "psss_companyid", model.psss_companyid }
                ,{ "SystemDateTime", DateTime.Now }
                ,{ "CreatedBy", model.CreatedBy }
                ,{ "CreatedDateTime", DateTime.Now }
                ,{ "UpdatedBy", model.UpdatedBy }
                ,{ "UpdatedDateTime", DateTime.Now }
            }, 3);
        }

        public List<ENT.PurchaseStockSuperStockist> PurchaseStockSuperStockist_GetAll()
        {
            return SqlHelper.Get_GetAll_Data<ENT.PurchaseStockSuperStockist>("PurchaseStockSuperStockist_GetAll", new object[,] { });
        }

        public COM.MEMBERS.SQLReturnValue TotalStockSuperStockist_GetStock(Guid tsss_productid, Guid tsss_userid)
        {
            return SqlHelper.ExecuteProceduerWithValue("TotalStockSuperStockist_GetStock", new object[,] { { "tsss_productid", tsss_productid }, { "tsss_userid", tsss_userid } }, 2);
        }
    }
}
