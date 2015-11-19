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
  public class Threshold {
    
    /// <summary>
    /// Gets or Sets Aggregation
    /// </summary>
    [DataMember(Name="aggregation", EmitDefaultValue=false)]
    public string Aggregation { get; set; }

    
    /// <summary>
    /// Gets or Sets FieldName
    /// </summary>
    [DataMember(Name="fieldName", EmitDefaultValue=false)]
    public string FieldName { get; set; }

    
    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    [DataMember(Name="value", EmitDefaultValue=false)]
    public long? Value { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Threshold {\n");
      
      sb.Append("  Aggregation: ").Append(Aggregation).Append("\n");
      
      sb.Append("  FieldName: ").Append(FieldName).Append("\n");
      
      sb.Append("  Value: ").Append(Value).Append("\n");
      
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
