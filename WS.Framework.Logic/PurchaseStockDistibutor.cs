using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COM = WS.Framework.Common;
using ENT = WS.Framework.Entity;

namespace WS.Framework.Logic
{
    public class PurchaseStockDistibutor
    {
        COM.SqlHelper SqlHelper = new COM.SqlHelper();

        public COM.MEMBERS.SQLReturnValue PurchaseStockDistibutor_Insert(ENT.PurchaseStockDistibutor model)
        {
            return SqlHelper.ExecuteProceduerWithValue("PurchaseStockDistibutor_Insert", new object[,] {
                { "psd_id", model.psd_id }
                ,{ "psd_productid", model.psd_productid }
                ,{ "psd_qty", model.psd_qty }
                ,{ "psd_userid", model.psd_userid }
                ,{ "psd_superid", model.psd_superid }
                ,{ "SystemDateTime", DateTime.Now }
                ,{ "CreatedBy", model.CreatedBy }
                ,{ "CreatedDateTime", DateTime.Now }
                ,{ "UpdatedBy", model.UpdatedBy }
                ,{ "UpdatedDateTime", DateTime.Now }
            }, 3);
        }

        public List<ENT.PurchaseStockDistibutor> PurchaseStockDistibutor_GetAll()
        {
            return SqlHelper.Get_GetAll_Data<ENT.PurchaseStockDistibutor>("PurchaseStockDistibutor_GetAll", new object[,] { });
        }

        public COM.MEMBERS.SQLReturnValue TotalStockDistibutor_GetStock(Guid tsd_productid, Guid tsd_userid)
        {
            return SqlHelper.ExecuteProceduerWithValue("TotalStockDistibutor_GetStock", new object[,] { { "tsd_productid", tsd_productid }, { "tsd_userid", tsd_userid } }, 2);
        }
    }
}
