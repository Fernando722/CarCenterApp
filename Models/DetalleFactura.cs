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
    
    public partial class DetalleFactura
    {
        public int idDetalleFactura { get; set; }
        public int idFactura { get; set; }
        public Nullable<int> idMantenimiento { get; set; }
    
        public virtual Facturas Facturas { get; set; }
        public virtual Mantenimientos Mantenimientos { get; set; }
    }
}
