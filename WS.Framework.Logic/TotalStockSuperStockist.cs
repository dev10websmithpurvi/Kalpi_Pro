using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COM = WS.Framework.Common;
using ENT = WS.Framework.Entity;

namespace WS.Framework.Logic
{
    public class TotalStockSuperStockist
    {
        COM.SqlHelper SqlHelper = new COM.SqlHelper();

        public List<ENT.TotalStockSuperStockist> TotalStockSuperStockist_GetAll()
        {
            return SqlHelper.Get_GetAll_Data<ENT.TotalStockSuperStockist>("TotalStockSuperStockist_GetAll", new object[,] { });
        }
    }
}
