//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
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
namespace DB_FirstEntity.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class CollegeDBContainer : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new CollegeDBContainer object using the connection string found in the 'CollegeDBContainer' section of the application configuration file.
        /// </summary>
        public CollegeDBContainer() : base("name=CollegeDBContainer", "CollegeDBContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new CollegeDBContainer object.
        /// </summary>
        public CollegeDBContainer(string connectionString) : base(connectionString, "CollegeDBContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new CollegeDBContainer object.
        /// </summary>
        public CollegeDBContainer(EntityConnection connection) : base(connection, "CollegeDBContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
    }

    #endregion

}
