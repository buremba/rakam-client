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
    public class EmailActionConfig :  IEquatable<EmailActionConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailActionConfig" /> class.
        /// </summary>
        public EmailActionConfig()
        {
            this.RichText = false;
            
        }

        
        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ColumnName
        /// </summary>
        [DataMember(Name="columnName", EmitDefaultValue=false)]
        public string ColumnName { get; set; }
  
        
        /// <summary>
        /// Gets or Sets DefaultValues
        /// </summary>
        [DataMember(Name="defaultValues", EmitDefaultValue=false)]
        public Dictionary<string, string> DefaultValues { get; set; }
  
        
        /// <summary>
        /// Gets or Sets RichText
        /// </summary>
        [DataMember(Name="richText", EmitDefaultValue=false)]
        public bool? RichText { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailActionConfig {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  ColumnName: ").Append(ColumnName).Append("\n");
            sb.Append("  DefaultValues: ").Append(DefaultValues).Append("\n");
            sb.Append("  RichText: ").Append(RichText).Append("\n");
            
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
            return this.Equals(obj as EmailActionConfig);
        }

        /// <summary>
        /// Returns true if EmailActionConfig instances are equal
        /// </summary>
        /// <param name="obj">Instance of EmailActionConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailActionConfig other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.Content == other.Content ||
                    this.Content != null &&
                    this.Content.Equals(other.Content)
                ) && 
                (
                    this.ColumnName == other.ColumnName ||
                    this.ColumnName != null &&
                    this.ColumnName.Equals(other.ColumnName)
                ) && 
                (
                    this.DefaultValues == other.DefaultValues ||
                    this.DefaultValues != null &&
                    this.DefaultValues.SequenceEqual(other.DefaultValues)
                ) && 
                (
                    this.RichText == other.RichText ||
                    this.RichText != null &&
                    this.RichText.Equals(other.RichText)
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
                
                if (this.Title != null)
                    hash = hash * 57 + this.Title.GetHashCode();
                
                if (this.Content != null)
                    hash = hash * 57 + this.Content.GetHashCode();
                
                if (this.ColumnName != null)
                    hash = hash * 57 + this.ColumnName.GetHashCode();
                
                if (this.DefaultValues != null)
                    hash = hash * 57 + this.DefaultValues.GetHashCode();
                
                if (this.RichText != null)
                    hash = hash * 57 + this.RichText.GetHashCode();
                
                return hash;
            }
        }

    }
}
