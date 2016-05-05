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
    public class QueryError :  IEquatable<QueryError>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryError" /> class.
        /// </summary>
        public QueryError()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }
  
        
        /// <summary>
        /// Gets or Sets SqlState
        /// </summary>
        [DataMember(Name="sqlState", EmitDefaultValue=false)]
        public string SqlState { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public int? ErrorCode { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ErrorLine
        /// </summary>
        [DataMember(Name="errorLine", EmitDefaultValue=false)]
        public int? ErrorLine { get; set; }
  
        
        /// <summary>
        /// Gets or Sets CharPositionInLine
        /// </summary>
        [DataMember(Name="charPositionInLine", EmitDefaultValue=false)]
        public int? CharPositionInLine { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryError {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  SqlState: ").Append(SqlState).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ErrorLine: ").Append(ErrorLine).Append("\n");
            sb.Append("  CharPositionInLine: ").Append(CharPositionInLine).Append("\n");
            
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
            return this.Equals(obj as QueryError);
        }

        /// <summary>
        /// Returns true if QueryError instances are equal
        /// </summary>
        /// <param name="obj">Instance of QueryError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryError other)
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
                    this.SqlState == other.SqlState ||
                    this.SqlState != null &&
                    this.SqlState.Equals(other.SqlState)
                ) && 
                (
                    this.ErrorCode == other.ErrorCode ||
                    this.ErrorCode != null &&
                    this.ErrorCode.Equals(other.ErrorCode)
                ) && 
                (
                    this.ErrorLine == other.ErrorLine ||
                    this.ErrorLine != null &&
                    this.ErrorLine.Equals(other.ErrorLine)
                ) && 
                (
                    this.CharPositionInLine == other.CharPositionInLine ||
                    this.CharPositionInLine != null &&
                    this.CharPositionInLine.Equals(other.CharPositionInLine)
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
                
                if (this.SqlState != null)
                    hash = hash * 57 + this.SqlState.GetHashCode();
                
                if (this.ErrorCode != null)
                    hash = hash * 57 + this.ErrorCode.GetHashCode();
                
                if (this.ErrorLine != null)
                    hash = hash * 57 + this.ErrorLine.GetHashCode();
                
                if (this.CharPositionInLine != null)
                    hash = hash * 57 + this.CharPositionInLine.GetHashCode();
                
                return hash;
            }
        }

    }
}
