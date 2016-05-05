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
    public class Sorting :  IEquatable<Sorting>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Sorting" /> class.
        /// </summary>
        public Sorting()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Column
        /// </summary>
        [DataMember(Name="column", EmitDefaultValue=false)]
        public string Column { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public string Order { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Sorting {\n");
            sb.Append("  Column: ").Append(Column).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            
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
            return this.Equals(obj as Sorting);
        }

        /// <summary>
        /// Returns true if Sorting instances are equal
        /// </summary>
        /// <param name="obj">Instance of Sorting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Sorting other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Column == other.Column ||
                    this.Column != null &&
                    this.Column.Equals(other.Column)
                ) && 
                (
                    this.Order == other.Order ||
                    this.Order != null &&
                    this.Order.Equals(other.Order)
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
                
                if (this.Column != null)
                    hash = hash * 57 + this.Column.GetHashCode();
                
                if (this.Order != null)
                    hash = hash * 57 + this.Order.GetHashCode();
                
                return hash;
            }
        }

    }
}
