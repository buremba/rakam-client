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
    public class QueryResult :  IEquatable<QueryResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryResult" /> class.
        /// </summary>
        public QueryResult()
        {
            this.Failed = false;
            
        }

        
        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public List<SchemaField> Metadata { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [DataMember(Name="result", EmitDefaultValue=false)]
        public List<List<Object>> Result { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public QueryError Error { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public Dictionary<string, InlineResponse200> Properties { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Failed
        /// </summary>
        [DataMember(Name="failed", EmitDefaultValue=false)]
        public bool? Failed { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryResult {\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Failed: ").Append(Failed).Append("\n");
            
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
            return this.Equals(obj as QueryResult);
        }

        /// <summary>
        /// Returns true if QueryResult instances are equal
        /// </summary>
        /// <param name="obj">Instance of QueryResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.SequenceEqual(other.Metadata)
                ) && 
                (
                    this.Result == other.Result ||
                    this.Result != null &&
                    this.Result.SequenceEqual(other.Result)
                ) && 
                (
                    this.Error == other.Error ||
                    this.Error != null &&
                    this.Error.Equals(other.Error)
                ) && 
                (
                    this.Properties == other.Properties ||
                    this.Properties != null &&
                    this.Properties.SequenceEqual(other.Properties)
                ) && 
                (
                    this.Failed == other.Failed ||
                    this.Failed != null &&
                    this.Failed.Equals(other.Failed)
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
                
                if (this.Metadata != null)
                    hash = hash * 57 + this.Metadata.GetHashCode();
                
                if (this.Result != null)
                    hash = hash * 57 + this.Result.GetHashCode();
                
                if (this.Error != null)
                    hash = hash * 57 + this.Error.GetHashCode();
                
                if (this.Properties != null)
                    hash = hash * 57 + this.Properties.GetHashCode();
                
                if (this.Failed != null)
                    hash = hash * 57 + this.Failed.GetHashCode();
                
                return hash;
            }
        }

    }
}
