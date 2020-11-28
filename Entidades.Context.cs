﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ReyesMagosEntities : DbContext
    {
        public ReyesMagosEntities()
            : base("name=ReyesMagosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ciudad> ciudad { get; set; }
        public virtual DbSet<colonia> colonia { get; set; }
        public virtual DbSet<Eventos> Eventos { get; set; }
        public virtual DbSet<Grupo_vecino> Grupo_vecino { get; set; }
        public virtual DbSet<niños> niños { get; set; }
        public virtual DbSet<Rey_Mago> Rey_Mago { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Vecinos> Vecinos { get; set; }
        public virtual DbSet<listadoMelchor> listadoMelchor { get; set; }
    
        [DbFunction("ReyesMagosEntities", "numeroNiñosEvento")]
        public virtual IQueryable<numeroNiñosEvento_Result> numeroNiñosEvento(Nullable<int> evento)
        {
            var eventoParameter = evento.HasValue ?
                new ObjectParameter("evento", evento) :
                new ObjectParameter("evento", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<numeroNiñosEvento_Result>("[ReyesMagosEntities].[numeroNiñosEvento](@evento)", eventoParameter);
        }
    
        public virtual ObjectResult<SP_AgregarNuevoNiño_Result> SP_AgregarNuevoNiño(string nombre, string apellido, string materno, string regalo, Nullable<int> clave, Nullable<int> colonia, Nullable<int> ciudad, string calle, Nullable<int> numCalle)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var apellidoParameter = apellido != null ?
                new ObjectParameter("apellido", apellido) :
                new ObjectParameter("apellido", typeof(string));
    
            var maternoParameter = materno != null ?
                new ObjectParameter("materno", materno) :
                new ObjectParameter("materno", typeof(string));
    
            var regaloParameter = regalo != null ?
                new ObjectParameter("regalo", regalo) :
                new ObjectParameter("regalo", typeof(string));
    
            var claveParameter = clave.HasValue ?
                new ObjectParameter("clave", clave) :
                new ObjectParameter("clave", typeof(int));
    
            var coloniaParameter = colonia.HasValue ?
                new ObjectParameter("colonia", colonia) :
                new ObjectParameter("colonia", typeof(int));
    
            var ciudadParameter = ciudad.HasValue ?
                new ObjectParameter("ciudad", ciudad) :
                new ObjectParameter("ciudad", typeof(int));
    
            var calleParameter = calle != null ?
                new ObjectParameter("calle", calle) :
                new ObjectParameter("calle", typeof(string));
    
            var numCalleParameter = numCalle.HasValue ?
                new ObjectParameter("numCalle", numCalle) :
                new ObjectParameter("numCalle", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_AgregarNuevoNiño_Result>("SP_AgregarNuevoNiño", nombreParameter, apellidoParameter, maternoParameter, regaloParameter, claveParameter, coloniaParameter, ciudadParameter, calleParameter, numCalleParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> SP_niñosEventos(Nullable<int> clave)
        {
            var claveParameter = clave.HasValue ?
                new ObjectParameter("Clave", clave) :
                new ObjectParameter("Clave", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SP_niñosEventos", claveParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> SP_numeroNiños(Nullable<int> clave)
        {
            var claveParameter = clave.HasValue ?
                new ObjectParameter("Clave", clave) :
                new ObjectParameter("Clave", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SP_numeroNiños", claveParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    }
}