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
    public class UserMergeUser :  IEquatable<UserMergeUser>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserMergeUser" /> class.
        /// </summary>
        public UserMergeUser()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Project
        /// </summary>
        [DataMember(Name="project", EmitDefaultValue=false)]
        public string Project { get; set; }
  
        
        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public string User { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Api
        /// </summary>
        [DataMember(Name="api", EmitDefaultValue=false)]
        public UserContext Api { get; set; }
  
        
        /// <summary>
        /// Gets or Sets AnonymousId
        /// </summary>
        [DataMember(Name="anonymous_id", EmitDefaultValue=false)]
        public string AnonymousId { get; set; }
  
        
        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }
  
        
        /// <summary>
        /// Gets or Sets MergedAt
        /// </summary>
        [DataMember(Name="merged_at", EmitDefaultValue=false)]
        public DateTime? MergedAt { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserMergeUser {\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Api: ").Append(Api).Append("\n");
            sb.Append("  AnonymousId: ").Append(AnonymousId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  MergedAt: ").Append(MergedAt).Append("\n");
            
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
            return this.Equals(obj as UserMergeUser);
        }

        /// <summary>
        /// Returns true if UserMergeUser instances are equal
        /// </summary>
        /// <param name="obj">Instance of UserMergeUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserMergeUser other)
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
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) && 
                (
                    this.Api == other.Api ||
                    this.Api != null &&
                    this.Api.Equals(other.Api)
                ) && 
                (
                    this.AnonymousId == other.AnonymousId ||
                    this.AnonymousId != null &&
                    this.AnonymousId.Equals(other.AnonymousId)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.MergedAt == other.MergedAt ||
                    this.MergedAt != null &&
                    this.MergedAt.Equals(other.MergedAt)
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
                
                if (this.User != null)
                    hash = hash * 57 + this.User.GetHashCode();
                
                if (this.Api != null)
                    hash = hash * 57 + this.Api.GetHashCode();
                
                if (this.AnonymousId != null)
                    hash = hash * 57 + this.AnonymousId.GetHashCode();
                
                if (this.CreatedAt != null)
                    hash = hash * 57 + this.CreatedAt.GetHashCode();
                
                if (this.MergedAt != null)
                    hash = hash * 57 + this.MergedAt.GetHashCode();
                
                return hash;
            }
        }

    }
}
