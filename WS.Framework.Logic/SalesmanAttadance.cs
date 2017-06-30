using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COM = WS.Framework.Common;
using ENT = WS.Framework.Entity;

namespace WS.Framework.Logic
{
    public class SalesmanAttadance
    {
        COM.SqlHelper SqlHelper = new COM.SqlHelper();

        public COM.MEMBERS.SQLReturnValue SalesmanAttadance_Insert(ENT.SalesmanAttadance model)
        {
            return SqlHelper.ExecuteProceduerWithValue("SalesmanAttadance_Insert", new object[,] {
                { "sa_id", model.sa_id }
                ,{ "sa_salesmanid", model.sa_salesmanid }
                ,{ "sa_inouttime", model.sa_inouttime }
                ,{ "sa_attadancetype", model.sa_attadancetype }
                ,{ "sa_lat", model.sa_lat }
                ,{ "sa_long", model.sa_long }
                ,{ "sa_area", model.sa_area }
                ,{ "smm_deviceid", model.smm_deviceid }
                ,{ "SystemDateTime", DateTime.Now }
                ,{ "CreatedBy", model.CreatedBy }
                ,{ "CreatedDateTime", DateTime.Now }
                ,{ "UpdatedBy", model.UpdatedBy }
                ,{ "UpdatedDateTime", DateTime.Now }
            }, 3);
        }

        public List<ENT.SalesmanAttadance> SalesmanAttadance_GetAll_TodayAttedance(Guid sa_salesmanid)
        {
            return SqlHelper.Get_GetAll_Data<ENT.SalesmanAttadance>("SalesmanAttadance_GetAll_TodayAttedance", new object[,] { { "sa_salesmanid", sa_salesmanid } });
        }
    }
}
