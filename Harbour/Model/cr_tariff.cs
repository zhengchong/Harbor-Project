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
    
    public partial class cr_tariff
    {
        public int tarriff_contract_gkey { get; set; }
        public string tariff_charge_subject_code { get; set; }
        public System.DateTime tariff_power_start_time { get; set; }
        public System.DateTime tariff_power_end_time { get; set; }
        public System.DateTime tariff_berth_end_time { get; set; }
        public System.DateTime tariff_storage_start_time { get; set; }
        public System.DateTime tariff_storage_end_time { get; set; }
        public int tariff_amount { get; set; }
        public int tariff_creator { get; set; }
        public System.DateTime tariff_creation_time { get; set; }
        public int tariff_latest_editor { get; set; }
        public System.DateTime tariff_updated_time { get; set; }
        public Nullable<int> tariff_record_status { get; set; }
    }
}