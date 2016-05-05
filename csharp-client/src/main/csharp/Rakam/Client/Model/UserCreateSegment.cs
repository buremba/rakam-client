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
    public class UserCreateSegment :  IEquatable<UserCreateSegment>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserCreateSegment" /> class.
        /// </summary>
        public UserCreateSegment()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Project
        /// </summary>
        [DataMember(Name="project", EmitDefaultValue=false)]
        public string Project { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// Gets or Sets TableName
        /// </summary>
        [DataMember(Name="table_name", EmitDefaultValue=false)]
        public string TableName { get; set; }
  
        
        /// <summary>
        /// Gets or Sets FilterExpression
        /// </summary>
        [DataMember(Name="filter_expression", EmitDefaultValue=false)]
        public string FilterExpression { get; set; }
  
        
        /// <summary>
        /// Gets or Sets EventFilters
        /// </summary>
        [DataMember(Name="event_filters", EmitDefaultValue=false)]
        public List<EventFilter> EventFilters { get; set; }
  
        
        /// <summary>
        /// Gets or Sets CacheEviction
        /// </summary>
        [DataMember(Name="cache_eviction", EmitDefaultValue=false)]
        public string CacheEviction { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserCreateSegment {\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TableName: ").Append(TableName).Append("\n");
            sb.Append("  FilterExpression: ").Append(FilterExpression).Append("\n");
            sb.Append("  EventFilters: ").Append(EventFilters).Append("\n");
            sb.Append("  CacheEviction: ").Append(CacheEviction).Append("\n");
            
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
            return this.Equals(obj as UserCreateSegment);
        }

        /// <summary>
        /// Returns true if UserCreateSegment instances are equal
        /// </summary>
        /// <param name="obj">Instance of UserCreateSegment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserCreateSegment other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.TableName == other.TableName ||
                    this.TableName != null &&
                    this.TableName.Equals(other.TableName)
                ) && 
                (
                    this.FilterExpression == other.FilterExpression ||
                    this.FilterExpression != null &&
                    this.FilterExpression.Equals(other.FilterExpression)
                ) && 
                (
                    this.EventFilters == other.EventFilters ||
                    this.EventFilters != null &&
                    this.EventFilters.SequenceEqual(other.EventFilters)
                ) && 
                (
                    this.CacheEviction == other.CacheEviction ||
                    this.CacheEviction != null &&
                    this.CacheEviction.Equals(other.CacheEviction)
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
                
                if (this.Name != null)
                    hash = hash * 57 + this.Name.GetHashCode();
                
                if (this.TableName != null)
                    hash = hash * 57 + this.TableName.GetHashCode();
                
                if (this.FilterExpression != null)
                    hash = hash * 57 + this.FilterExpression.GetHashCode();
                
                if (this.EventFilters != null)
                    hash = hash * 57 + this.EventFilters.GetHashCode();
                
                if (this.CacheEviction != null)
                    hash = hash * 57 + this.CacheEviction.GetHashCode();
                
                return hash;
            }
        }

    }
}
