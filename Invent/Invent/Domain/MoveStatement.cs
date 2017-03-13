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
    
    public partial class MoveStatement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MoveStatement()
        {
            this.StatementContext = new HashSet<StatementContext>();
            this.WaybillContext = new HashSet<WaybillContext>();
        }
    
        public int IDStatement { get; set; }
        public System.DateTime StatementDate { get; set; }
        public int WorkerTableNum { get; set; }
        public Nullable<int> SenderSubdivisionID { get; set; }
        public int ReceiverSubdivisionID { get; set; }
    
        public virtual Subdivision Subdivision { get; set; }
        public virtual Worker Worker { get; set; }
        public virtual Subdivision Subdivision1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StatementContext> StatementContext { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WaybillContext> WaybillContext { get; set; }
    }
}