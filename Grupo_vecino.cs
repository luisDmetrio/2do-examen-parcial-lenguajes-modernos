//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace testAssp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Grupo_vecino
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Grupo_vecino()
        {
            this.Eventos = new HashSet<Eventos>();
            this.Vecinos = new HashSet<Vecinos>();
        }
    
        public int Clave_grupo { get; set; }
        public int Clave_colonia { get; set; }
        public int Clave_Ciudad { get; set; }
        public Nullable<int> Integrantes { get; set; }
        public Nullable<int> eventosOrganizados { get; set; }
        public string nombreGrupo { get; set; }
    
        public virtual ciudad ciudad { get; set; }
        public virtual colonia colonia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Eventos> Eventos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vecinos> Vecinos { get; set; }
    }
}