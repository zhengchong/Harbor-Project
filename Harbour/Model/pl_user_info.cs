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
    
    public partial class pl_user_info
    {
        public pl_user_info()
        {
            this.pl_user_role_info = new HashSet<pl_user_role_info>();
        }
    
        public int user_id { get; set; }
        public string user_name { get; set; }
        public string user_pswd { get; set; }
        public int user_creator { get; set; }
        public string user_creation_time { get; set; }
        public int user_latest_editor { get; set; }
        public System.DateTime user_updated_time { get; set; }
        public Nullable<int> user_record_status { get; set; }
    
        public virtual ICollection<pl_user_role_info> pl_user_role_info { get; set; }
    }
}
