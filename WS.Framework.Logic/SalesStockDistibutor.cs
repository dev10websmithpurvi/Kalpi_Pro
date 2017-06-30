using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COM = WS.Framework.Common;
using ENT = WS.Framework.Entity;

namespace WS.Framework.Logic
{
    public class SalesStockDistibutor
    {
        COM.SqlHelper SqlHelper = new COM.SqlHelper();

        public List<ENT.SalesStockDistibutor> SalesStockDistibutor_GetAll()
        {
            return SqlHelper.Get_GetAll_Data<ENT.SalesStockDistibutor>("SalesStockDistibutor_GetAll", new object[,] { });
        }
    }
}
