//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Banco.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class bitacora
    {
        public int no_movimiento { get; set; }
        public string tipo { get; set; }
        public System.DateTime fecha_hora { get; set; }
        public int monto { get; set; }
        public string estado { get; set; }
        public int no_cuenta { get; set; }
    
        public virtual cuenta cuenta { get; set; }
    }
}
