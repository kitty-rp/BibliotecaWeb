//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.EntityClient;
using HL.Biblio.POCO;

namespace HL.Biblio.DAL
{
    public partial class BibliotecaContext : ObjectContext
    {
        public const string ConnectionString = "name=BibliotecaContext";
        public const string ContainerName = "BibliotecaContext";
    
        #region Constructors
    
        public BibliotecaContext()
            : base(ConnectionString, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        public BibliotecaContext(string connectionString)
            : base(connectionString, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        public BibliotecaContext(EntityConnection connection)
            : base(connection, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        #endregion
    
        #region ObjectSet Properties
    
        public ObjectSet<Libro> Libros
        {
            get { return _libros  ?? (_libros = CreateObjectSet<Libro>("Libros")); }
        }
        private ObjectSet<Libro> _libros;
    
        public ObjectSet<Autor> Autores
        {
            get { return _autores  ?? (_autores = CreateObjectSet<Autor>("Autores")); }
        }
        private ObjectSet<Autor> _autores;
    
        public ObjectSet<Editorial> Editoriales
        {
            get { return _editoriales  ?? (_editoriales = CreateObjectSet<Editorial>("Editoriales")); }
        }
        private ObjectSet<Editorial> _editoriales;
    
        public ObjectSet<Ejemplar> Ejemplares
        {
            get { return _ejemplares  ?? (_ejemplares = CreateObjectSet<Ejemplar>("Ejemplares")); }
        }
        private ObjectSet<Ejemplar> _ejemplares;
    
        public ObjectSet<Pais> Paises
        {
            get { return _paises  ?? (_paises = CreateObjectSet<Pais>("Paises")); }
        }
        private ObjectSet<Pais> _paises;
    
        public ObjectSet<Clasificacion> Clasificaciones
        {
            get { return _clasificaciones  ?? (_clasificaciones = CreateObjectSet<Clasificacion>("Clasificaciones")); }
        }
        private ObjectSet<Clasificacion> _clasificaciones;

        #endregion
    }
}