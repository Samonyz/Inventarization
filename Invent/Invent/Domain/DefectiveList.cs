//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Invent.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class DefectiveList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DefectiveList()
        {
            this.Expertise = new HashSet<Expertise>();
        }
    
        public int IDList { get; set; }
        public System.DateTime DocDate { get; set; }
        public int WorkerTableNum { get; set; }
        public Nullable<int> WriteOffActIDWriteOffAct { get; set; }
    
        public virtual Worker Worker { get; set; }
        public virtual WriteOffAct WriteOffAct { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Expertise> Expertise { get; set; }
    }
}