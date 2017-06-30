using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COM = WS.Framework.Common;
using ENT = WS.Framework.Entity;

namespace WS.Framework.Logic
{
    public class SalesmanAttadanceTime
    {
        COM.SqlHelper SqlHelper = new COM.SqlHelper();

        public List<ENT.SalesmanAttadanceTime> SalesmanAttadanceTime_GetAll()
        {
            return SqlHelper.Get_GetAll_Data<ENT.SalesmanAttadanceTime>("SalesmanAttadanceTime_GetAll", new object[,] { });
        }
    }
}
