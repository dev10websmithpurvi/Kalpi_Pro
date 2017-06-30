using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COM = WS.Framework.Common;
using ENT = WS.Framework.Entity;

namespace WS.Framework.Logic
{
    public class TotalStockDistibutor
    {
        COM.SqlHelper SqlHelper = new COM.SqlHelper();

        public List<ENT.TotalStockDistibutor> TotalStockDistibutor_GetAll()
        {
            return SqlHelper.Get_GetAll_Data<ENT.TotalStockDistibutor>("TotalStockDistibutor_GetAll", new object[,] { });
        }
    }
}
