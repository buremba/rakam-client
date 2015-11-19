using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Rakam.Client.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class QueryError {
    
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
    /// Gets or Sets Query
    /// </summary>
    [DataMember(Name="query", EmitDefaultValue=false)]
    public string Query { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class QueryError {\n");
      
      sb.Append("  Message: ").Append(Message).Append("\n");
      
      sb.Append("  SqlState: ").Append(SqlState).Append("\n");
      
      sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
      
      sb.Append("  Query: ").Append(Query).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
