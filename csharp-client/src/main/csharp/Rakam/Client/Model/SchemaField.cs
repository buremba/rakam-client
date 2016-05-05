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
    public class SchemaField :  IEquatable<SchemaField>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaField" /> class.
        /// </summary>
        public SchemaField()
        {
            this.Unique = false;
            
        }

        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Unique
        /// </summary>
        [DataMember(Name="unique", EmitDefaultValue=false)]
        public bool? Unique { get; set; }
  
        
        /// <summary>
        /// Gets or Sets DescriptiveName
        /// </summary>
        [DataMember(Name="descriptiveName", EmitDefaultValue=false)]
        public string DescriptiveName { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SchemaField {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Unique: ").Append(Unique).Append("\n");
            sb.Append("  DescriptiveName: ").Append(DescriptiveName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            
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
            return this.Equals(obj as SchemaField);
        }

        /// <summary>
        /// Returns true if SchemaField instances are equal
        /// </summary>
        /// <param name="obj">Instance of SchemaField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SchemaField other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Unique == other.Unique ||
                    this.Unique != null &&
                    this.Unique.Equals(other.Unique)
                ) && 
                (
                    this.DescriptiveName == other.DescriptiveName ||
                    this.DescriptiveName != null &&
                    this.DescriptiveName.Equals(other.DescriptiveName)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
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
                
                if (this.Name != null)
                    hash = hash * 57 + this.Name.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 57 + this.Type.GetHashCode();
                
                if (this.Unique != null)
                    hash = hash * 57 + this.Unique.GetHashCode();
                
                if (this.DescriptiveName != null)
                    hash = hash * 57 + this.DescriptiveName.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 57 + this.Description.GetHashCode();
                
                if (this.Category != null)
                    hash = hash * 57 + this.Category.GetHashCode();
                
                return hash;
            }
        }

    }
}
