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
    public class RealTimeReport :  IEquatable<RealTimeReport>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RealTimeReport" /> class.
        /// </summary>
        public RealTimeReport()
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
        /// Gets or Sets Measures
        /// </summary>
        [DataMember(Name="measures", EmitDefaultValue=false)]
        public List<Measure> Measures { get; set; }
  
        
        /// <summary>
        /// Gets or Sets TableName
        /// </summary>
        [DataMember(Name="table_name", EmitDefaultValue=false)]
        public string TableName { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Collections
        /// </summary>
        [DataMember(Name="collections", EmitDefaultValue=false)]
        public List<string> Collections { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name="filter", EmitDefaultValue=false)]
        public string Filter { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Dimensions
        /// </summary>
        [DataMember(Name="dimensions", EmitDefaultValue=false)]
        public List<string> Dimensions { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RealTimeReport {\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Measures: ").Append(Measures).Append("\n");
            sb.Append("  TableName: ").Append(TableName).Append("\n");
            sb.Append("  Collections: ").Append(Collections).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  Dimensions: ").Append(Dimensions).Append("\n");
            
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
            return this.Equals(obj as RealTimeReport);
        }

        /// <summary>
        /// Returns true if RealTimeReport instances are equal
        /// </summary>
        /// <param name="obj">Instance of RealTimeReport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RealTimeReport other)
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
                    this.Measures == other.Measures ||
                    this.Measures != null &&
                    this.Measures.SequenceEqual(other.Measures)
                ) && 
                (
                    this.TableName == other.TableName ||
                    this.TableName != null &&
                    this.TableName.Equals(other.TableName)
                ) && 
                (
                    this.Collections == other.Collections ||
                    this.Collections != null &&
                    this.Collections.SequenceEqual(other.Collections)
                ) && 
                (
                    this.Filter == other.Filter ||
                    this.Filter != null &&
                    this.Filter.Equals(other.Filter)
                ) && 
                (
                    this.Dimensions == other.Dimensions ||
                    this.Dimensions != null &&
                    this.Dimensions.SequenceEqual(other.Dimensions)
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
                
                if (this.Measures != null)
                    hash = hash * 57 + this.Measures.GetHashCode();
                
                if (this.TableName != null)
                    hash = hash * 57 + this.TableName.GetHashCode();
                
                if (this.Collections != null)
                    hash = hash * 57 + this.Collections.GetHashCode();
                
                if (this.Filter != null)
                    hash = hash * 57 + this.Filter.GetHashCode();
                
                if (this.Dimensions != null)
                    hash = hash * 57 + this.Dimensions.GetHashCode();
                
                return hash;
            }
        }

    }
}
