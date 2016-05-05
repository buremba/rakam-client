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
    public class MetadataResponse :  IEquatable<MetadataResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataResponse" /> class.
        /// </summary>
        public MetadataResponse()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Columns
        /// </summary>
        [DataMember(Name="columns", EmitDefaultValue=false)]
        public List<SchemaField> Columns { get; set; }
  
        
        /// <summary>
        /// Gets or Sets IdentifierColumn
        /// </summary>
        [DataMember(Name="identifierColumn", EmitDefaultValue=false)]
        public string IdentifierColumn { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetadataResponse {\n");
            sb.Append("  Columns: ").Append(Columns).Append("\n");
            sb.Append("  IdentifierColumn: ").Append(IdentifierColumn).Append("\n");
            
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
            return this.Equals(obj as MetadataResponse);
        }

        /// <summary>
        /// Returns true if MetadataResponse instances are equal
        /// </summary>
        /// <param name="obj">Instance of MetadataResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetadataResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Columns == other.Columns ||
                    this.Columns != null &&
                    this.Columns.SequenceEqual(other.Columns)
                ) && 
                (
                    this.IdentifierColumn == other.IdentifierColumn ||
                    this.IdentifierColumn != null &&
                    this.IdentifierColumn.Equals(other.IdentifierColumn)
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
                
                if (this.Columns != null)
                    hash = hash * 57 + this.Columns.GetHashCode();
                
                if (this.IdentifierColumn != null)
                    hash = hash * 57 + this.IdentifierColumn.GetHashCode();
                
                return hash;
            }
        }

    }
}
