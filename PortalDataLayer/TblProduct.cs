//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PortalDataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblProduct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblProduct()
        {
            this.TblCarts = new HashSet<TblCart>();
        }
    
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public Nullable<decimal> ProductPrice { get; set; }
        public Nullable<decimal> ProductDiscount { get; set; }
        public Nullable<int> ProductStock { get; set; }
        public Nullable<bool> ProductActive { get; set; }
        public Nullable<int> CategoryId { get; set; }
    
        public virtual TblCategory TblCategory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblCart> TblCarts { get; set; }
    }
}
