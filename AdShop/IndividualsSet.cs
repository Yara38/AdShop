//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdShop
{
    using System;
    using System.Collections.Generic;
    
    public partial class IndividualsSet
    {
        public int id { get; set; }
        public Nullable<long> inn { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Nullable<int> Gender { get; set; }
        public string Email { get; set; }
        public int idManager { get; set; }
    
        public virtual ManagerSet ManagerSet { get; set; }
    }
}
