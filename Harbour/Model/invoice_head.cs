//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class invoice_head
    {
        public int invoice_gkey { get; set; }
        public int invoice_int { get; set; }
        public System.DateTime invoice_date { get; set; }
        public int invoice_customer_id { get; set; }
        public string invoice_desc { get; set; }
        public int invoice_contract_key { get; set; }
        public int invoice_total_amount { get; set; }
        public string invoice_currency { get; set; }
        public string invoice_status { get; set; }
        public int invoice_creator { get; set; }
        public System.DateTime invoice_creation_time { get; set; }
        public int invoice_latest_editor { get; set; }
        public System.DateTime invoice_updated_time { get; set; }
    }
}
