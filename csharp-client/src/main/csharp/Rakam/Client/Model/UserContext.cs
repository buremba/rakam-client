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
    public class UserContext :  IEquatable<UserContext>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserContext" /> class.
        /// </summary>
        public UserContext()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets WriteKey
        /// </summary>
        [DataMember(Name="writeKey", EmitDefaultValue=false)]
        public string WriteKey { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ApiVersion
        /// </summary>
        [DataMember(Name="apiVersion", EmitDefaultValue=false)]
        public string ApiVersion { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserContext {\n");
            sb.Append("  WriteKey: ").Append(WriteKey).Append("\n");
            sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
            
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
            return this.Equals(obj as UserContext);
        }

        /// <summary>
        /// Returns true if UserContext instances are equal
        /// </summary>
        /// <param name="obj">Instance of UserContext to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserContext other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.WriteKey == other.WriteKey ||
                    this.WriteKey != null &&
                    this.WriteKey.Equals(other.WriteKey)
                ) && 
                (
                    this.ApiVersion == other.ApiVersion ||
                    this.ApiVersion != null &&
                    this.ApiVersion.Equals(other.ApiVersion)
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
                
                if (this.WriteKey != null)
                    hash = hash * 57 + this.WriteKey.GetHashCode();
                
                if (this.ApiVersion != null)
                    hash = hash * 57 + this.ApiVersion.GetHashCode();
                
                return hash;
            }
        }

    }
}
