//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gemo_test_application
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Orders()
        {
            this.AnalyzesForOrder = new HashSet<AnalyzesForOrder>();
        }
    
        public int id { get; set; }
        public Nullable<int> id_Patient { get; set; }
        public Nullable<int> id_Doctor { get; set; }
        public Nullable<int> id_Study { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Code { get; set; }
        public Nullable<decimal> EndPrice { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AnalyzesForOrder> AnalyzesForOrder { get; set; }
        public virtual Doctors Doctors { get; set; }
        public virtual Patients Patients { get; set; }
        public virtual Study Study { get; set; }
    }
}
