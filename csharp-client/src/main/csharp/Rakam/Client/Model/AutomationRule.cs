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
    public class AutomationRule :  IEquatable<AutomationRule>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRule" /> class.
        /// </summary>
        public AutomationRule()
        {
            this.IsActive = false;
            
        }

        
        /// <summary>
        /// Gets or Sets Project
        /// </summary>
        [DataMember(Name="project", EmitDefaultValue=false)]
        public string Project { get; set; }
  
        
        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name="is_active", EmitDefaultValue=false)]
        public bool? IsActive { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Scenarios
        /// </summary>
        [DataMember(Name="scenarios", EmitDefaultValue=false)]
        public List<ScenarioStep> Scenarios { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public List<SerializableAction> Actions { get; set; }
  
        
        /// <summary>
        /// Gets or Sets CustomData
        /// </summary>
        [DataMember(Name="custom_data", EmitDefaultValue=false)]
        public string CustomData { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutomationRule {\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  Scenarios: ").Append(Scenarios).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  CustomData: ").Append(CustomData).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            
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
            return this.Equals(obj as AutomationRule);
        }

        /// <summary>
        /// Returns true if AutomationRule instances are equal
        /// </summary>
        /// <param name="obj">Instance of AutomationRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutomationRule other)
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
                    this.IsActive == other.IsActive ||
                    this.IsActive != null &&
                    this.IsActive.Equals(other.IsActive)
                ) && 
                (
                    this.Scenarios == other.Scenarios ||
                    this.Scenarios != null &&
                    this.Scenarios.SequenceEqual(other.Scenarios)
                ) && 
                (
                    this.Actions == other.Actions ||
                    this.Actions != null &&
                    this.Actions.SequenceEqual(other.Actions)
                ) && 
                (
                    this.CustomData == other.CustomData ||
                    this.CustomData != null &&
                    this.CustomData.Equals(other.CustomData)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
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
                
                if (this.IsActive != null)
                    hash = hash * 57 + this.IsActive.GetHashCode();
                
                if (this.Scenarios != null)
                    hash = hash * 57 + this.Scenarios.GetHashCode();
                
                if (this.Actions != null)
                    hash = hash * 57 + this.Actions.GetHashCode();
                
                if (this.CustomData != null)
                    hash = hash * 57 + this.CustomData.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 57 + this.Id.GetHashCode();
                
                return hash;
            }
        }

    }
}
