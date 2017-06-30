using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COM = WS.Framework.Common;
using ENT = WS.Framework.Entity;

namespace WS.Framework.Logic
{
    public class TotalStockCompany
    {
        COM.SqlHelper SqlHelper = new COM.SqlHelper();

        public List<ENT.TotalStockCompany> TotalStockCompany_GetAll()
        {
            return SqlHelper.Get_GetAll_Data<ENT.TotalStockCompany>("TotalStockCompany_GetAll", new object[,] { });
        }
    }
}
