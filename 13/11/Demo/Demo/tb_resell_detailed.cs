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
    
    public partial class tb_resell_detailed
    {
        public string billcode { get; set; }
        public string tradecode { get; set; }
        public string fullname { get; set; }
        public string unit { get; set; }
        public Nullable<double> qty { get; set; }
        public Nullable<double> price { get; set; }
        public Nullable<double> tsum { get; set; }
        public Nullable<System.DateTime> billdate { get; set; }
    
        public virtual tb_stock tb_stock { get; set; }
    }
}
