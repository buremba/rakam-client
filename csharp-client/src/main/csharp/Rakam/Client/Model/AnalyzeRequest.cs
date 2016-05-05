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
    public class AnalyzeRequest :  IEquatable<AnalyzeRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeRequest" /> class.
        /// </summary>
        public AnalyzeRequest()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Project
        /// </summary>
        [DataMember(Name="project", EmitDefaultValue=false)]
        public string Project { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Measure
        /// </summary>
        [DataMember(Name="measure", EmitDefaultValue=false)]
        public Measure Measure { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Grouping
        /// </summary>
        [DataMember(Name="grouping", EmitDefaultValue=false)]
        public Reference Grouping { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Segment
        /// </summary>
        [DataMember(Name="segment", EmitDefaultValue=false)]
        public Reference Segment { get; set; }
  
        
        /// <summary>
        /// Gets or Sets FilterExpression
        /// </summary>
        [DataMember(Name="filterExpression", EmitDefaultValue=false)]
        public string FilterExpression { get; set; }
  
        
        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }
  
        
        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Collections
        /// </summary>
        [DataMember(Name="collections", EmitDefaultValue=false)]
        public List<string> Collections { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyzeRequest {\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  Measure: ").Append(Measure).Append("\n");
            sb.Append("  Grouping: ").Append(Grouping).Append("\n");
            sb.Append("  Segment: ").Append(Segment).Append("\n");
            sb.Append("  FilterExpression: ").Append(FilterExpression).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Collections: ").Append(Collections).Append("\n");
            
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
            return this.Equals(obj as AnalyzeRequest);
        }

        /// <summary>
        /// Returns true if AnalyzeRequest instances are equal
        /// </summary>
        /// <param name="obj">Instance of AnalyzeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyzeRequest other)
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
                    this.Measure == other.Measure ||
                    this.Measure != null &&
                    this.Measure.Equals(other.Measure)
                ) && 
                (
                    this.Grouping == other.Grouping ||
                    this.Grouping != null &&
                    this.Grouping.Equals(other.Grouping)
                ) && 
                (
                    this.Segment == other.Segment ||
                    this.Segment != null &&
                    this.Segment.Equals(other.Segment)
                ) && 
                (
                    this.FilterExpression == other.FilterExpression ||
                    this.FilterExpression != null &&
                    this.FilterExpression.Equals(other.FilterExpression)
                ) && 
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) && 
                (
                    this.EndDate == other.EndDate ||
                    this.EndDate != null &&
                    this.EndDate.Equals(other.EndDate)
                ) && 
                (
                    this.Collections == other.Collections ||
                    this.Collections != null &&
                    this.Collections.SequenceEqual(other.Collections)
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
                
                if (this.Measure != null)
                    hash = hash * 57 + this.Measure.GetHashCode();
                
                if (this.Grouping != null)
                    hash = hash * 57 + this.Grouping.GetHashCode();
                
                if (this.Segment != null)
                    hash = hash * 57 + this.Segment.GetHashCode();
                
                if (this.FilterExpression != null)
                    hash = hash * 57 + this.FilterExpression.GetHashCode();
                
                if (this.StartDate != null)
                    hash = hash * 57 + this.StartDate.GetHashCode();
                
                if (this.EndDate != null)
                    hash = hash * 57 + this.EndDate.GetHashCode();
                
                if (this.Collections != null)
                    hash = hash * 57 + this.Collections.GetHashCode();
                
                return hash;
            }
        }

    }
}
