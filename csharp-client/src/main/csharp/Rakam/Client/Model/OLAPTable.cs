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
    public class OLAPTable :  IEquatable<OLAPTable>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OLAPTable" /> class.
        /// </summary>
        public OLAPTable()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Project
        /// </summary>
        [DataMember(Name="project", EmitDefaultValue=false)]
        public string Project { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Collections
        /// </summary>
        [DataMember(Name="collections", EmitDefaultValue=false)]
        public List<string> Collections { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Dimensions
        /// </summary>
        [DataMember(Name="dimensions", EmitDefaultValue=false)]
        public List<string> Dimensions { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Aggregations
        /// </summary>
        [DataMember(Name="aggregations", EmitDefaultValue=false)]
        public List<string> Aggregations { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Measures
        /// </summary>
        [DataMember(Name="measures", EmitDefaultValue=false)]
        public List<string> Measures { get; set; }
  
        
        /// <summary>
        /// Gets or Sets TableName
        /// </summary>
        [DataMember(Name="tableName", EmitDefaultValue=false)]
        public string TableName { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OLAPTable {\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  Collections: ").Append(Collections).Append("\n");
            sb.Append("  Dimensions: ").Append(Dimensions).Append("\n");
            sb.Append("  Aggregations: ").Append(Aggregations).Append("\n");
            sb.Append("  Measures: ").Append(Measures).Append("\n");
            sb.Append("  TableName: ").Append(TableName).Append("\n");
            
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
            return this.Equals(obj as OLAPTable);
        }

        /// <summary>
        /// Returns true if OLAPTable instances are equal
        /// </summary>
        /// <param name="obj">Instance of OLAPTable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OLAPTable other)
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
                    this.Collections == other.Collections ||
                    this.Collections != null &&
                    this.Collections.SequenceEqual(other.Collections)
                ) && 
                (
                    this.Dimensions == other.Dimensions ||
                    this.Dimensions != null &&
                    this.Dimensions.SequenceEqual(other.Dimensions)
                ) && 
                (
                    this.Aggregations == other.Aggregations ||
                    this.Aggregations != null &&
                    this.Aggregations.SequenceEqual(other.Aggregations)
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
                
                if (this.Collections != null)
                    hash = hash * 57 + this.Collections.GetHashCode();
                
                if (this.Dimensions != null)
                    hash = hash * 57 + this.Dimensions.GetHashCode();
                
                if (this.Aggregations != null)
                    hash = hash * 57 + this.Aggregations.GetHashCode();
                
                if (this.Measures != null)
                    hash = hash * 57 + this.Measures.GetHashCode();
                
                if (this.TableName != null)
                    hash = hash * 57 + this.TableName.GetHashCode();
                
                return hash;
            }
        }

    }
}
