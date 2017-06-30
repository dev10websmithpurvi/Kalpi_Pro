using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.Framework.Common;
using System.ComponentModel.DataAnnotations;

namespace WS.Framework.Entity
{
    public class OrderProduct : CommonEntity
    {
        [Key]
        public Guid op_id { get; set; }
        public Guid op_retailoutletid { get; set; }
        public int op_neworderqty { get; set; }
        public Guid op_schemeid { get; set; }
        public int op_offtackqty { get; set; }
        public DateTime op_expecteddekiverydt { get; set; }
        public Guid op_productid { get; set; }
        public Guid op_distibutorid { get; set; }
        public int op_freeqty { get; set; }
        public string sb_schemename { get; set; }
        public string pm_name { get; set; }
        public string pm_price { get; set; }
        public string cm_name { get; set; }
        public string pm_productimage { get; set; }
        public bool op_isdeliver { get; set; }
        public DateTime op_deliverydate { get; set; }
        public Guid op_salesmanid { get; set; }
        public string smm_name { get; set; }
        public bool op_iscustomscheme { get; set; }
        public string op_iscustomschemename { get; set; }
        public string op_isdelivername { get; set; }
        public string dm_name { get; set; }

     
    }
    public class OrderProductResponse : CommonEntity
    {
        [Key]
        public Guid op_id { get; set; }
        public Guid op_retailoutletid { get; set; }
        public int op_neworderqty { get; set; }
        public Guid op_schemeid { get; set; }
        public int op_offtackqty { get; set; }
        public DateTime op_expecteddekiverydt { get; set; }
        public Guid op_productid { get; set; }
        public Guid op_distibutorid { get; set; }
        public int op_freeqty { get; set; }
        public string sb_schemename { get; set; }
        public string pm_name { get; set; }
        public string pm_price { get; set; }
        public string cm_name { get; set; }
        public string pm_productimage { get; set; }
        public bool op_isdeliver { get; set; }
        public DateTime op_deliverydate { get; set; }
        public Guid op_salesmanid { get; set; }
        public string smm_name { get; set; }
        public bool op_iscustomscheme { get; set; }
        public string op_iscustomschemename { get; set; }
        public string op_isdelivername { get; set; }
        public string dm_name { get; set; }

        public string rom_name { get; set; }
        public string rom_mobileno { get; set; }
        public string rom_address { get; set; }

    }
}
