//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarCenterApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Repuestos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Repuestos()
        {
            this.DetalleRepuestosMantenimientos = new HashSet<DetalleRepuestosMantenimientos>();
        }
    
        public int idRepuesto { get; set; }
        public string NombreRepuesto { get; set; }
        public double PrecioUnidad { get; set; }
        public int NumeroUnidades { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleRepuestosMantenimientos> DetalleRepuestosMantenimientos { get; set; }
    }
}
