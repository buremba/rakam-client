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
    public class FunnelStep :  IEquatable<FunnelStep>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FunnelStep" /> class.
        /// </summary>
        public FunnelStep()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Collection
        /// </summary>
        [DataMember(Name="collection", EmitDefaultValue=false)]
        public string Collection { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FunnelStep {\n");
            sb.Append("  Collection: ").Append(Collection).Append("\n");
            
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
            return this.Equals(obj as FunnelStep);
        }

        /// <summary>
        /// Returns true if FunnelStep instances are equal
        /// </summary>
        /// <param name="obj">Instance of FunnelStep to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FunnelStep other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Collection == other.Collection ||
                    this.Collection != null &&
                    this.Collection.Equals(other.Collection)
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
                
                if (this.Collection != null)
                    hash = hash * 57 + this.Collection.GetHashCode();
                
                return hash;
            }
        }

    }
}
