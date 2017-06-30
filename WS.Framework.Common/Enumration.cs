using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WS.Framework.Common
{
    public class Enumration
    {
        public enum EntryMode { ADD = 1, EDIT = 2, DELETE = 3, GET = 4 }
        public enum Operators { WHERE, AND, OR, LIKE, NONE }
        public enum UserType { SuperStockist = 1, Distributor = 2, Salesman = 3, Retailer = 4, Administrator = 0 }
    }
}
