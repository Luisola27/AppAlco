//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class guaro
    {
        public int guaro_id { get; set; }
        public string name { get; set; }
        public Nullable<int> codigo { get; set; }
        public Nullable<int> activo { get; set; }
        public Nullable<decimal> precio { get; set; }
        public string image { get; set; }
        public int type_id { get; set; }
        public int category_id { get; set; }
    
        public virtual category category { get; set; }
        public virtual type type { get; set; }
    }
}
