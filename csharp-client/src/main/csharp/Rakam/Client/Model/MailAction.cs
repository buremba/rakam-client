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
    public class MailAction :  IEquatable<MailAction>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MailAction" /> class.
        /// </summary>
        public MailAction()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Variables
        /// </summary>
        [DataMember(Name="variables", EmitDefaultValue=false)]
        public Dictionary<string, string> Variables { get; set; }
  
        
        /// <summary>
        /// Gets or Sets FromUser
        /// </summary>
        [DataMember(Name="fromUser", EmitDefaultValue=false)]
        public string FromUser { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MailAction {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Variables: ").Append(Variables).Append("\n");
            sb.Append("  FromUser: ").Append(FromUser).Append("\n");
            
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
            return this.Equals(obj as MailAction);
        }

        /// <summary>
        /// Returns true if MailAction instances are equal
        /// </summary>
        /// <param name="obj">Instance of MailAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MailAction other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this.Variables == other.Variables ||
                    this.Variables != null &&
                    this.Variables.SequenceEqual(other.Variables)
                ) && 
                (
                    this.FromUser == other.FromUser ||
                    this.FromUser != null &&
                    this.FromUser.Equals(other.FromUser)
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
                
                if (this.Message != null)
                    hash = hash * 57 + this.Message.GetHashCode();
                
                if (this.Variables != null)
                    hash = hash * 57 + this.Variables.GetHashCode();
                
                if (this.FromUser != null)
                    hash = hash * 57 + this.FromUser.GetHashCode();
                
                return hash;
            }
        }

    }
}
