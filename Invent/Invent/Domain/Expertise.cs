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
    
    public partial class Expertise
    {
        public int IDExpertise { get; set; }
        public System.DateTime ExpertiseDate { get; set; }
        public string Commentary { get; set; }
        public int DefectiveListIDList { get; set; }
        public int ExpertIDExpert { get; set; }
        public Nullable<int> InventoryIDInventory { get; set; }
    
        public virtual DefectiveList DefectiveList { get; set; }
        public virtual Expert Expert { get; set; }
        public virtual Inventory Inventory { get; set; }
    }
}
