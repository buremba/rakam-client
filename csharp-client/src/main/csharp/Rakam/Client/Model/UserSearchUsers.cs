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
    public class UserSearchUsers :  IEquatable<UserSearchUsers>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSearchUsers" /> class.
        /// </summary>
        public UserSearchUsers()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Project
        /// </summary>
        [DataMember(Name="project", EmitDefaultValue=false)]
        public string Project { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Columns
        /// </summary>
        [DataMember(Name="columns", EmitDefaultValue=false)]
        public List<string> Columns { get; set; }
  
        
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
        /// Gets or Sets Sorting
        /// </summary>
        [DataMember(Name="sorting", EmitDefaultValue=false)]
        public Sorting Sorting { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Offset
        /// </summary>
        [DataMember(Name="offset", EmitDefaultValue=false)]
        public string Offset { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Limit
        /// </summary>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int? Limit { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserSearchUsers {\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  Columns: ").Append(Columns).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  EventFilters: ").Append(EventFilters).Append("\n");
            sb.Append("  Sorting: ").Append(Sorting).Append("\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            
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
            return this.Equals(obj as UserSearchUsers);
        }

        /// <summary>
        /// Returns true if UserSearchUsers instances are equal
        /// </summary>
        /// <param name="obj">Instance of UserSearchUsers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserSearchUsers other)
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
                    this.Columns == other.Columns ||
                    this.Columns != null &&
                    this.Columns.SequenceEqual(other.Columns)
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
                    this.Sorting == other.Sorting ||
                    this.Sorting != null &&
                    this.Sorting.Equals(other.Sorting)
                ) && 
                (
                    this.Offset == other.Offset ||
                    this.Offset != null &&
                    this.Offset.Equals(other.Offset)
                ) && 
                (
                    this.Limit == other.Limit ||
                    this.Limit != null &&
                    this.Limit.Equals(other.Limit)
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
                
                if (this.Columns != null)
                    hash = hash * 57 + this.Columns.GetHashCode();
                
                if (this.Filter != null)
                    hash = hash * 57 + this.Filter.GetHashCode();
                
                if (this.EventFilters != null)
                    hash = hash * 57 + this.EventFilters.GetHashCode();
                
                if (this.Sorting != null)
                    hash = hash * 57 + this.Sorting.GetHashCode();
                
                if (this.Offset != null)
                    hash = hash * 57 + this.Offset.GetHashCode();
                
                if (this.Limit != null)
                    hash = hash * 57 + this.Limit.GetHashCode();
                
                return hash;
            }
        }

    }
}
