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
    public class Threshold :  IEquatable<Threshold>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Threshold" /> class.
        /// </summary>
        public Threshold()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Aggregation
        /// </summary>
        [DataMember(Name="aggregation", EmitDefaultValue=false)]
        public string Aggregation { get; set; }
  
        
        /// <summary>
        /// Gets or Sets FieldName
        /// </summary>
        [DataMember(Name="fieldName", EmitDefaultValue=false)]
        public string FieldName { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public long? Value { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Threshold {\n");
            sb.Append("  Aggregation: ").Append(Aggregation).Append("\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            
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
            return this.Equals(obj as Threshold);
        }

        /// <summary>
        /// Returns true if Threshold instances are equal
        /// </summary>
        /// <param name="obj">Instance of Threshold to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Threshold other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Aggregation == other.Aggregation ||
                    this.Aggregation != null &&
                    this.Aggregation.Equals(other.Aggregation)
                ) && 
                (
                    this.FieldName == other.FieldName ||
                    this.FieldName != null &&
                    this.FieldName.Equals(other.FieldName)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
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
                
                if (this.Aggregation != null)
                    hash = hash * 57 + this.Aggregation.GetHashCode();
                
                if (this.FieldName != null)
                    hash = hash * 57 + this.FieldName.GetHashCode();
                
                if (this.Value != null)
                    hash = hash * 57 + this.Value.GetHashCode();
                
                return hash;
            }
        }

    }
}
