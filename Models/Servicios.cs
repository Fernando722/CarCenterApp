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
    
    public partial class Servicios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Servicios()
        {
            this.DetalleServiciosMantenimientos = new HashSet<DetalleServiciosMantenimientos>();
        }
    
        public int idServicio { get; set; }
        public string NombreServicio { get; set; }
        public double PrecioLabor { get; set; }
        public Nullable<double> ValorMinimo { get; set; }
        public Nullable<double> ValorMaximo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleServiciosMantenimientos> DetalleServiciosMantenimientos { get; set; }
    }
}
