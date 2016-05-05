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
    public class ABTestingReport :  IEquatable<ABTestingReport>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ABTestingReport" /> class.
        /// </summary>
        public ABTestingReport()
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
        /// Gets or Sets Variants
        /// </summary>
        [DataMember(Name="variants", EmitDefaultValue=false)]
        public List<Variant> Variants { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Goal
        /// </summary>
        [DataMember(Name="goal", EmitDefaultValue=false)]
        public Goal Goal { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public Object Options { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
  
        
        /// <summary>
        /// Gets or Sets CollectionName
        /// </summary>
        [DataMember(Name="collectionName", EmitDefaultValue=false)]
        public string CollectionName { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ConnectorField
        /// </summary>
        [DataMember(Name="connectorField", EmitDefaultValue=false)]
        public string ConnectorField { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ABTestingReport {\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Variants: ").Append(Variants).Append("\n");
            sb.Append("  Goal: ").Append(Goal).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CollectionName: ").Append(CollectionName).Append("\n");
            sb.Append("  ConnectorField: ").Append(ConnectorField).Append("\n");
            
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
            return this.Equals(obj as ABTestingReport);
        }

        /// <summary>
        /// Returns true if ABTestingReport instances are equal
        /// </summary>
        /// <param name="obj">Instance of ABTestingReport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ABTestingReport other)
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
                    this.Variants == other.Variants ||
                    this.Variants != null &&
                    this.Variants.SequenceEqual(other.Variants)
                ) && 
                (
                    this.Goal == other.Goal ||
                    this.Goal != null &&
                    this.Goal.Equals(other.Goal)
                ) && 
                (
                    this.Options == other.Options ||
                    this.Options != null &&
                    this.Options.Equals(other.Options)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.CollectionName == other.CollectionName ||
                    this.CollectionName != null &&
                    this.CollectionName.Equals(other.CollectionName)
                ) && 
                (
                    this.ConnectorField == other.ConnectorField ||
                    this.ConnectorField != null &&
                    this.ConnectorField.Equals(other.ConnectorField)
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
                
                if (this.Variants != null)
                    hash = hash * 57 + this.Variants.GetHashCode();
                
                if (this.Goal != null)
                    hash = hash * 57 + this.Goal.GetHashCode();
                
                if (this.Options != null)
                    hash = hash * 57 + this.Options.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 57 + this.Id.GetHashCode();
                
                if (this.CollectionName != null)
                    hash = hash * 57 + this.CollectionName.GetHashCode();
                
                if (this.ConnectorField != null)
                    hash = hash * 57 + this.ConnectorField.GetHashCode();
                
                return hash;
            }
        }

    }
}
