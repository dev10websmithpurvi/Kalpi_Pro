using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COM = WS.Framework.Common;
using ENT = WS.Framework.Entity;

namespace WS.Framework.Logic
{
    public class OrderProduct
    {
        COM.SqlHelper SqlHelper = new COM.SqlHelper();

        public COM.MEMBERS.SQLReturnMessageNValue OrderProduct_Insert_Update(ENT.OrderProduct model)
        {
            //string DateFormat = COM.GeneralLogic.GenerateDateFormat(model.op_expecteddekiverydt.ToString());

            return SqlHelper.ExecuteProceduerWithMessageNValue("OrderProduct_Insert_Update", new object[,] {
                { "op_id", model.op_id }
                ,{ "op_retailoutletid", model.op_retailoutletid }
                ,{ "op_neworderqty", model.op_neworderqty }
                ,{ "op_schemeid", model.op_schemeid }
                ,{ "op_offtackqty", model.op_offtackqty }
                ,{ "op_expecteddekiverydt", model.op_expecteddekiverydt }
                ,{ "op_productid", model.op_productid }
                ,{ "op_distibutorid", model.op_distibutorid }
                ,{ "op_freeqty", model.op_freeqty }
                ,{ "op_salesmanid", model.op_salesmanid }
                ,{ "op_iscustomscheme", model.op_iscustomscheme }
                ,{ "SystemDateTime", DateTime.Now }
                ,{ "CreatedBy", model.CreatedBy }
                ,{ "CreatedDateTime", DateTime.Now }
                ,{ "UpdatedBy", model.UpdatedBy }
                ,{ "UpdatedDateTime", DateTime.Now }
            }, 2);
        }

        public List<ENT.OrderProduct> OrderProduct_Get_GetAll(Guid op_id)
        {
            return SqlHelper.Get_GetAll_Data<ENT.OrderProduct>("OrderProduct_Get_GetAll", new object[,] { { "op_id", op_id } });
        }

        public List<ENT.OrderProductResponse> OrderProduct_GetAll_ByOutletID(Guid op_retailoutletid, DateTime op_expecteddekiverydt,int filtertype,int upcoming_days)
        {
            return SqlHelper.Get_GetAll_Data<ENT.OrderProductResponse>("OrderProduct_GetAll_ByOutletID", new object[,] { { "op_retailoutletid", op_retailoutletid }, { "op_expecteddekiverydt", op_expecteddekiverydt },
             { "filtertype", filtertype }, { "upcoming_days", upcoming_days }});
        }

        public COM.MEMBERS.SQLReturnValue OrderProduct_Delete(Guid op_id)
        {
            return SqlHelper.ExecuteProceduerWithValue("OrderProduct_Delete", new object[,] { { "op_id", op_id } }, 3);
        }

        public COM.MEMBERS.SQLReturnValue OrderProduct_IsDeliveryDone(Guid op_id, bool op_isdeliver, DateTime op_deliverydate)
        {
            return SqlHelper.ExecuteProceduerWithValue("OrderProduct_IsDeliveryDone", new object[,] { { "op_id", op_id }, { "op_isdeliver", op_isdeliver }, { "op_deliverydate", op_deliverydate } }, 3);
        }

        public List<ENT.OrderProduct> OrderProduct_GetLastStockOfRetailer(Guid op_retailoutletid, Guid op_productid)
        {
            return SqlHelper.Get_GetAll_Data<ENT.OrderProduct>("OrderProduct_GetLastStockOfRetailer", new object[,] { { "op_retailoutletid", op_retailoutletid }, { "op_productid", op_productid } });
        }

        public List<ENT.OrderProduct> OrderProduct_GetAllDelivery_Report()
        {
            return SqlHelper.Get_GetAll_Data<ENT.OrderProduct>("OrderProduct_GetAllDelivery_Report", new object[,] { });
        }
    }
}
