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
    
    public partial class tb_currentaccount
    {
        public System.DateTime billdate { get; set; }
        public string billcode { get; set; }
        public Nullable<double> addgathering { get; set; }
        public Nullable<double> factaddfee { get; set; }
        public Nullable<double> reducegathering { get; set; }
        public Nullable<double> factfee { get; set; }
        public Nullable<double> balance { get; set; }
        public string units { get; set; }
    
        public virtual tb_units tb_units { get; set; }
    }
}
