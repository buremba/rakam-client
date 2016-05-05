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
    public class EventContext :  IEquatable<EventContext>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventContext" /> class.
        /// </summary>
        public EventContext()
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
        /// Gets or Sets UploadTime
        /// </summary>
        [DataMember(Name="uploadTime", EmitDefaultValue=false)]
        public long? UploadTime { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Checksum
        /// </summary>
        [DataMember(Name="checksum", EmitDefaultValue=false)]
        public string Checksum { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventContext {\n");
            sb.Append("  WriteKey: ").Append(WriteKey).Append("\n");
            sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  UploadTime: ").Append(UploadTime).Append("\n");
            sb.Append("  Checksum: ").Append(Checksum).Append("\n");
            
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
            return this.Equals(obj as EventContext);
        }

        /// <summary>
        /// Returns true if EventContext instances are equal
        /// </summary>
        /// <param name="obj">Instance of EventContext to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventContext other)
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
                ) && 
                (
                    this.UploadTime == other.UploadTime ||
                    this.UploadTime != null &&
                    this.UploadTime.Equals(other.UploadTime)
                ) && 
                (
                    this.Checksum == other.Checksum ||
                    this.Checksum != null &&
                    this.Checksum.Equals(other.Checksum)
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
                
                if (this.UploadTime != null)
                    hash = hash * 57 + this.UploadTime.GetHashCode();
                
                if (this.Checksum != null)
                    hash = hash * 57 + this.Checksum.GetHashCode();
                
                return hash;
            }
        }

    }
}
