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
    
    public partial class tb_employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_employee()
        {
            this.tb_resell_main = new HashSet<tb_resell_main>();
            this.tb_rewarehouse_main = new HashSet<tb_rewarehouse_main>();
            this.tb_sell_main = new HashSet<tb_sell_main>();
            this.tb_warehouse_main = new HashSet<tb_warehouse_main>();
        }
    
        public string employeecode { get; set; }
        public string fullname { get; set; }
        public string sex { get; set; }
        public string dept { get; set; }
        public string tel { get; set; }
        public string memo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_resell_main> tb_resell_main { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_rewarehouse_main> tb_rewarehouse_main { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_sell_main> tb_sell_main { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_warehouse_main> tb_warehouse_main { get; set; }
    }
}
