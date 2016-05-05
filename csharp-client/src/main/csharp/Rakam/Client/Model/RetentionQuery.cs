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
    public class RetentionQuery :  IEquatable<RetentionQuery>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RetentionQuery" /> class.
        /// </summary>
        public RetentionQuery()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Project
        /// </summary>
        [DataMember(Name="project", EmitDefaultValue=false)]
        public string Project { get; set; }
  
        
        /// <summary>
        /// Gets or Sets FirstAction
        /// </summary>
        [DataMember(Name="first_action", EmitDefaultValue=false)]
        public RetentionAction FirstAction { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ReturningAction
        /// </summary>
        [DataMember(Name="returning_action", EmitDefaultValue=false)]
        public RetentionAction ReturningAction { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Dimension
        /// </summary>
        [DataMember(Name="dimension", EmitDefaultValue=false)]
        public string Dimension { get; set; }
  
        
        /// <summary>
        /// Gets or Sets DateUnit
        /// </summary>
        [DataMember(Name="date_unit", EmitDefaultValue=false)]
        public string DateUnit { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Period
        /// </summary>
        [DataMember(Name="period", EmitDefaultValue=false)]
        public int? Period { get; set; }
  
        
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RetentionQuery {\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  FirstAction: ").Append(FirstAction).Append("\n");
            sb.Append("  ReturningAction: ").Append(ReturningAction).Append("\n");
            sb.Append("  Dimension: ").Append(Dimension).Append("\n");
            sb.Append("  DateUnit: ").Append(DateUnit).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            
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
            return this.Equals(obj as RetentionQuery);
        }

        /// <summary>
        /// Returns true if RetentionQuery instances are equal
        /// </summary>
        /// <param name="obj">Instance of RetentionQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RetentionQuery other)
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
                    this.FirstAction == other.FirstAction ||
                    this.FirstAction != null &&
                    this.FirstAction.Equals(other.FirstAction)
                ) && 
                (
                    this.ReturningAction == other.ReturningAction ||
                    this.ReturningAction != null &&
                    this.ReturningAction.Equals(other.ReturningAction)
                ) && 
                (
                    this.Dimension == other.Dimension ||
                    this.Dimension != null &&
                    this.Dimension.Equals(other.Dimension)
                ) && 
                (
                    this.DateUnit == other.DateUnit ||
                    this.DateUnit != null &&
                    this.DateUnit.Equals(other.DateUnit)
                ) && 
                (
                    this.Period == other.Period ||
                    this.Period != null &&
                    this.Period.Equals(other.Period)
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
                
                if (this.FirstAction != null)
                    hash = hash * 57 + this.FirstAction.GetHashCode();
                
                if (this.ReturningAction != null)
                    hash = hash * 57 + this.ReturningAction.GetHashCode();
                
                if (this.Dimension != null)
                    hash = hash * 57 + this.Dimension.GetHashCode();
                
                if (this.DateUnit != null)
                    hash = hash * 57 + this.DateUnit.GetHashCode();
                
                if (this.Period != null)
                    hash = hash * 57 + this.Period.GetHashCode();
                
                if (this.StartDate != null)
                    hash = hash * 57 + this.StartDate.GetHashCode();
                
                if (this.EndDate != null)
                    hash = hash * 57 + this.EndDate.GetHashCode();
                
                return hash;
            }
        }

    }
}
