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
    public class RealtimeGet :  IEquatable<RealtimeGet>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeGet" /> class.
        /// </summary>
        public RealtimeGet()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Project
        /// </summary>
        [DataMember(Name="project", EmitDefaultValue=false)]
        public string Project { get; set; }
  
        
        /// <summary>
        /// Gets or Sets TableName
        /// </summary>
        [DataMember(Name="table_name", EmitDefaultValue=false)]
        public string TableName { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name="filter", EmitDefaultValue=false)]
        public string Filter { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Measure
        /// </summary>
        [DataMember(Name="measure", EmitDefaultValue=false)]
        public Measure Measure { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Dimensions
        /// </summary>
        [DataMember(Name="dimensions", EmitDefaultValue=false)]
        public List<string> Dimensions { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Aggregate
        /// </summary>
        [DataMember(Name="aggregate", EmitDefaultValue=false)]
        public bool? Aggregate { get; set; }
  
        
        /// <summary>
        /// Gets or Sets DateStart
        /// </summary>
        [DataMember(Name="date_start", EmitDefaultValue=false)]
        public DateTime? DateStart { get; set; }
  
        
        /// <summary>
        /// Gets or Sets DateEnd
        /// </summary>
        [DataMember(Name="date_end", EmitDefaultValue=false)]
        public DateTime? DateEnd { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RealtimeGet {\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  TableName: ").Append(TableName).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  Measure: ").Append(Measure).Append("\n");
            sb.Append("  Dimensions: ").Append(Dimensions).Append("\n");
            sb.Append("  Aggregate: ").Append(Aggregate).Append("\n");
            sb.Append("  DateStart: ").Append(DateStart).Append("\n");
            sb.Append("  DateEnd: ").Append(DateEnd).Append("\n");
            
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
            return this.Equals(obj as RealtimeGet);
        }

        /// <summary>
        /// Returns true if RealtimeGet instances are equal
        /// </summary>
        /// <param name="obj">Instance of RealtimeGet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RealtimeGet other)
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
                    this.TableName == other.TableName ||
                    this.TableName != null &&
                    this.TableName.Equals(other.TableName)
                ) && 
                (
                    this.Filter == other.Filter ||
                    this.Filter != null &&
                    this.Filter.Equals(other.Filter)
                ) && 
                (
                    this.Measure == other.Measure ||
                    this.Measure != null &&
                    this.Measure.Equals(other.Measure)
                ) && 
                (
                    this.Dimensions == other.Dimensions ||
                    this.Dimensions != null &&
                    this.Dimensions.SequenceEqual(other.Dimensions)
                ) && 
                (
                    this.Aggregate == other.Aggregate ||
                    this.Aggregate != null &&
                    this.Aggregate.Equals(other.Aggregate)
                ) && 
                (
                    this.DateStart == other.DateStart ||
                    this.DateStart != null &&
                    this.DateStart.Equals(other.DateStart)
                ) && 
                (
                    this.DateEnd == other.DateEnd ||
                    this.DateEnd != null &&
                    this.DateEnd.Equals(other.DateEnd)
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
                
                if (this.TableName != null)
                    hash = hash * 57 + this.TableName.GetHashCode();
                
                if (this.Filter != null)
                    hash = hash * 57 + this.Filter.GetHashCode();
                
                if (this.Measure != null)
                    hash = hash * 57 + this.Measure.GetHashCode();
                
                if (this.Dimensions != null)
                    hash = hash * 57 + this.Dimensions.GetHashCode();
                
                if (this.Aggregate != null)
                    hash = hash * 57 + this.Aggregate.GetHashCode();
                
                if (this.DateStart != null)
                    hash = hash * 57 + this.DateStart.GetHashCode();
                
                if (this.DateEnd != null)
                    hash = hash * 57 + this.DateEnd.GetHashCode();
                
                return hash;
            }
        }

    }
}
