//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BrianandAlix.DataLayers
{
    using System;
    using System.Collections.Generic;
    
    public partial class Guests
    {
        public int Id { get; set; }
        public bool IsGuests { get; set; }
        public Nullable<int> Adults { get; set; }
        public Nullable<int> Children { get; set; }
        public int PersonId { get; set; }
    
        public virtual Person Person { get; set; }
    }
}
