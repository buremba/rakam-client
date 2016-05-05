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
    public class Message :  IEquatable<Message>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Message" /> class.
        /// </summary>
        public Message()
        {
            this.Seen = false;
            
        }

        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }
  
        
        /// <summary>
        /// Gets or Sets FromUser
        /// </summary>
        [DataMember(Name="from_user", EmitDefaultValue=false)]
        public Object FromUser { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ToUser
        /// </summary>
        [DataMember(Name="to_user", EmitDefaultValue=false)]
        public Object ToUser { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ParentId
        /// </summary>
        [DataMember(Name="parentId", EmitDefaultValue=false)]
        public int? ParentId { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Seen
        /// </summary>
        [DataMember(Name="seen", EmitDefaultValue=false)]
        public bool? Seen { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public long? Time { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Project
        /// </summary>
        [DataMember(Name="project", EmitDefaultValue=false)]
        public string Project { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Message {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  FromUser: ").Append(FromUser).Append("\n");
            sb.Append("  ToUser: ").Append(ToUser).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  Seen: ").Append(Seen).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            
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
            return this.Equals(obj as Message);
        }

        /// <summary>
        /// Returns true if Message instances are equal
        /// </summary>
        /// <param name="obj">Instance of Message to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Message other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Content == other.Content ||
                    this.Content != null &&
                    this.Content.Equals(other.Content)
                ) && 
                (
                    this.FromUser == other.FromUser ||
                    this.FromUser != null &&
                    this.FromUser.Equals(other.FromUser)
                ) && 
                (
                    this.ToUser == other.ToUser ||
                    this.ToUser != null &&
                    this.ToUser.Equals(other.ToUser)
                ) && 
                (
                    this.ParentId == other.ParentId ||
                    this.ParentId != null &&
                    this.ParentId.Equals(other.ParentId)
                ) && 
                (
                    this.Seen == other.Seen ||
                    this.Seen != null &&
                    this.Seen.Equals(other.Seen)
                ) && 
                (
                    this.Time == other.Time ||
                    this.Time != null &&
                    this.Time.Equals(other.Time)
                ) && 
                (
                    this.Project == other.Project ||
                    this.Project != null &&
                    this.Project.Equals(other.Project)
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
                
                if (this.Id != null)
                    hash = hash * 57 + this.Id.GetHashCode();
                
                if (this.Content != null)
                    hash = hash * 57 + this.Content.GetHashCode();
                
                if (this.FromUser != null)
                    hash = hash * 57 + this.FromUser.GetHashCode();
                
                if (this.ToUser != null)
                    hash = hash * 57 + this.ToUser.GetHashCode();
                
                if (this.ParentId != null)
                    hash = hash * 57 + this.ParentId.GetHashCode();
                
                if (this.Seen != null)
                    hash = hash * 57 + this.Seen.GetHashCode();
                
                if (this.Time != null)
                    hash = hash * 57 + this.Time.GetHashCode();
                
                if (this.Project != null)
                    hash = hash * 57 + this.Project.GetHashCode();
                
                return hash;
            }
        }

    }
}
