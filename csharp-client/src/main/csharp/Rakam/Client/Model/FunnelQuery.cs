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
    public class FunnelQuery :  IEquatable<FunnelQuery>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FunnelQuery" /> class.
        /// </summary>
        public FunnelQuery()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Project
        /// </summary>
        [DataMember(Name="project", EmitDefaultValue=false)]
        public string Project { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Steps
        /// </summary>
        [DataMember(Name="steps", EmitDefaultValue=false)]
        public List<FunnelStep> Steps { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Dimension
        /// </summary>
        [DataMember(Name="dimension", EmitDefaultValue=false)]
        public string Dimension { get; set; }
  
        
        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Window
        /// </summary>
        [DataMember(Name="window", EmitDefaultValue=false)]
        public FunnelWindow Window { get; set; }
  
        
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
            sb.Append("class FunnelQuery {\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  Steps: ").Append(Steps).Append("\n");
            sb.Append("  Dimension: ").Append(Dimension).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  Window: ").Append(Window).Append("\n");
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
            return this.Equals(obj as FunnelQuery);
        }

        /// <summary>
        /// Returns true if FunnelQuery instances are equal
        /// </summary>
        /// <param name="obj">Instance of FunnelQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FunnelQuery other)
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
                    this.Steps == other.Steps ||
                    this.Steps != null &&
                    this.Steps.SequenceEqual(other.Steps)
                ) && 
                (
                    this.Dimension == other.Dimension ||
                    this.Dimension != null &&
                    this.Dimension.Equals(other.Dimension)
                ) && 
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) && 
                (
                    this.Window == other.Window ||
                    this.Window != null &&
                    this.Window.Equals(other.Window)
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
                
                if (this.Steps != null)
                    hash = hash * 57 + this.Steps.GetHashCode();
                
                if (this.Dimension != null)
                    hash = hash * 57 + this.Dimension.GetHashCode();
                
                if (this.StartDate != null)
                    hash = hash * 57 + this.StartDate.GetHashCode();
                
                if (this.Window != null)
                    hash = hash * 57 + this.Window.GetHashCode();
                
                if (this.EndDate != null)
                    hash = hash * 57 + this.EndDate.GetHashCode();
                
                return hash;
            }
        }

    }
}
