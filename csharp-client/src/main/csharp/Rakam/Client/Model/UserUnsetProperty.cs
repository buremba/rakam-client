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
    public class UserUnsetProperty :  IEquatable<UserUnsetProperty>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserUnsetProperty" /> class.
        /// </summary>
        public UserUnsetProperty()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Project
        /// </summary>
        [DataMember(Name="project", EmitDefaultValue=false)]
        public string Project { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Api
        /// </summary>
        [DataMember(Name="api", EmitDefaultValue=false)]
        public UserContext Api { get; set; }
  
        
        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public string User { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Property
        /// </summary>
        [DataMember(Name="property", EmitDefaultValue=false)]
        public List<string> Property { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserUnsetProperty {\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  Api: ").Append(Api).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Property: ").Append(Property).Append("\n");
            
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
            return this.Equals(obj as UserUnsetProperty);
        }

        /// <summary>
        /// Returns true if UserUnsetProperty instances are equal
        /// </summary>
        /// <param name="obj">Instance of UserUnsetProperty to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserUnsetProperty other)
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
                    this.Api == other.Api ||
                    this.Api != null &&
                    this.Api.Equals(other.Api)
                ) && 
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) && 
                (
                    this.Property == other.Property ||
                    this.Property != null &&
                    this.Property.SequenceEqual(other.Property)
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
                
                if (this.Api != null)
                    hash = hash * 57 + this.Api.GetHashCode();
                
                if (this.User != null)
                    hash = hash * 57 + this.User.GetHashCode();
                
                if (this.Property != null)
                    hash = hash * 57 + this.Property.GetHashCode();
                
                return hash;
            }
        }

    }
}
