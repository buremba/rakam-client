using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Rakam.Client.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class UserEmailActionBatch :  IEquatable<UserEmailActionBatch>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserEmailActionBatch" /> class.
        /// </summary>
        public UserEmailActionBatch()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Project
        /// </summary>
        [DataMember(Name="project", EmitDefaultValue=false)]
        public string Project { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name="filter", EmitDefaultValue=false)]
        public string Filter { get; set; }
  
        
        /// <summary>
        /// Gets or Sets EventFilters
        /// </summary>
        [DataMember(Name="event_filters", EmitDefaultValue=false)]
        public List<EventFilter> EventFilters { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Config
        /// </summary>
        [DataMember(Name="config", EmitDefaultValue=false)]
        public EmailActionConfig Config { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserEmailActionBatch {\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  EventFilters: ").Append(EventFilters).Append("\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as UserEmailActionBatch);
        }

        /// <summary>
        /// Returns true if UserEmailActionBatch instances are equal
        /// </summary>
        /// <param name="obj">Instance of UserEmailActionBatch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserEmailActionBatch other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Project == other.Project ||
                    this.Project != null &&
                    this.Project.Equals(other.Project)
                ) && 
                (
                    this.Filter == other.Filter ||
                    this.Filter != null &&
                    this.Filter.Equals(other.Filter)
                ) && 
                (
                    this.EventFilters == other.EventFilters ||
                    this.EventFilters != null &&
                    this.EventFilters.SequenceEqual(other.EventFilters)
                ) && 
                (
                    this.Config == other.Config ||
                    this.Config != null &&
                    this.Config.Equals(other.Config)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.Project != null)
                    hash = hash * 57 + this.Project.GetHashCode();
                
                if (this.Filter != null)
                    hash = hash * 57 + this.Filter.GetHashCode();
                
                if (this.EventFilters != null)
                    hash = hash * 57 + this.EventFilters.GetHashCode();
                
                if (this.Config != null)
                    hash = hash * 57 + this.Config.GetHashCode();
                
                return hash;
            }
        }

    }
}
