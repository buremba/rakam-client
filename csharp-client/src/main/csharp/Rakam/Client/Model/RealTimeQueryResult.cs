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
    public class RealTimeQueryResult :  IEquatable<RealTimeQueryResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RealTimeQueryResult" /> class.
        /// </summary>
        public RealTimeQueryResult()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Start
        /// </summary>
        [DataMember(Name="start", EmitDefaultValue=false)]
        public long? Start { get; set; }
  
        
        /// <summary>
        /// Gets or Sets End
        /// </summary>
        [DataMember(Name="end", EmitDefaultValue=false)]
        public long? End { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [DataMember(Name="result", EmitDefaultValue=false)]
        public Object Result { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RealTimeQueryResult {\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  End: ").Append(End).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            
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
            return this.Equals(obj as RealTimeQueryResult);
        }

        /// <summary>
        /// Returns true if RealTimeQueryResult instances are equal
        /// </summary>
        /// <param name="obj">Instance of RealTimeQueryResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RealTimeQueryResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Start == other.Start ||
                    this.Start != null &&
                    this.Start.Equals(other.Start)
                ) && 
                (
                    this.End == other.End ||
                    this.End != null &&
                    this.End.Equals(other.End)
                ) && 
                (
                    this.Result == other.Result ||
                    this.Result != null &&
                    this.Result.Equals(other.Result)
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
                
                if (this.Start != null)
                    hash = hash * 57 + this.Start.GetHashCode();
                
                if (this.End != null)
                    hash = hash * 57 + this.End.GetHashCode();
                
                if (this.Result != null)
                    hash = hash * 57 + this.Result.GetHashCode();
                
                return hash;
            }
        }

    }
}
