//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CyberClub.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserEvent
    {
        public int Id { get; set; }
        public Nullable<int> IdEvent { get; set; }
        public Nullable<int> IdUser { get; set; }
    
        public virtual Event Event { get; set; }
        public virtual User User { get; set; }
    }
}
