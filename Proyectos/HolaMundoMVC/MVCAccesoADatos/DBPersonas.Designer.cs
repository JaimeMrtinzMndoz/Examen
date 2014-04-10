﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace MVCAccesoADatos
{
    #region Contextos
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    public partial class DBPersonasEntities : ObjectContext
    {
        #region Constructores
    
        /// <summary>
        /// Inicializa un nuevo objeto DBPersonasEntities usando la cadena de conexión encontrada en la sección 'DBPersonasEntities' del archivo de configuración de la aplicación.
        /// </summary>
        public DBPersonasEntities() : base("name=DBPersonasEntities", "DBPersonasEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto DBPersonasEntities.
        /// </summary>
        public DBPersonasEntities(string connectionString) : base(connectionString, "DBPersonasEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto DBPersonasEntities.
        /// </summary>
        public DBPersonasEntities(EntityConnection connection) : base(connection, "DBPersonasEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Métodos parciales
    
        partial void OnContextCreated();
    
        #endregion
    
        #region Propiedades de ObjectSet
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<Persona> Personas
        {
            get
            {
                if ((_Personas == null))
                {
                    _Personas = base.CreateObjectSet<Persona>("Personas");
                }
                return _Personas;
            }
        }
        private ObjectSet<Persona> _Personas;

        #endregion

        #region Métodos AddTo
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet Personas. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToPersonas(Persona persona)
        {
            base.AddObject("Personas", persona);
        }

        #endregion

    }

    #endregion

    #region Entidades
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DBPersonasModel", Name="Persona")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Persona : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto Persona.
        /// </summary>
        /// <param name="idPersona">Valor inicial de la propiedad IdPersona.</param>
        /// <param name="nombrePersona">Valor inicial de la propiedad NombrePersona.</param>
        /// <param name="ciudad">Valor inicial de la propiedad Ciudad.</param>
        public static Persona CreatePersona(global::System.Int32 idPersona, global::System.String nombrePersona, global::System.String ciudad)
        {
            Persona persona = new Persona();
            persona.IdPersona = idPersona;
            persona.NombrePersona = nombrePersona;
            persona.Ciudad = ciudad;
            return persona;
        }

        #endregion

        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 IdPersona
        {
            get
            {
                return _IdPersona;
            }
            set
            {
                if (_IdPersona != value)
                {
                    OnIdPersonaChanging(value);
                    ReportPropertyChanging("IdPersona");
                    _IdPersona = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("IdPersona");
                    OnIdPersonaChanged();
                }
            }
        }
        private global::System.Int32 _IdPersona;
        partial void OnIdPersonaChanging(global::System.Int32 value);
        partial void OnIdPersonaChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String NombrePersona
        {
            get
            {
                return _NombrePersona;
            }
            set
            {
                OnNombrePersonaChanging(value);
                ReportPropertyChanging("NombrePersona");
                _NombrePersona = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("NombrePersona");
                OnNombrePersonaChanged();
            }
        }
        private global::System.String _NombrePersona;
        partial void OnNombrePersonaChanging(global::System.String value);
        partial void OnNombrePersonaChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Ciudad
        {
            get
            {
                return _Ciudad;
            }
            set
            {
                OnCiudadChanging(value);
                ReportPropertyChanging("Ciudad");
                _Ciudad = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Ciudad");
                OnCiudadChanged();
            }
        }
        private global::System.String _Ciudad;
        partial void OnCiudadChanging(global::System.String value);
        partial void OnCiudadChanged();

        #endregion

    
    }

    #endregion

    
}