//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Demo
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_rewarehouse_main
    {
        public System.DateTime billdate { get; set; }
        public string billcode { get; set; }
        public string units { get; set; }
        public string handle { get; set; }
        public string summary { get; set; }
        public Nullable<double> fullgathering { get; set; }
        public Nullable<double> gathering { get; set; }
    
        public virtual tb_employee tb_employee { get; set; }
        public virtual tb_units tb_units { get; set; }
    }
}