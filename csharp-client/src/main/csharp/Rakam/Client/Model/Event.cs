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
    public class Event :  IEquatable<Event>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Event" /> class.
        /// </summary>
        public Event()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Project
        /// </summary>
        [DataMember(Name="project", EmitDefaultValue=false)]
        public string Project { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Collection
        /// </summary>
        [DataMember(Name="collection", EmitDefaultValue=false)]
        public string Collection { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Api
        /// </summary>
        [DataMember(Name="api", EmitDefaultValue=false)]
        public EventContext Api { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public Object Properties { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Event {\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  Collection: ").Append(Collection).Append("\n");
            sb.Append("  Api: ").Append(Api).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            
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
            return this.Equals(obj as Event);
        }

        /// <summary>
        /// Returns true if Event instances are equal
        /// </summary>
        /// <param name="obj">Instance of Event to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Event other)
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
                    this.Collection == other.Collection ||
                    this.Collection != null &&
                    this.Collection.Equals(other.Collection)
                ) && 
                (
                    this.Api == other.Api ||
                    this.Api != null &&
                    this.Api.Equals(other.Api)
                ) && 
                (
                    this.Properties == other.Properties ||
                    this.Properties != null &&
                    this.Properties.Equals(other.Properties)
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
                
                if (this.Collection != null)
                    hash = hash * 57 + this.Collection.GetHashCode();
                
                if (this.Api != null)
                    hash = hash * 57 + this.Api.GetHashCode();
                
                if (this.Properties != null)
                    hash = hash * 57 + this.Properties.GetHashCode();
                
                return hash;
            }
        }

    }
}
