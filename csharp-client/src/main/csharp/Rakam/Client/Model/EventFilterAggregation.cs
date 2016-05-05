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
    public class EventFilterAggregation :  IEquatable<EventFilterAggregation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventFilterAggregation" /> class.
        /// </summary>
        public EventFilterAggregation()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Field
        /// </summary>
        [DataMember(Name="field", EmitDefaultValue=false)]
        public string Field { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Minimum
        /// </summary>
        [DataMember(Name="minimum", EmitDefaultValue=false)]
        public long? Minimum { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Maximum
        /// </summary>
        [DataMember(Name="maximum", EmitDefaultValue=false)]
        public long? Maximum { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventFilterAggregation {\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  Minimum: ").Append(Minimum).Append("\n");
            sb.Append("  Maximum: ").Append(Maximum).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            
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
            return this.Equals(obj as EventFilterAggregation);
        }

        /// <summary>
        /// Returns true if EventFilterAggregation instances are equal
        /// </summary>
        /// <param name="obj">Instance of EventFilterAggregation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventFilterAggregation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Field == other.Field ||
                    this.Field != null &&
                    this.Field.Equals(other.Field)
                ) && 
                (
                    this.Minimum == other.Minimum ||
                    this.Minimum != null &&
                    this.Minimum.Equals(other.Minimum)
                ) && 
                (
                    this.Maximum == other.Maximum ||
                    this.Maximum != null &&
                    this.Maximum.Equals(other.Maximum)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                
                if (this.Field != null)
                    hash = hash * 57 + this.Field.GetHashCode();
                
                if (this.Minimum != null)
                    hash = hash * 57 + this.Minimum.GetHashCode();
                
                if (this.Maximum != null)
                    hash = hash * 57 + this.Maximum.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 57 + this.Type.GetHashCode();
                
                return hash;
            }
        }

    }
}
